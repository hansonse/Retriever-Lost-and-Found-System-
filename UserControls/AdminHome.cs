using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    public partial class AdminHome : UserControl
    {
        private string _adminUsername = "";
        private Chart _categoryChart;
        private Chart _departmentChart;
        private ComboBox _cmbChartMode;
        private bool _chartsReady = false;

        public AdminHome()
        {
            InitializeComponent();
            this.HandleCreated += (s, e) => EnsureChartsCreated();
        }

        public void LoadAdmin(string adminUsername)
        {
            _adminUsername = adminUsername ?? "";
            SetupHeader();
            if (_chartsReady)
                LoadAnalytics();
        }

        public void LoadAnalytics()
        {
            LoadStatCards();
            if (_chartsReady)
            {
                LoadCategoryChart();
                LoadDepartmentChart();
            }
            LoadRecentActivity();
        }

        private void EnsureChartsCreated()
        {
            if (_chartsReady) return;
            SetupCharts();
        }

        private void SetupHeader()
        {
            string displayName = GetAdminName(_adminUsername);
            if (string.IsNullOrWhiteSpace(displayName)) displayName = _adminUsername;
            lblAdminTitle.Text = "Admin Dashboard";
            lblAdminSub.Text   = "Welcome back, " + displayName + " -- here is your system overview";
        }

        private string GetAdminName(string username)
        {
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(
                        "SELECT [adminName] FROM [Users] WHERE [username]=? AND [role]='admin'", conn))
                    {
                        cmd.Parameters.AddWithValue("?", username);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value) return result.ToString();
                    }
                }
            }
            catch { }
            return "";
        }

        private Chart BuildThemedChart(string s1Name, Color s1Color, string s2Name = null, Color? s2Color = null)
        {
            var chart = new Chart { Dock = DockStyle.Fill };

            var area = new ChartArea("main");
            area.BackColor                     = Color.FromArgb(217, 175, 134);
            area.BorderColor                   = Color.FromArgb(196, 154, 106);
            area.BorderWidth                   = 1;
            area.AxisX.LabelStyle.ForeColor    = Color.FromArgb(74, 14, 26);
            area.AxisX.LabelStyle.Font         = new Font("Letters for Learners", 12f, FontStyle.Bold);
            area.AxisX.LineColor               = Color.FromArgb(122, 78, 0);
            area.AxisX.MajorGrid.LineColor     = Color.FromArgb(196, 154, 106);
            area.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            area.AxisY.LabelStyle.ForeColor    = Color.FromArgb(74, 14, 26);
            area.AxisY.LabelStyle.Font         = new Font("Letters for Learners", 12f, FontStyle.Bold);
            area.AxisY.LineColor               = Color.FromArgb(122, 78, 0);
            area.AxisY.MajorGrid.LineColor     = Color.FromArgb(196, 154, 106);
            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            area.AxisY.Interval                = 1;
            chart.ChartAreas.Add(area);

            var legend = new Legend("main");
            legend.BackColor  = Color.FromArgb(217, 175, 134);
            legend.ForeColor  = Color.FromArgb(74, 14, 26);
            legend.Font       = new Font("Letters for Learners", 12f, FontStyle.Bold);
            legend.BorderColor = Color.FromArgb(196, 154, 106);
            chart.Legends.Add(legend);

            chart.BackColor           = Color.FromArgb(217, 175, 134);
            chart.BorderlineColor     = Color.FromArgb(196, 154, 106);
            chart.BorderlineDashStyle = ChartDashStyle.Solid;
            chart.BorderlineWidth     = 1;

            var s1 = new Series(s1Name);
            s1.ChartType      = SeriesChartType.Bar;
            s1.ChartArea      = "main";
            s1.Legend         = "main";
            s1.Color          = s1Color;
            s1.LabelForeColor = Color.FromArgb(74, 14, 26);
            chart.Series.Add(s1);

            if (s2Name != null && s2Color.HasValue)
            {
                var s2 = new Series(s2Name);
                s2.ChartType      = SeriesChartType.Bar;
                s2.ChartArea      = "main";
                s2.Legend         = "main";
                s2.Color          = s2Color.Value;
                s2.LabelForeColor = Color.FromArgb(74, 14, 26);
                chart.Series.Add(s2);
            }

            return chart;
        }

        private void SetupCharts()
        {
            if (_chartsReady) return;

                      _cmbChartMode = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font          = new Font("Letters for Learners", 10F, FontStyle.Bold),
                Width         = 320,
                BackColor     = Color.FromArgb(245, 235, 215),
                ForeColor     = Color.FromArgb(74, 14, 26)
            };
            _cmbChartMode.Items.Add("Items by Category (Lost vs Found)");
            _cmbChartMode.Items.Add("Items by Department (Lost vs Found)");
            _cmbChartMode.SelectedIndex = 0;
            _cmbChartMode.SelectedIndexChanged += (s, e) =>
            {
                if (_categoryChart  != null) _categoryChart.Visible  = (_cmbChartMode.SelectedIndex == 0);
                if (_departmentChart != null) _departmentChart.Visible = (_cmbChartMode.SelectedIndex == 1);
            };


            var comboPanel = new Panel
            {
                Dock      = DockStyle.Top,
                Height    = 30,
                BackColor = Color.FromArgb(217, 175, 134)
            };
            _cmbChartMode.Dock = DockStyle.Left;
            comboPanel.Controls.Add(_cmbChartMode);


            _categoryChart   = BuildThemedChart("Lost",  Color.FromArgb(180, 30, 30),
                                                "Found", Color.FromArgb(15, 110, 86));
            _categoryChart.Visible  = true;

            _departmentChart = BuildThemedChart(
     "Lost", Color.FromArgb(180, 30, 30),
     "Found", Color.FromArgb(15, 110, 86)
 );
            _departmentChart.Visible = false;
            _departmentChart.Dock    = DockStyle.Fill;

            panelChart.Controls.Add(_departmentChart);
            panelChart.Controls.Add(_categoryChart);
            panelChart.Controls.Add(comboPanel);   

            _chartsReady = true;

            LoadStatCards();
            LoadCategoryChart();
            LoadDepartmentChart();
            LoadRecentActivity();
        }


        private void LoadStatCards()
        {
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    lblTotalCount.Text    = ScalarCount(conn, "SELECT COUNT(*) FROM [Items] WHERE [status]<>'Archived'").ToString();
                    lblAdminLost.Text     = ScalarCount(conn, "SELECT COUNT(*) FROM [Items] WHERE [status]='Lost'").ToString();
                    lblAdminFound.Text    = ScalarCount(conn, "SELECT COUNT(*) FROM [Items] WHERE [status]='Found'").ToString();
                    lblArchivedCount.Text = ScalarCount(conn, "SELECT COUNT(*) FROM [Items] WHERE [status]='Archived'").ToString();
                    lblPendingCount.Text  = ScalarCount(conn, "SELECT COUNT(*) FROM [Matches] WHERE [status]='Pending'").ToString();
                    lblAdminApproved.Text = ScalarCount(conn, "SELECT COUNT(*) FROM [Matches] WHERE [status]='Confirmed'").ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stat cards:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadCategoryChart()
        {
            if (_categoryChart == null) return;
            try
            {
                var categories  = new List<string>();
                var lostValues  = new List<int>();
                var foundValues = new List<int>();

                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (OleDbCommand drCmd = new OleDbCommand(
                        "SELECT DISTINCT [classification] FROM [Items] WHERE [status]<>'Archived' ORDER BY [classification]",
                        conn))
                    using (OleDbDataReader dr = drCmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string cat = dr["classification"] != DBNull.Value ? dr["classification"].ToString() : "";
                            if (!string.IsNullOrWhiteSpace(cat)) categories.Add(cat);
                        }
                    }

                    if (categories.Count == 0) categories.Add("No Data");

                    foreach (string cat in categories)
                    {
                        lostValues.Add(cat == "No Data" ? 0 : ScalarCountParam(conn,
                            "SELECT COUNT(*) FROM [Items] WHERE [classification]=? AND [status]='Lost'", cat));
                        foundValues.Add(cat == "No Data" ? 0 : ScalarCountParam(conn,
                            "SELECT COUNT(*) FROM [Items] WHERE [classification]=? AND [status]='Found'", cat));
                    }
                }

                _categoryChart.Series["Lost"].Points.Clear();
                _categoryChart.Series["Found"].Points.Clear();

                for (int i = 0; i < categories.Count; i++)
                {
                    _categoryChart.Series["Lost"].Points.AddXY(categories[i], lostValues[i]);
                    _categoryChart.Series["Found"].Points.AddXY(categories[i], foundValues[i]);
                }

                int maxVal = 1;
                foreach (int v in lostValues)  if (v > maxVal) maxVal = v;
                foreach (int v in foundValues) if (v > maxVal) maxVal = v;
                _categoryChart.ChartAreas["main"].AxisX.Maximum = maxVal + 1;
                _categoryChart.ChartAreas["main"].AxisX.Interval = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Category chart error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadDepartmentChart()
        {
            if (_departmentChart == null) return;

            try
            {
                var departments = new List<string>();
                var lostValues = new List<int>();
                var foundValues = new List<int>();

                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();


                    using (OleDbCommand cmd = new OleDbCommand(
                        @"SELECT TOP 5 u.department,
                         COUNT(i.itemID) AS totalReports
                  FROM Users u
                  LEFT JOIN Items i ON i.reporter = u.username
                  WHERE u.department IS NOT NULL AND u.department <> ''
                  GROUP BY u.department
                  ORDER BY COUNT(i.itemID) DESC", conn))
                    using (OleDbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string dept = dr["department"].ToString();
                            if (!string.IsNullOrWhiteSpace(dept))
                                departments.Add(dept);
                        }
                    }

                    if (departments.Count == 0)
                        departments.Add("No Data");


                    foreach (string dept in departments)
                    {
                        if (dept == "No Data")
                        {
                            lostValues.Add(0);
                            foundValues.Add(0);
                        }
                        else
                        {
                            lostValues.Add(ScalarCountParam(conn,
                                "SELECT COUNT(*) FROM [Items] AS i " +
                                "INNER JOIN [Users] AS u ON i.reporter=u.username " +
                                "WHERE u.department=? AND i.status='Lost'", dept));

                            foundValues.Add(ScalarCountParam(conn,
                                "SELECT COUNT(*) FROM [Items] AS i " +
                                "INNER JOIN [Users] AS u ON i.reporter=u.username " +
                                "WHERE u.department=? AND i.status='Found'", dept));
                        }
                    }
                }


                _departmentChart.Series["Lost"].Points.Clear();
                _departmentChart.Series["Found"].Points.Clear();


                for (int i = 0; i < departments.Count; i++)
                {
                    _departmentChart.Series["Lost"].Points.AddXY(departments[i], lostValues[i]);
                    _departmentChart.Series["Found"].Points.AddXY(departments[i], foundValues[i]);
                }


                int maxVal = 1;
                foreach (int v in lostValues) if (v > maxVal) maxVal = v;
                foreach (int v in foundValues) if (v > maxVal) maxVal = v;

                _departmentChart.ChartAreas["main"].AxisX.Maximum = maxVal + 1;
                _departmentChart.ChartAreas["main"].AxisX.Interval = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Department chart error:\n" + ex.Message);
            }
        }


        private void LoadRecentActivity()
        {
            dgvAdminActivity.Rows.Clear();
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var rc1 = new OleDbCommand("SELECT TOP 5 [name],[reporter],[date],[status] FROM [Items] ORDER BY [date] DESC", conn))
                    using (OleDbDataReader r = rc1.ExecuteReader())
                    { while (r.Read()) { string n=S(r,"name"),rep=S(r,"reporter"),st=Cap(S(r,"status")),dt=FmtDate(r["date"]); int row=dgvAdminActivity.Rows.Add("Reported \""+n+"\" as "+st,rep,dt,st); Colorize(row,st.ToLower()); } }

                    using (var rc2 = new OleDbCommand("SELECT TOP 5 li.[name] AS lostName,m.[matchedBy],m.[matchDate],m.[status] FROM [Matches] AS m INNER JOIN [Items] AS li ON m.[lostItemID]=li.[itemID] ORDER BY m.[matchDate] DESC", conn))
                    using (OleDbDataReader r = rc2.ExecuteReader())
                    { while (r.Read()) { string n=S(r,"lostName"),mb=S(r,"matchedBy"),st=Cap(S(r,"status")),dt=FmtDate(r["matchDate"]); int row=dgvAdminActivity.Rows.Add("Match for \""+n+"\"",mb,dt,st); Colorize(row,st.ToLower()); } }

                    using (var rc3 = new OleDbCommand("SELECT TOP 3 [name],[reporter],[date] FROM [Items] WHERE [status]='Archived' ORDER BY [date] DESC", conn))
                    using (OleDbDataReader r = rc3.ExecuteReader())
                    { while (r.Read()) { string n=S(r,"name"),rep=S(r,"reporter"),dt=FmtDate(r["date"]); int row=dgvAdminActivity.Rows.Add("Archived \""+n+"\"",rep,dt,"Archived"); Colorize(row,"archived"); } }

                    using (var rc4 = new OleDbCommand("SELECT TOP 5 [itemName],[username],[dateFiled],[status] FROM [ClaimRequests] ORDER BY [dateFiled] DESC", conn))
                    using (OleDbDataReader r = rc4.ExecuteReader())
                    { while (r.Read()) { string n=S(r,"itemName"),u=S(r,"username"),st=Cap(S(r,"status")),dt=FmtDate(r["dateFiled"]); int row=dgvAdminActivity.Rows.Add("Claim for \""+n+"\"",u,dt,st); Colorize(row,st.ToLower()); } }
                }
                if (dgvAdminActivity.Rows.Count == 0)
                    dgvAdminActivity.Rows.Add("No recent activity","---","---","---");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading activity:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Colorize(int rowIndex, string statusLower)
        {
            Color fg;
            if      (statusLower == "lost")      fg = Color.FromArgb(180, 30, 30);
            else if (statusLower == "found")     fg = Color.FromArgb(15, 110, 86);
            else if (statusLower == "confirmed") fg = Color.FromArgb(20, 80, 160);
            else if (statusLower == "pending")   fg = Color.FromArgb(180, 120, 0);
            else if (statusLower == "approved")  fg = Color.FromArgb(20, 80, 160);
            else if (statusLower == "rejected")  fg = Color.FromArgb(160, 0, 0);
            else if (statusLower == "archived")  fg = Color.FromArgb(100, 100, 100);
            else                                 fg = Color.FromArgb(74, 14, 26);
            var cell = dgvAdminActivity.Rows[rowIndex].Cells["colAdminStatus"];
            cell.Style.ForeColor = fg;
            cell.Style.Font = new Font("Letters for Learners", 11f, FontStyle.Bold);
        }

        private string S(OleDbDataReader dr, string col) { try { return dr[col] != DBNull.Value ? dr[col].ToString() : ""; } catch { return ""; } }
        private int ScalarCount(OleDbConnection conn, string sql) { using (var c = new OleDbCommand(sql, conn)) { object r = c.ExecuteScalar(); return r == null || r == DBNull.Value ? 0 : Convert.ToInt32(r); } }
        private int ScalarCountParam(OleDbConnection conn, string sql, string param) { using (OleDbCommand cmd = new OleDbCommand(sql, conn)) { cmd.Parameters.AddWithValue("?", param); object r = cmd.ExecuteScalar(); return r == null || r == DBNull.Value ? 0 : Convert.ToInt32(r); } }
        private string FmtDate(object raw) { if (raw == null || raw == DBNull.Value) return "---"; DateTime dt; return DateTime.TryParse(raw.ToString(), out dt) ? dt.ToString("MMM dd, yyyy") : raw.ToString(); }
        private string Cap(string s) { if (string.IsNullOrEmpty(s)) return s; return char.ToUpper(s[0]) + s.Substring(1).ToLower(); }
    }
}
