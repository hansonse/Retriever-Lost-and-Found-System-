using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _DRAFT__OOP_2_FINAL_PROJECT
{

    public class ClaimSlipRecordsForm : Form
    {
        private readonly List<ClaimRequest> _requests;
        private readonly IWin32Window       _owner;

        
        private Label        lblTitle;
        private Label        lblSub;
        private DataGridView dgv;
        private Button       btnViewSlip;
        private Button       btnClose;

        
        private const string ColReqID    = "colReqID";
        private const string ColItemName = "colItemName";
        private const string ColFullName = "colFullName";
        private const string ColStatus   = "colStatus";
        private const string ColDate     = "colDate";

        
        /// <param name="requests">List of requests to display.</param>
        /// <param name="owner">Parent window (for centering and slip dialog).</param>
        public ClaimSlipRecordsForm(List<ClaimRequest> requests, IWin32Window owner)
        {
            _requests = requests ?? throw new ArgumentNullException(nameof(requests));
            _owner    = owner;

            BuildUI();
            LoadRows();
        }

        
        private void BuildUI()
        {
            Text                = "Claim Slip Records";
            Size                = new Size(860, 540);
            MinimumSize         = new Size(680, 400);
            StartPosition       = FormStartPosition.CenterParent;
            FormBorderStyle     = FormBorderStyle.Sizable;
            BackColor           = Color.FromArgb(217, 175, 134);
            Font                = new Font("Letters for Learners", 10F);

            
            lblTitle = new Label
            {
                Text      = "Claim Slip Records",
                Font      = new Font("Kermit", 18F, FontStyle.Bold),
                AutoSize  = true,
                Location  = new Point(10, 8),
                ForeColor = Color.FromArgb(26, 58, 92)
            };

            lblSub = new Label
            {
                Text      = "Select a record and click View Slip to open it",
                Font      = new Font("Letters for Learners", 11F),
                AutoSize  = true,
                Location  = new Point(10, 44),
                ForeColor = Color.FromArgb(60, 50, 40)
            };

            
            dgv = new DataGridView
            {
                Location              = new Point(10, 76),
                Anchor                = AnchorStyles.Top | AnchorStyles.Bottom |
                                        AnchorStyles.Left | AnchorStyles.Right,
                Size                  = new Size(820, 380),
                SelectionMode         = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect           = false,
                ReadOnly              = true,
                AllowUserToAddRows    = false,
                RowHeadersVisible     = false,
                AutoSizeColumnsMode   = DataGridViewAutoSizeColumnsMode.Fill,
                BorderStyle           = BorderStyle.None,
                BackgroundColor       = Color.FromArgb(229, 152, 155),
                EnableHeadersVisualStyles = false
            };

            
            var headerStyle = new DataGridViewCellStyle
            {
                Alignment          = DataGridViewContentAlignment.MiddleCenter,
                BackColor          = Color.FromArgb(250, 240, 170),
                Font               = new Font("Letters for Learners", 12F, FontStyle.Bold),
                ForeColor          = Color.Maroon,
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = SystemColors.HighlightText
            };
            dgv.ColumnHeadersDefaultCellStyle    = headerStyle;
            dgv.ColumnHeadersHeightSizeMode      = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            
            var rowStyle = new DataGridViewCellStyle
            {
                Alignment          = DataGridViewContentAlignment.MiddleLeft,
                BackColor          = Color.FromArgb(229, 152, 155),
                Font               = new Font("Letters for Learners", 11F, FontStyle.Bold),
                ForeColor          = SystemColors.ControlText,
                SelectionBackColor = Color.FromArgb(255, 249, 196),
                SelectionForeColor = Color.Black
            };
            dgv.DefaultCellStyle = rowStyle;

            
            dgv.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(244, 199, 195)
            };

            
            dgv.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = ColReqID,    HeaderText = "Request ID",  ReadOnly = true },
                new DataGridViewTextBoxColumn { Name = ColItemName, HeaderText = "Item",        ReadOnly = true },
                new DataGridViewTextBoxColumn { Name = ColFullName, HeaderText = "Requester",   ReadOnly = true },
                new DataGridViewTextBoxColumn { Name = ColStatus,   HeaderText = "Status",      ReadOnly = true },
                new DataGridViewTextBoxColumn { Name = ColDate,     HeaderText = "Date Filed",  ReadOnly = true },
            });

            dgv.SelectionChanged += Dgv_SelectionChanged;
            dgv.CellDoubleClick  += Dgv_CellDoubleClick;

            
            btnViewSlip = new Button
            {
                Text      = "View Slip",
                Font      = new Font("Letters for Learners", 12F, FontStyle.Bold),
                Size      = new Size(130, 34),
                Anchor    = AnchorStyles.Bottom | AnchorStyles.Left,
                Location  = new Point(10, 464),
                BackColor = Color.FromArgb(26, 58, 92),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Enabled   = false
            };
            btnViewSlip.Click += BtnViewSlip_Click;

            btnClose = new Button
            {
                Text      = "Close",
                Font      = new Font("Letters for Learners", 12F, FontStyle.Bold),
                Size      = new Size(100, 34),
                Anchor    = AnchorStyles.Bottom | AnchorStyles.Right,
                Location  = new Point(730, 464),
                FlatStyle = FlatStyle.Flat
            };
            btnClose.Click += (s, e) => Close();

            Controls.AddRange(new Control[]
            {
                lblTitle, lblSub, dgv, btnViewSlip, btnClose
            });
        }

        
        private void LoadRows()
        {
            dgv.Rows.Clear();

            foreach (ClaimRequest r in _requests)
            {
                int idx = dgv.Rows.Add(
                    r.RequestID,
                    r.ItemName,
                    r.FullName,
                    r.Status,
                    r.DateFiled.ToString("MMM d, yyyy  h:mm tt")
                );

                
                Color bg = r.Status == "Approved" ? Color.PaleGreen
                         : r.Status == "Rejected" ? Color.LightCoral
                         : Color.Bisque;

                dgv.Rows[idx].DefaultCellStyle.BackColor = bg;

                
                Color fg = r.Status == "Approved" ? Color.DarkGreen
                         : r.Status == "Rejected" ? Color.Firebrick
                         : Color.DarkGoldenrod;

                dgv.Rows[idx].Cells[ColStatus].Style.ForeColor = fg;
                dgv.Rows[idx].Cells[ColStatus].Style.Font =
                    new Font("Letters for Learners", 11F, FontStyle.Bold);

                
                dgv.Rows[idx].Tag = r;
            }

            if (dgv.Rows.Count == 0)
                dgv.Rows.Add("—", "No records found.", "", "", "");
        }

        
        private ClaimRequest GetSelectedRequest()
        {
            return dgv.CurrentRow?.Tag as ClaimRequest;
        }

        
        private void Dgv_SelectionChanged(object sender, EventArgs e)
        {
            btnViewSlip.Enabled = GetSelectedRequest() != null;
        }

        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            OpenSlip();
        }

        private void BtnViewSlip_Click(object sender, EventArgs e)
        {
            OpenSlip();
        }

        private void OpenSlip()
        {
            ClaimRequest req = GetSelectedRequest();
            if (req == null) return;
            ClaimSlipForm.ShowSlip(req, this);
        }

        
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (btnClose == null) return;

            int bottom = ClientSize.Height - 46;
            btnViewSlip.Top = bottom;
            btnClose.Top    = bottom;
            btnClose.Left   = ClientSize.Width - btnClose.Width - 10;
            dgv.Width       = ClientSize.Width - 20;
            dgv.Height      = ClientSize.Height - 140;
        }
    }
}
