using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    public partial class UserHome : UserControl
    {
        private string _username = "";

        private Chart _userChart;
        private Chart _departmentChart;
        private ComboBox _cmbChartMode;

        public UserHome()
        {
            InitializeComponent();
        }

        public void LoadUser(string username)
        {
            _username = username ?? "";

            SetupChart();
            SetupHeader();

            colActivity.FillWeight = 60;
            colDate.FillWeight = 20;
            colStatus.FillWeight = 20;

            dgvActivity.RowTemplate.Height = 28;

            LoadAnalytics();
        }

        public void LoadAnalytics()
        {
            LoadStatCards();
            LoadChart();
            LoadDepartmentChart();
            LoadRecentActivity();
        }

        
        private void SetupHeader()
        {
            string displayName = GetUserDisplayName(_username);
            if (string.IsNullOrWhiteSpace(displayName))
                displayName = _username;

            lblWelcome.Text = "My Dashboard";
            lblWelcomeSub.Text = "Welcome back, " + displayName;
        }

        private string GetUserDisplayName(string username)
        {
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    using (OleDbCommand cmd = new OleDbCommand(
                        "SELECT [fullName] FROM [Users] WHERE [username]=? AND [role]='user'", conn))
                    {
                        cmd.Parameters.AddWithValue("?", username);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            return result.ToString();
                    }
                }
            }
            catch { }

            return "";
        }


        private void SetupChart()
        {
            panelChart.Controls.Clear();

            _userChart = BuildChart("Lost", Color.FromArgb(180, 30, 30),
                                    "Found", Color.FromArgb(15, 110, 86));

            _departmentChart = BuildChart("Lost", Color.FromArgb(180, 30, 30),
                                          "Found", Color.FromArgb(15, 110, 86));

            _departmentChart.Visible = false;

            _cmbChartMode = new ComboBox
            {
                Dock = DockStyle.Top,
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            _cmbChartMode.Items.Add("My Activity Chart");
            _cmbChartMode.Items.Add("Department Overview");
            _cmbChartMode.SelectedIndex = 0;

            _cmbChartMode.SelectedIndexChanged += (s, e) =>
            {
                _userChart.Visible = _cmbChartMode.SelectedIndex == 0;
                _departmentChart.Visible = _cmbChartMode.SelectedIndex == 1;
            };

            panelChart.Controls.Add(_departmentChart);
            panelChart.Controls.Add(_userChart);
            panelChart.Controls.Add(_cmbChartMode);
        }


        private Chart BuildChart(string s1, Color c1, string s2, Color c2)
        {
            Chart chart = new Chart
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(217, 175, 134)
            };

            ChartArea area = new ChartArea();
            area.AxisX.LabelStyle.Font = new Font("Letters for Learners", 10F, FontStyle.Bold);
            area.AxisY.LabelStyle.Font = new Font("Letters for Learners", 10F, FontStyle.Bold);
            area.BackColor = Color.FromArgb(217, 175, 134);

            area.AxisX.LabelStyle.ForeColor = Color.FromArgb(74, 14, 26);
            area.AxisY.LabelStyle.ForeColor = Color.FromArgb(74, 14, 26);

            area.AxisX.MajorGrid.LineColor = Color.FromArgb(196, 154, 106);
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(196, 154, 106);
            area.AxisX.TitleFont = new Font("Letters for Learners", 12F, FontStyle.Bold);
            area.AxisY.TitleFont = new Font("Letters for Learners", 12F, FontStyle.Bold);

            chart.ChartAreas.Add(area);

            Legend legend = new Legend
            {
                BackColor = Color.FromArgb(217, 175, 134),
                ForeColor = Color.FromArgb(74, 14, 26),
                Font = new Font("Letters for Learners", 12F, FontStyle.Bold)
            };

            chart.Legends.Add(legend);

            Series lost = new Series(s1)
            {
                ChartType = SeriesChartType.Column,
                Color = c1,
                Font = new Font("Letters for Learners", 12F, FontStyle.Bold)
            };

            Series found = new Series(s2)
            {
                ChartType = SeriesChartType.Column,
                Color = c2,
                Font = new Font("Letters for Learners", 12F, FontStyle.Bold)
            };

            chart.Series.Add(lost);
            chart.Series.Add(found);

            return chart;
        }


        private void LoadChart()
        {
            var categories = new List<string>();
            var lostValues = new List<int>();
            var foundValues = new List<int>();

            using (OleDbConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                using (OleDbCommand cmd = new OleDbCommand(
                    "SELECT DISTINCT [classification] FROM [Items] WHERE [reporter]=?",
                    conn))
                {
                    cmd.Parameters.AddWithValue("?", _username);
                    using (var r = cmd.ExecuteReader())
                        while (r.Read())
                            categories.Add(r[0].ToString());
                }

                if (categories.Count == 0)
                    categories.Add("No Data");

                foreach (var c in categories)
                {
                    lostValues.Add(Count(conn,
                        "SELECT COUNT(*) FROM Items WHERE reporter='" + _username + "' AND classification='" + c + "' AND status='Lost'"));

                    foundValues.Add(Count(conn,
                        "SELECT COUNT(*) FROM Items WHERE reporter='" + _username + "' AND classification='" + c + "' AND status='Found'"));
                }
            }

            var lost = _userChart.Series[0];
            var found = _userChart.Series[1];

            lost.Points.Clear();
            found.Points.Clear();

            for (int i = 0; i < categories.Count; i++)
            {
                lost.Points.AddXY(categories[i], lostValues[i]);
                found.Points.AddXY(categories[i], foundValues[i]);
            }

            _userChart.Refresh();
        }


        private void LoadDepartmentChart()
        {
            var departments = new List<string>();
            var lost = new List<int>();
            var found = new List<int>();

            using (OleDbConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                
                using (OleDbCommand cmd = new OleDbCommand(
                    @"SELECT TOP 5 u.department,
                     COUNT(i.itemID) AS totalReports
              FROM Users u
              LEFT JOIN Items i ON i.reporter = u.username
              WHERE u.department <> ''
              GROUP BY u.department
              ORDER BY COUNT(i.itemID) DESC", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        departments.Add(reader["department"].ToString());
                }

                if (departments.Count == 0)
                {
                    departments.Add("No Data");
                }

                
                foreach (var d in departments)
                {
                    lost.Add(Count(conn,
                        "SELECT COUNT(*) FROM Items i " +
                        "INNER JOIN Users u ON i.reporter=u.username " +
                        "WHERE u.department='" + d + "' AND i.status='Lost'"));

                    found.Add(Count(conn,
                        "SELECT COUNT(*) FROM Items i " +
                        "INNER JOIN Users u ON i.reporter=u.username " +
                        "WHERE u.department='" + d + "' AND i.status='Found'"));
                }
            }

            
            var lostSeries = _departmentChart.Series[0];
            var foundSeries = _departmentChart.Series[1];

            lostSeries.Points.Clear();
            foundSeries.Points.Clear();

            for (int i = 0; i < departments.Count; i++)
            {
                lostSeries.Points.AddXY(departments[i], lost[i]);
                foundSeries.Points.AddXY(departments[i], found[i]);
            }

            _departmentChart.Refresh();
        }

        private void LoadStatCards()
        {
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    
                    using (OleDbCommand cmd = new OleDbCommand(
                        "SELECT COUNT(*) FROM Items WHERE reporter=? AND status='Lost'", conn))
                    {
                        cmd.Parameters.AddWithValue("?", _username);
                        lblLostCount.Text = cmd.ExecuteScalar().ToString();
                    }

                    
                    using (OleDbCommand cmd = new OleDbCommand(
                        "SELECT COUNT(*) FROM Items WHERE reporter=? AND status='Found'", conn))
                    {
                        cmd.Parameters.AddWithValue("?", _username);
                        lblFoundCount.Text = cmd.ExecuteScalar().ToString();
                    }

                    
                    using (OleDbCommand cmd = new OleDbCommand(
                        "SELECT COUNT(*) FROM ClaimRequests WHERE username=? AND status='Pending'", conn))
                    {
                        cmd.Parameters.AddWithValue("?", _username);
                        lblRequestCount.Text = cmd.ExecuteScalar().ToString();
                    }

                    
                    using (OleDbCommand cmd = new OleDbCommand(
                        "SELECT COUNT(*) FROM Matches m INNER JOIN Items i ON m.lostItemID=i.itemID " +
                        "WHERE i.reporter=? AND m.status='Confirmed'", conn))
                    {
                        cmd.Parameters.AddWithValue("?", _username);
                        lblApprovedCount.Text = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stat cards:\n" + ex.Message);
            }
        }

        private void LoadRecentActivity()
        {
            dgvActivity.Rows.Clear();

            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    using (OleDbCommand itemCmd = new OleDbCommand(
                        "SELECT TOP 5 name, date, status FROM Items WHERE reporter=? ORDER BY date DESC", conn))
                    {
                        itemCmd.Parameters.AddWithValue("?", _username);
                        using (var r = itemCmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                string name = r["name"].ToString();
                                string status = r["status"].ToString();
                                string date = r["date"].ToString();
                                int row = dgvActivity.Rows.Add($"Reported \"{name}\" as {status}", date, status);
                                Colorize(row, status.ToLower());
                            }
                        }
                    }

                    using (OleDbCommand claimCmd = new OleDbCommand(
                        "SELECT TOP 5 itemName, dateFiled, status FROM ClaimRequests WHERE username=? ORDER BY dateFiled DESC", conn))
                    {
                        claimCmd.Parameters.AddWithValue("?", _username);
                        using (var r = claimCmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                string name = r["itemName"].ToString();
                                string status = r["status"].ToString();
                                string date = r["dateFiled"].ToString();
                                int row = dgvActivity.Rows.Add($"Claim filed for \"{name}\"", date, status);
                                Colorize(row, status.ToLower());
                            }
                        }
                    }
                }

                if (dgvActivity.Rows.Count == 0)
                    dgvActivity.Rows.Add("No recent activity", "---", "---");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading activity:\n" + ex.Message);
            }
        }

        private void Colorize(int rowIndex, string status)
        {
            Color c;

            if (status == "lost") c = Color.FromArgb(180, 30, 30);
            else if (status == "found") c = Color.FromArgb(15, 110, 86);
            else if (status == "pending") c = Color.FromArgb(180, 120, 0);
            else if (status == "confirmed") c = Color.FromArgb(20, 80, 160);
            else if (status == "approved") c = Color.FromArgb(20, 80, 160);
            else if (status == "rejected") c = Color.FromArgb(160, 0, 0);
            else c = Color.FromArgb(74, 14, 26);

            dgvActivity.Rows[rowIndex].Cells["colStatus"].Style.ForeColor = c;
        }

        
        private int Count(OleDbConnection conn, string sql)
        {
            using (var cmd = new OleDbCommand(sql, conn))
            {
                object r = cmd.ExecuteScalar();
                return (r == null || r == DBNull.Value) ? 0 : Convert.ToInt32(r);
            }
        }
    }
}