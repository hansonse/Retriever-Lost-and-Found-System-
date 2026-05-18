using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using _DRAFT__OOP_2_FINAL_PROJECT;

namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    public partial class ManageRequests : UserControl
    {
        private readonly ClaimRequestManager _manager = new ClaimRequestManager();
        private string _selectedRequestID = "";

        public ManageRequests()
        {
            InitializeComponent();
            if (DesignMode) return;

            SetupGrid();
            WireEvents();
            LoadRequests();
        }

        
        private void SetupGrid()
        {
            dataGridView1.AutoGenerateColumns = false; 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = null;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
        }

        
        private void WireEvents()
        {
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            button1.Click += BtnApprove_Click;
            button2.Click += BtnReject_Click;
            btnAllClaimSlips.Click += BtnAllClaimSlips_Click;
        }

        
        private void LoadRequests()
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                _selectedRequestID = "";
                UpdateButtonState();

                List<ClaimRequest> requests = _manager.GetAllRequests();

                foreach (ClaimRequest r in requests)
                {
                    if (r == null) continue;

                    int rowIndex = dataGridView1.Rows.Add(
                        r.RequestID ?? "",
                        r.ItemID?.ToString() ?? "",
                        r.ItemName ?? "",
                        r.FullName ?? "",
                        "View Slip",
                        r.Status ?? ""
                    );

                    string status = r.Status ?? "";

                    Color bg =
                        status == "Approved" ? Color.PaleGreen :
                        status == "Rejected" ? Color.LightCoral :
                        Color.Bisque;

                    dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = bg;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading requests:\n" + ex.Message);
            }
        }

        
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null ||
                    dataGridView1.CurrentRow.Index < 0)
                {
                    _selectedRequestID = "";
                    UpdateButtonState();
                    return;
                }

                var val = dataGridView1.CurrentRow.Cells[0].Value;
                _selectedRequestID = val == null ? "" : val.ToString();

                UpdateButtonState();
            }
            catch
            {
                _selectedRequestID = "";
                UpdateButtonState();
            }
        }

        
        private void BtnApprove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedRequestID))
            {
                MessageBox.Show("Please select a request first.");
                return;
            }

            string remarks = textBox1.Text.Trim();

            if (MessageBox.Show(
                $"Approve request {_selectedRequestID}?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            ApplyDecision("Approved", remarks);
        }

        
        private void BtnReject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedRequestID))
            {
                MessageBox.Show("Please select a request first.");
                return;
            }

            string remarks = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(remarks))
            {
                MessageBox.Show("Remarks required for rejection.");
                return;
            }

            if (MessageBox.Show(
                $"Reject request {_selectedRequestID}?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            ApplyDecision("Rejected", remarks);
        }

        
        private void ApplyDecision(string status, string remarks)
        {
            try
            {
                bool ok = _manager.UpdateRequestStatus(
                    _selectedRequestID, status, remarks, out string err);

                if (!ok) { MessageBox.Show(err); return; }

                
                ClaimRequest req = _manager.GetRequestByID(_selectedRequestID);

                if (status == "Approved" && req != null)
                    MarkItemReturned(_selectedRequestID);

                
                if (status == "Rejected" && req != null)
                {
                    _manager.ResetMatchForRejectedClaim(req.ItemID);
                    MessageBox.Show(
                        $"Claim rejected.\nReason: {remarks}\n\n" +
                        "The match has been reset — the user may re-file.",
                        "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (req != null)
                    ClaimSlipForm.ShowSlip(req, this);

                textBox1.Clear();
                LoadRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing decision:\n" + ex.Message);
            }
        }

        
        private void MarkItemReturned(string requestID)
        {
            try
            {
                ClaimRequest req = _manager.GetRequestByID(requestID);
                if (req == null) return;

                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    const string q =
                        "UPDATE [Items] SET [status] = 'Returned' WHERE [itemID] = ?";

                    using (var cmd = new OleDbCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("?", req.ItemID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Warning: could not update item.\n" + ex.Message);
            }
        }

        
        private void BtnAllClaimSlips_Click(object sender, EventArgs e)
        {
            List<ClaimRequest> all = _manager.GetAllRequests();

            if (all.Count == 0)
            {
                MessageBox.Show("No records found.");
                return;
            }

            using (var picker = new ClaimSlipRecordsForm(all, this))
                picker.ShowDialog(this);
        }

        
        private void UpdateButtonState()
        {
            bool has = !string.IsNullOrEmpty(_selectedRequestID);

            button1.Enabled = has;
            button2.Enabled = has;

            button1.BackColor = has ? Color.PaleGreen : Color.Silver;
            button2.BackColor = has ? Color.IndianRed : Color.Silver;
        }
    }
}