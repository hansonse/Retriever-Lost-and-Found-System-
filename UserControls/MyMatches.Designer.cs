namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    partial class MyMatches
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            splitMain      = new System.Windows.Forms.SplitContainer();
            lblTitle       = new System.Windows.Forms.Label();
            lblSub         = new System.Windows.Forms.Label();
            lblNoMatches   = new System.Windows.Forms.Label();
            dgvMatches     = new System.Windows.Forms.DataGridView();
            colLostName    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colFoundName   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMatchDate   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMatchStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panelDetail    = new System.Windows.Forms.Panel();
            btnCloseDetail = new System.Windows.Forms.Button();
            picFoundPhoto  = new System.Windows.Forms.PictureBox();
            grpLost        = new System.Windows.Forms.GroupBox();
            lblLostName     = new System.Windows.Forms.Label();
            lblLostDate     = new System.Windows.Forms.Label();
            lblLostLocation = new System.Windows.Forms.Label();
            lblLostCategory = new System.Windows.Forms.Label();
            grpFound        = new System.Windows.Forms.GroupBox();
            lblFoundName     = new System.Windows.Forms.Label();
            lblFoundDate     = new System.Windows.Forms.Label();
            lblFoundLocation = new System.Windows.Forms.Label();
            lblFoundDesc     = new System.Windows.Forms.Label();
            grpMatchInfo     = new System.Windows.Forms.GroupBox();
            lblMatchStatus   = new System.Windows.Forms.Label();
            lblMatchDate     = new System.Windows.Forms.Label();
            lblRemarks       = new System.Windows.Forms.Label();
            btnFileClaim     = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatches).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFoundPhoto).BeginInit();
            panelDetail.SuspendLayout();
            grpLost.SuspendLayout();
            grpFound.SuspendLayout();
            grpMatchInfo.SuspendLayout();
            SuspendLayout();

            // ── splitMain ─────────────────────────────────────────────────────
            splitMain.Dock              = System.Windows.Forms.DockStyle.Fill;
            splitMain.Orientation       = System.Windows.Forms.Orientation.Horizontal;
            splitMain.SplitterDistance = 260;
            splitMain.IsSplitterFixed   = true;
            splitMain.Size              = new System.Drawing.Size(1050, 670);
            splitMain.Location          = new System.Drawing.Point(0, 0);
            splitMain.Name              = "splitMain";
            splitMain.TabIndex          = 0;
            splitMain.Panel1.Controls.Add(lblTitle);
            splitMain.Panel1.Controls.Add(lblSub);
            splitMain.Panel1.Controls.Add(lblNoMatches);
            splitMain.Panel1.Controls.Add(dgvMatches);
            splitMain.Panel2.Controls.Add(panelDetail);

            // ── Header labels ─────────────────────────────────────────────────
            lblTitle.Text      = "🔗  My Matches";
            lblTitle.Font      = new System.Drawing.Font("Letters for Learners", 18F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(107, 21, 38);
            lblTitle.Location  = new System.Drawing.Point(16, 10);
            lblTitle.Size      = new System.Drawing.Size(400, 36);
            lblTitle.Name      = "lblTitle";

            lblSub.Text      = "Items matched to your lost reports — review and file a claim if it is yours";
            lblSub.Font      = new System.Drawing.Font("Letters for Learners", 10F);
            lblSub.ForeColor = System.Drawing.Color.DimGray;
            lblSub.Location  = new System.Drawing.Point(18, 48);
            lblSub.Size      = new System.Drawing.Size(700, 20);
            lblSub.Name      = "lblSub";

            // ── No matches label ──────────────────────────────────────────────
            lblNoMatches.Text      = "No matches found for your lost items yet.\nThe admin will notify you here once a match is made.";
            lblNoMatches.Font      = new System.Drawing.Font("Letters for Learners", 12F, System.Drawing.FontStyle.Italic);
            lblNoMatches.ForeColor = System.Drawing.Color.Gray;
            lblNoMatches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblNoMatches.Dock      = System.Windows.Forms.DockStyle.Fill;
            lblNoMatches.Name      = "lblNoMatches";
            lblNoMatches.Visible   = false;

            // ── dgvMatches ────────────────────────────────────────────────────
            dgvMatches.AllowUserToAddRows    = false;
            dgvMatches.AllowUserToDeleteRows = false;
            dgvMatches.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatches.BackgroundColor       = System.Drawing.Color.Bisque;
            dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatches.Columns.AddRange(colLostName, colFoundName, colMatchDate, colMatchStatus);
            dgvMatches.Location        = new System.Drawing.Point(12, 74);
            dgvMatches.MultiSelect     = false;
            dgvMatches.Name            = "dgvMatches";
            dgvMatches.ReadOnly        = true;
            dgvMatches.RowHeadersVisible = false;
            dgvMatches.SelectionMode   = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMatches.Size            = new System.Drawing.Size(1020, 190);
            dgvMatches.TabIndex        = 1;

            colLostName.Name       = "colLostName";
            colLostName.HeaderText = "Your Lost Item";
            colLostName.ReadOnly   = true;

            colFoundName.Name       = "colFoundName";
            colFoundName.HeaderText = "Matched Found Item";
            colFoundName.ReadOnly   = true;

            colMatchDate.Name       = "colMatchDate";
            colMatchDate.HeaderText = "Matched On";
            colMatchDate.ReadOnly   = true;

            colMatchStatus.Name       = "colMatchStatus";
            colMatchStatus.HeaderText = "Status";
            colMatchStatus.ReadOnly   = true;

            // ── panelDetail ───────────────────────────────────────────────────
            panelDetail.BackColor   = System.Drawing.Color.FromArgb(255, 245, 235);
            panelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelDetail.Dock        = System.Windows.Forms.DockStyle.Fill;
            panelDetail.Name        = "panelDetail";
            panelDetail.Padding     = new System.Windows.Forms.Padding(10);
            panelDetail.Controls.Add(btnCloseDetail);
            panelDetail.Controls.Add(picFoundPhoto);
            panelDetail.Controls.Add(grpLost);
            panelDetail.Controls.Add(grpFound);
            panelDetail.Controls.Add(grpMatchInfo);
            panelDetail.Controls.Add(btnFileClaim);
            panelDetail.Visible     = false;
            panelDetail.AutoScroll = true;

            // ── btnCloseDetail ────────────────────────────────────────────────
            btnCloseDetail.Text      = "✕ Close";
            btnCloseDetail.Font      = new System.Drawing.Font("Letters for Learners", 10F, System.Drawing.FontStyle.Bold);
            btnCloseDetail.ForeColor = System.Drawing.Color.White;
            btnCloseDetail.BackColor = System.Drawing.Color.FromArgb(107, 21, 38);
            btnCloseDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCloseDetail.Anchor    = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCloseDetail.Location  = new System.Drawing.Point(950, 10);
            btnCloseDetail.Size      = new System.Drawing.Size(88, 28);
            btnCloseDetail.Name      = "btnCloseDetail";
            btnCloseDetail.TabIndex  = 10;

            // ── picFoundPhoto ─────────────────────────────────────────────────
            picFoundPhoto.BackColor   = System.Drawing.Color.WhiteSmoke;
            picFoundPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picFoundPhoto.SizeMode    = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picFoundPhoto.Anchor      = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            picFoundPhoto.Location = new System.Drawing.Point(756, 10);
            picFoundPhoto.Size = new System.Drawing.Size(280, 120);
            picFoundPhoto.Name        = "picFoundPhoto";
            picFoundPhoto.TabStop     = false;

            // ── grpLost ───────────────────────────────────────────────────────
            grpLost.Text     = "Your Lost Item";
            grpLost.Font     = new System.Drawing.Font("Letters for Learners", 11F, System.Drawing.FontStyle.Bold);
            grpLost.Anchor   = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            grpLost.Location = new System.Drawing.Point(12, 10);
            grpLost.Size = new System.Drawing.Size(360, 120);
            grpLost.Name     = "grpLost";
            grpLost.Controls.Add(lblLostName);
            grpLost.Controls.Add(lblLostDate);
            grpLost.Controls.Add(lblLostLocation);
            grpLost.Controls.Add(lblLostCategory);

            SetDetailLabel(lblLostName, "Name: —", new System.Drawing.Point(8, 20), 340);
            SetDetailLabel(lblLostDate, "Date: —", new System.Drawing.Point(8, 44), 340);
            SetDetailLabel(lblLostLocation, "Location: —", new System.Drawing.Point(8, 66), 340);
            SetDetailLabel(lblLostCategory, "Category: —", new System.Drawing.Point(8, 88), 340);


            // ── grpFound ──────────────────────────────────────────────────────
            grpFound.Text     = "Matched Found Item";
            grpFound.Font     = new System.Drawing.Font("Letters for Learners", 11F, System.Drawing.FontStyle.Bold);
            grpFound.Anchor   = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            grpFound.Location = new System.Drawing.Point(384, 10);
            grpFound.Size = new System.Drawing.Size(360, 120);
            grpFound.Name     = "grpFound";
            grpFound.Controls.Add(lblFoundName);
            grpFound.Controls.Add(lblFoundDate);
            grpFound.Controls.Add(lblFoundLocation);
            grpFound.Controls.Add(lblFoundDesc);

            SetDetailLabel(lblFoundName, "Name: —", new System.Drawing.Point(8, 20), 340);
            SetDetailLabel(lblFoundDate, "Date: —", new System.Drawing.Point(8, 44), 340);
            SetDetailLabel(lblFoundLocation, "Location: —", new System.Drawing.Point(8, 66), 340);
            SetDetailLabel(lblFoundDesc, "Details: —", new System.Drawing.Point(8, 88), 340);

            // ── grpMatchInfo ──────────────────────────────────────────────────
            grpMatchInfo.Text     = "Match Info";
            grpMatchInfo.Font     = new System.Drawing.Font("Letters for Learners", 11F, System.Drawing.FontStyle.Bold);
            grpMatchInfo.Anchor   = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpMatchInfo.Location = new System.Drawing.Point(12, 140);
            grpMatchInfo.Size = new System.Drawing.Size(1026, 100);
            grpMatchInfo.Name     = "grpMatchInfo";
            grpMatchInfo.Controls.Add(lblMatchStatus);
            grpMatchInfo.Controls.Add(lblMatchDate);
            grpMatchInfo.Controls.Add(lblRemarks);

            SetDetailLabel(lblMatchStatus, "Status: —",      new System.Drawing.Point(8, 24), 500);
            SetDetailLabel(lblMatchDate,   "Matched on: —",  new System.Drawing.Point(8, 52), 500);
            SetDetailLabel(lblRemarks,     "Remarks: —",     new System.Drawing.Point(8, 78), 900);
            lblMatchStatus.Font      = new System.Drawing.Font("Letters for Learners", 11F, System.Drawing.FontStyle.Bold);
            lblMatchStatus.ForeColor = System.Drawing.Color.DarkGoldenrod;

            // ── btnFileClaim ──────────────────────────────────────────────────
            btnFileClaim.Text      = "✔  File Claim";
            btnFileClaim.Font      = new System.Drawing.Font("Letters for Learners", 11F, System.Drawing.FontStyle.Bold);
            btnFileClaim.ForeColor = System.Drawing.Color.White;
            btnFileClaim.BackColor = System.Drawing.Color.SeaGreen;
            btnFileClaim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFileClaim.Anchor    = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnFileClaim.Location = new System.Drawing.Point(808, 252);
            btnFileClaim.Size = new System.Drawing.Size(230, 38);
            btnFileClaim.Name      = "btnFileClaim";
            btnFileClaim.TabIndex  = 9;

            // ── MyMatches UserControl ─────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            BackColor           = System.Drawing.Color.FromArgb(217, 175, 134);
            Controls.Add(splitMain);
            DoubleBuffered = true;
            Name           = "MyMatches";
            Size           = new System.Drawing.Size(1050, 670);

            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMatches).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFoundPhoto).EndInit();
            panelDetail.ResumeLayout(false);
            grpLost.ResumeLayout(false);
            grpFound.ResumeLayout(false);
            grpMatchInfo.ResumeLayout(false);
            ResumeLayout(false);
        }

        // helper to avoid repetitive label setup
        private static void SetDetailLabel(System.Windows.Forms.Label lbl,
                                           string text,
                                           System.Drawing.Point loc,
                                           int width = 300)
        {
            lbl.Text      = text;
            lbl.Font      = new System.Drawing.Font("Letters for Learners", 10F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(50, 20, 10);
            lbl.Location  = loc;
            lbl.AutoSize  = false;
            lbl.Size      = new System.Drawing.Size(width, 22);
        }

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblNoMatches;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFoundName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatchDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatchStatus;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Button btnCloseDetail;
        private System.Windows.Forms.PictureBox picFoundPhoto;
        private System.Windows.Forms.GroupBox grpLost;
        private System.Windows.Forms.Label lblLostName;
        private System.Windows.Forms.Label lblLostDate;
        private System.Windows.Forms.Label lblLostLocation;
        private System.Windows.Forms.Label lblLostCategory;
        private System.Windows.Forms.GroupBox grpFound;
        private System.Windows.Forms.Label lblFoundName;
        private System.Windows.Forms.Label lblFoundDate;
        private System.Windows.Forms.Label lblFoundLocation;
        private System.Windows.Forms.Label lblFoundDesc;
        private System.Windows.Forms.GroupBox grpMatchInfo;
        private System.Windows.Forms.Label lblMatchStatus;
        private System.Windows.Forms.Label lblMatchDate;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Button btnFileClaim;
    }
}
