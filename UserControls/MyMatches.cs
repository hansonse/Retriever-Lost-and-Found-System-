using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    public partial class MyMatches : UserControl
    {
        private readonly string _username;
        private readonly ClaimRequestManager _claimMgr = new ClaimRequestManager();
        private DataTable _matchTable = new DataTable();

        public MyMatches(string username)
        {
            InitializeComponent();
            _username = username ?? "";
            if (DesignMode) return;
            WireEvents();
        }

        public void LoadMatches()
        {
            _matchTable = GetMyMatches();
            PopulateGrid();
            HideDetail();
        }

        private void WireEvents()
        {
            dgvMatches.CellClick += DgvMatches_CellClick;
            btnFileClaim.Click += BtnFileClaim_Click;
            btnCloseDetail.Click += (s, e) => HideDetail();
        }

        private DataTable GetMyMatches()
        {
            DataTable dt = new DataTable();
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql =
                        "SELECT m.[matchID], " +
                        "li.[itemID] AS lostItemID, li.[name] AS lostName, li.[location] AS lostLocation, li.[date] AS lostDate, li.[classification] AS lostCategory, " +
                        "fi.[itemID] AS foundItemID, fi.[name] AS foundName, fi.[location] AS foundLocation, fi.[date] AS foundDate, fi.[description] AS foundDesc, fi.[imagePath] AS foundImage, " +
                        "m.[matchDate], m.[remarks], m.[status] " +
                        "FROM ([Matches] AS m " +
                        "INNER JOIN [Items] AS li ON m.[lostItemID] = li.[itemID]) " +
                        "INNER JOIN [Items] AS fi ON m.[foundItemID] = fi.[itemID] " +
                        "WHERE li.[reporter] = ? " +
                        "ORDER BY m.[matchDate] DESC";
                    using (OleDbDataAdapter da = new OleDbDataAdapter(sql, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("?", _username);
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading matches:\n" + ex.Message); }
            return dt;
        }

        private void PopulateGrid()
        {
            dgvMatches.Rows.Clear();
            if (_matchTable.Rows.Count == 0)
            {
                lblNoMatches.Visible = true;
                dgvMatches.Visible = false;
                return;
            }
            lblNoMatches.Visible = false;
            dgvMatches.Visible = true;

            foreach (DataRow row in _matchTable.Rows)
            {
                string status = row["status"].ToString();
                string matchDate = row["matchDate"] != DBNull.Value
                    ? Convert.ToDateTime(row["matchDate"]).ToString("MMM dd, yyyy") : "—";

                int idx = dgvMatches.Rows.Add(
                    row["lostName"].ToString(),
                    row["foundName"].ToString(),
                    matchDate,
                    status);

                Color fg = status == "Confirmed" ? Color.DarkGreen
                         : status == "Rejected" ? Color.Crimson
                         : Color.DarkGoldenrod;

                dgvMatches.Rows[idx].Cells["colMatchStatus"].Style.ForeColor = fg;
                dgvMatches.Rows[idx].Cells["colMatchStatus"].Style.Font =
                    new Font("Segoe UI", 10F, FontStyle.Bold);
                dgvMatches.Rows[idx].Tag = row;
            }
        }

        private void DgvMatches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataRow row = dgvMatches.Rows[e.RowIndex].Tag as DataRow;
            if (row == null) return;
            ShowDetail(row);
        }

        private void ShowDetail(DataRow row)
        {
            lblLostName.Text = row["lostName"].ToString();
            lblLostDate.Text = FormatDate(row["lostDate"]);
            lblLostLocation.Text = row["lostLocation"].ToString();
            lblLostCategory.Text = row["lostCategory"].ToString();

            lblFoundName.Text = row["foundName"].ToString();
            lblFoundDate.Text = FormatDate(row["foundDate"]);
            lblFoundLocation.Text = row["foundLocation"].ToString();
            lblFoundDesc.Text = row["foundDesc"].ToString();

            string status = row["status"].ToString();
            lblMatchStatus.Text = status;
            lblMatchDate.Text = FormatDate(row["matchDate"]);
            lblRemarks.Text = row["remarks"].ToString();

            lblMatchStatus.ForeColor = status == "Confirmed" ? Color.DarkGreen
                                     : status == "Rejected" ? Color.Crimson
                                     : Color.DarkGoldenrod;

            LoadImage(row);

            btnFileClaim.Enabled = status == "Pending";
            btnFileClaim.BackColor = btnFileClaim.Enabled ? Color.SeaGreen : Color.Gray;
            btnFileClaim.Tag = row;

            
            if (status == "Rejected")
            {
                string adminRemark = row["remarks"]?.ToString() ?? "";
                string rejMsg = string.IsNullOrWhiteSpace(adminRemark)
                    ? "Your claim was rejected. You may re-file once the match is reset."
                    : $"Rejected — {adminRemark}\n\nYou may contact the office for more info.";
                MessageBox.Show(rejMsg, "Claim Rejected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            panelDetail.Visible = true;
            panelDetail.BringToFront();
        }

        private void LoadImage(DataRow row)
        {
            string category = row["lostCategory"]?.ToString() ?? "";
            bool restricted =
                category.Equals("ID / Cards", StringComparison.OrdinalIgnoreCase) ||
                category.Equals("Bag / Wallet", StringComparison.OrdinalIgnoreCase);

            
            if (picFoundPhoto.Image != null)
            {
                var old = picFoundPhoto.Image;
                picFoundPhoto.Image = null;
                old.Dispose();
            }

            if (restricted) { DrawPlaceholder("Restricted"); return; }

            string path = row["foundImage"] != DBNull.Value ? row["foundImage"].ToString() : "";
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                try
                {
                 
                    using (var tmp = Image.FromFile(path))
                        picFoundPhoto.Image = new Bitmap(tmp);
                }
                catch { DrawPlaceholder("No Image"); }
            }
            else { DrawPlaceholder("No Image"); }
        }

        private void DrawPlaceholder(string msg)
        {
            int w = picFoundPhoto.Width  > 0 ? picFoundPhoto.Width  : 150;
            int h = picFoundPhoto.Height > 0 ? picFoundPhoto.Height : 150;
            Bitmap bmp = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.FromArgb(220, 210, 195));
                using (Font f = new Font("Segoe UI", 10))
                    g.DrawString(msg, f, Brushes.Gray, 10, 10);
            }
            picFoundPhoto.Image = bmp;
        }

        private void HideDetail()
        {
            panelDetail.Visible = false;
            if (picFoundPhoto.Image != null)
            {
                var old = picFoundPhoto.Image;
                picFoundPhoto.Image = null;
                old.Dispose();
            }
            btnFileClaim.Tag = null;
        }

        private void BtnFileClaim_Click(object sender, EventArgs e)
        {
            DataRow row = btnFileClaim.Tag as DataRow;
            if (row == null) return;

            string foundItemID   = row["foundItemID"].ToString();
            string foundItemName = row["foundName"].ToString();
            string category      = row["lostCategory"].ToString();
            string location      = row["foundLocation"].ToString();

            DateTime dateFound = row["foundDate"] != DBNull.Value
                ? Convert.ToDateTime(row["foundDate"]) : DateTime.Today;

            
            string userMessage = "";
            using (Form msgForm = new Form())
            {
                msgForm.Text = "Claim Message";
                msgForm.Size = new System.Drawing.Size(420, 230);
                msgForm.StartPosition = FormStartPosition.CenterParent;
                msgForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                msgForm.MaximizeBox = false;

                var lbl = new Label
                {
                    Text = "Add a message to your claim (optional):\ne.g. describe why this item is yours",
                    Location = new System.Drawing.Point(12, 12),
                    Size = new System.Drawing.Size(380, 36),
                    Font = new System.Drawing.Font("Segoe UI", 9F)
                };
                var txt = new TextBox
                {
                    Location = new System.Drawing.Point(12, 54),
                    Size = new System.Drawing.Size(380, 80),
                    Multiline = true,
                    ScrollBars = ScrollBars.Vertical,
                    Font = new System.Drawing.Font("Segoe UI", 9F)
                };
                var btnOk = new Button
                {
                    Text = "Submit Claim",
                    Location = new System.Drawing.Point(200, 148),
                    Size = new System.Drawing.Size(110, 32),
                    DialogResult = DialogResult.OK
                };
                var btnCancel = new Button
                {
                    Text = "Cancel",
                    Location = new System.Drawing.Point(320, 148),
                    Size = new System.Drawing.Size(72, 32),
                    DialogResult = DialogResult.Cancel
                };
                msgForm.Controls.AddRange(new Control[] { lbl, txt, btnOk, btnCancel });
                msgForm.AcceptButton = btnOk;
                msgForm.CancelButton = btnCancel;

                if (msgForm.ShowDialog(this) != DialogResult.OK) return;
                userMessage = txt.Text.Trim();
            }

            string fullName  = ResolveField("fullName",  _username);
            string studentID = ResolveField("studentID", _username);

            string requestID = _claimMgr.SubmitRequest(
                foundItemID, foundItemName, category, location,
                dateFound, _username, fullName, studentID,
                userMessage,
                out string err);

            if (!string.IsNullOrEmpty(err)) { MessageBox.Show(err); return; }

            ClaimRequest req = new ClaimRequest(
                requestID, foundItemID, foundItemName, category, location,
                dateFound, _username, fullName, studentID,
                DateTime.Now, "Pending", userMessage);

            ClaimSlipForm.ShowSlip(req, this);
            LoadMatches();
        }

        private string ResolveField(string field, string username)
        {
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(
                        $"SELECT [{field}] FROM [Users] WHERE [username] = ?", conn))
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

        private string FormatDate(object val)
        {
            if (val == null || val == DBNull.Value) return "—";
            if (DateTime.TryParse(val.ToString(), out DateTime dt))
                return dt.ToString("MMM dd, yyyy");
            return "—";
        }
    }
}
