namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    partial class MatchReports
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitMain = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            dgvLostItems = new DataGridView();
            txtSearchLost = new TextBox();
            panelActions = new Panel();
            btnSelect = new Button();
            btnClear = new Button();
            groupBox2 = new GroupBox();
            dgvFoundItems = new DataGridView();
            colFoundID = new DataGridViewTextBoxColumn();
            colFoundName = new DataGridViewTextBoxColumn();
            colFoundCat = new DataGridViewTextBoxColumn();
            colFoundDate = new DataGridViewTextBoxColumn();
            txtSearchFound = new TextBox();
            tablePreview = new TableLayoutPanel();
            grpLostDetail = new GroupBox();
            picLost = new PictureBox();
            lblLostReporter = new Label();
            lblLostCategory = new Label();
            lblLostLocation = new Label();
            lblLostDate = new Label();
            lblLostName = new Label();
            panelConfirm = new Panel();
            btnConfirmMatch = new Button();
            txtRemarks = new TextBox();
            lblRemarks = new Label();
            grpFoundDetail = new GroupBox();
            picFound = new PictureBox();
            lblFoundReporter = new Label();
            lblFoundCategory = new Label();
            lblFoundLocation = new Label();
            lblFoundDate = new Label();
            lblFoundName = new Label();
            LostID = new DataGridViewTextBoxColumn();
            LostName = new DataGridViewTextBoxColumn();
            LostCat = new DataGridViewTextBoxColumn();
            LostDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLostItems).BeginInit();
            panelActions.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoundItems).BeginInit();
            tablePreview.SuspendLayout();
            grpLostDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLost).BeginInit();
            panelConfirm.SuspendLayout();
            grpFoundDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFound).BeginInit();
            SuspendLayout();
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 0);
            splitMain.Name = "splitMain";
            splitMain.Orientation = Orientation.Horizontal;
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(tablePreview);
            splitMain.Size = new Size(900, 650);
            splitMain.SplitterDistance = 330;
            splitMain.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(panelActions, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(900, 330);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvLostItems);
            groupBox1.Controls.Add(txtSearchLost);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Letters for Learners", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 304);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "📋  Lost Items";
            // 
            // dgvLostItems
            // 
            dgvLostItems.AllowUserToAddRows = false;
            dgvLostItems.AllowUserToDeleteRows = false;
            dgvLostItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLostItems.BackgroundColor = Color.Bisque;
            dgvLostItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLostItems.Columns.AddRange(new DataGridViewColumn[] { LostID, LostName, LostCat, LostDate });
            dgvLostItems.Dock = DockStyle.Fill;
            dgvLostItems.Location = new Point(3, 43);
            dgvLostItems.MultiSelect = false;
            dgvLostItems.Name = "dgvLostItems";
            dgvLostItems.ReadOnly = true;
            dgvLostItems.RowHeadersVisible = false;
            dgvLostItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLostItems.Size = new Size(357, 258);
            dgvLostItems.TabIndex = 1;
            // 
            // txtSearchLost
            // 
            txtSearchLost.Dock = DockStyle.Top;
            txtSearchLost.Font = new Font("Letters for Learners", 11F, FontStyle.Bold);
            txtSearchLost.Location = new Point(3, 20);
            txtSearchLost.Name = "txtSearchLost";
            txtSearchLost.PlaceholderText = "Search lost items...";
            txtSearchLost.Size = new Size(357, 23);
            txtSearchLost.TabIndex = 0;
            // 
            // panelActions
            // 
            panelActions.Controls.Add(btnSelect);
            panelActions.Controls.Add(btnClear);
            panelActions.Dock = DockStyle.Fill;
            panelActions.Location = new Point(382, 13);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(134, 304);
            panelActions.TabIndex = 1;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.SteelBlue;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Letters for Learners", 11F, FontStyle.Bold);
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(10, 115);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(110, 36);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "SELECT →";
            btnSelect.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(180, 80, 80);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Letters for Learners", 11F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(10, 161);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 36);
            btnClear.TabIndex = 1;
            btnClear.Text = "← CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvFoundItems);
            groupBox2.Controls.Add(txtSearchFound);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Letters for Learners", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(522, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(365, 304);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "📦  Found Items";
            // 
            // dgvFoundItems
            // 
            dgvFoundItems.AllowUserToAddRows = false;
            dgvFoundItems.AllowUserToDeleteRows = false;
            dgvFoundItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFoundItems.BackgroundColor = Color.Bisque;
            dgvFoundItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoundItems.Columns.AddRange(new DataGridViewColumn[] { colFoundID, colFoundName, colFoundCat, colFoundDate });
            dgvFoundItems.Dock = DockStyle.Fill;
            dgvFoundItems.Location = new Point(3, 43);
            dgvFoundItems.MultiSelect = false;
            dgvFoundItems.Name = "dgvFoundItems";
            dgvFoundItems.ReadOnly = true;
            dgvFoundItems.RowHeadersVisible = false;
            dgvFoundItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoundItems.Size = new Size(359, 258);
            dgvFoundItems.TabIndex = 1;
            // 
            // colFoundID
            // 
            colFoundID.Name = "colFoundID";
            colFoundID.ReadOnly = true;
            // 
            // colFoundName
            // 
            colFoundName.Name = "colFoundName";
            colFoundName.ReadOnly = true;
            // 
            // colFoundCat
            // 
            colFoundCat.Name = "colFoundCat";
            colFoundCat.ReadOnly = true;
            // 
            // colFoundDate
            // 
            colFoundDate.Name = "colFoundDate";
            colFoundDate.ReadOnly = true;
            // 
            // txtSearchFound
            // 
            txtSearchFound.Dock = DockStyle.Top;
            txtSearchFound.Font = new Font("Letters for Learners", 11F, FontStyle.Bold);
            txtSearchFound.Location = new Point(3, 20);
            txtSearchFound.Name = "txtSearchFound";
            txtSearchFound.PlaceholderText = "Search found items...";
            txtSearchFound.Size = new Size(359, 23);
            txtSearchFound.TabIndex = 0;
            // 
            // tablePreview
            // 
            tablePreview.ColumnCount = 3;
            tablePreview.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            tablePreview.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tablePreview.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            tablePreview.Controls.Add(grpLostDetail, 0, 0);
            tablePreview.Controls.Add(panelConfirm, 1, 0);
            tablePreview.Controls.Add(grpFoundDetail, 2, 0);
            tablePreview.Dock = DockStyle.Fill;
            tablePreview.Location = new Point(0, 0);
            tablePreview.Name = "tablePreview";
            tablePreview.Padding = new Padding(10);
            tablePreview.RowCount = 1;
            tablePreview.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablePreview.Size = new Size(900, 316);
            tablePreview.TabIndex = 0;
            // 
            // grpLostDetail
            // 
            grpLostDetail.Controls.Add(picLost);
            grpLostDetail.Controls.Add(lblLostReporter);
            grpLostDetail.Controls.Add(lblLostCategory);
            grpLostDetail.Controls.Add(lblLostLocation);
            grpLostDetail.Controls.Add(lblLostDate);
            grpLostDetail.Controls.Add(lblLostName);
            grpLostDetail.Dock = DockStyle.Fill;
            grpLostDetail.Font = new Font("Letters for Learners", 11F, FontStyle.Bold);
            grpLostDetail.Location = new Point(13, 13);
            grpLostDetail.Name = "grpLostDetail";
            grpLostDetail.Size = new Size(363, 290);
            grpLostDetail.TabIndex = 0;
            grpLostDetail.TabStop = false;
            grpLostDetail.Text = "Selected Lost Item";
            // 
            // picLost
            // 
            picLost.BackColor = Color.WhiteSmoke;
            picLost.BorderStyle = BorderStyle.FixedSingle;
            picLost.Location = new Point(8, 136);
            picLost.Name = "picLost";
            picLost.Size = new Size(160, 120);
            picLost.SizeMode = PictureBoxSizeMode.Zoom;
            picLost.TabIndex = 0;
            picLost.TabStop = false;
            // 
            // lblLostReporter
            // 
            lblLostReporter.AutoSize = true;
            lblLostReporter.Font = new Font("Letters for Learners", 10F);
            lblLostReporter.Location = new Point(8, 110);
            lblLostReporter.Name = "lblLostReporter";
            lblLostReporter.Size = new Size(59, 16);
            lblLostReporter.TabIndex = 1;
            lblLostReporter.Text = "Reporter: —";
            // 
            // lblLostCategory
            // 
            lblLostCategory.AutoSize = true;
            lblLostCategory.Font = new Font("Letters for Learners", 10F);
            lblLostCategory.Location = new Point(8, 88);
            lblLostCategory.Name = "lblLostCategory";
            lblLostCategory.Size = new Size(61, 16);
            lblLostCategory.TabIndex = 2;
            lblLostCategory.Text = "Category: —";
            // 
            // lblLostLocation
            // 
            lblLostLocation.AutoSize = true;
            lblLostLocation.Font = new Font("Letters for Learners", 10F);
            lblLostLocation.Location = new Point(8, 66);
            lblLostLocation.Name = "lblLostLocation";
            lblLostLocation.Size = new Size(59, 16);
            lblLostLocation.TabIndex = 3;
            lblLostLocation.Text = "Location: —";
            // 
            // lblLostDate
            // 
            lblLostDate.AutoSize = true;
            lblLostDate.Font = new Font("Letters for Learners", 10F);
            lblLostDate.Location = new Point(8, 44);
            lblLostDate.Name = "lblLostDate";
            lblLostDate.Size = new Size(42, 16);
            lblLostDate.TabIndex = 4;
            lblLostDate.Text = "Date: —";
            // 
            // lblLostName
            // 
            lblLostName.AutoSize = true;
            lblLostName.Font = new Font("Letters for Learners", 10F);
            lblLostName.Location = new Point(8, 22);
            lblLostName.Name = "lblLostName";
            lblLostName.Size = new Size(46, 16);
            lblLostName.TabIndex = 5;
            lblLostName.Text = "Name: —";
            // 
            // panelConfirm
            // 
            panelConfirm.Controls.Add(btnConfirmMatch);
            panelConfirm.Controls.Add(txtRemarks);
            panelConfirm.Controls.Add(lblRemarks);
            panelConfirm.Dock = DockStyle.Fill;
            panelConfirm.Location = new Point(382, 13);
            panelConfirm.Name = "panelConfirm";
            panelConfirm.Size = new Size(134, 290);
            panelConfirm.TabIndex = 1;
            // 
            // btnConfirmMatch
            // 
            btnConfirmMatch.BackColor = Color.SeaGreen;
            btnConfirmMatch.FlatStyle = FlatStyle.Flat;
            btnConfirmMatch.Font = new Font("Letters for Learners", 10F, FontStyle.Bold);
            btnConfirmMatch.ForeColor = Color.White;
            btnConfirmMatch.Location = new Point(6, 170);
            btnConfirmMatch.Name = "btnConfirmMatch";
            btnConfirmMatch.Size = new Size(118, 40);
            btnConfirmMatch.TabIndex = 1;
            btnConfirmMatch.Text = "✔ Confirm Match";
            btnConfirmMatch.UseVisualStyleBackColor = false;
            // 
            // txtRemarks
            // 
            txtRemarks.Font = new Font("Letters for Learners", 10F);
            txtRemarks.Location = new Point(6, 100);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.PlaceholderText = "Optional remarks...";
            txtRemarks.Size = new Size(118, 60);
            txtRemarks.TabIndex = 0;
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Letters for Learners", 10F, FontStyle.Bold);
            lblRemarks.Location = new Point(6, 80);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(57, 16);
            lblRemarks.TabIndex = 2;
            lblRemarks.Text = "Remarks:";
            // 
            // grpFoundDetail
            // 
            grpFoundDetail.Controls.Add(picFound);
            grpFoundDetail.Controls.Add(lblFoundReporter);
            grpFoundDetail.Controls.Add(lblFoundCategory);
            grpFoundDetail.Controls.Add(lblFoundLocation);
            grpFoundDetail.Controls.Add(lblFoundDate);
            grpFoundDetail.Controls.Add(lblFoundName);
            grpFoundDetail.Dock = DockStyle.Fill;
            grpFoundDetail.Font = new Font("Letters for Learners", 11F, FontStyle.Bold);
            grpFoundDetail.Location = new Point(522, 13);
            grpFoundDetail.Name = "grpFoundDetail";
            grpFoundDetail.Size = new Size(365, 290);
            grpFoundDetail.TabIndex = 2;
            grpFoundDetail.TabStop = false;
            grpFoundDetail.Text = "Selected Found Item";
            // 
            // picFound
            // 
            picFound.BackColor = Color.WhiteSmoke;
            picFound.BorderStyle = BorderStyle.FixedSingle;
            picFound.Location = new Point(8, 136);
            picFound.Name = "picFound";
            picFound.Size = new Size(160, 120);
            picFound.SizeMode = PictureBoxSizeMode.Zoom;
            picFound.TabIndex = 0;
            picFound.TabStop = false;
            // 
            // lblFoundReporter
            // 
            lblFoundReporter.AutoSize = true;
            lblFoundReporter.Font = new Font("Letters for Learners", 10F);
            lblFoundReporter.Location = new Point(8, 110);
            lblFoundReporter.Name = "lblFoundReporter";
            lblFoundReporter.Size = new Size(59, 16);
            lblFoundReporter.TabIndex = 1;
            lblFoundReporter.Text = "Reporter: —";
            // 
            // lblFoundCategory
            // 
            lblFoundCategory.AutoSize = true;
            lblFoundCategory.Font = new Font("Letters for Learners", 10F);
            lblFoundCategory.Location = new Point(8, 88);
            lblFoundCategory.Name = "lblFoundCategory";
            lblFoundCategory.Size = new Size(61, 16);
            lblFoundCategory.TabIndex = 2;
            lblFoundCategory.Text = "Category: —";
            // 
            // lblFoundLocation
            // 
            lblFoundLocation.AutoSize = true;
            lblFoundLocation.Font = new Font("Letters for Learners", 10F);
            lblFoundLocation.Location = new Point(8, 66);
            lblFoundLocation.Name = "lblFoundLocation";
            lblFoundLocation.Size = new Size(59, 16);
            lblFoundLocation.TabIndex = 3;
            lblFoundLocation.Text = "Location: —";
            // 
            // lblFoundDate
            // 
            lblFoundDate.AutoSize = true;
            lblFoundDate.Font = new Font("Letters for Learners", 10F);
            lblFoundDate.Location = new Point(8, 44);
            lblFoundDate.Name = "lblFoundDate";
            lblFoundDate.Size = new Size(42, 16);
            lblFoundDate.TabIndex = 4;
            lblFoundDate.Text = "Date: —";
            // 
            // lblFoundName
            // 
            lblFoundName.AutoSize = true;
            lblFoundName.Font = new Font("Letters for Learners", 10F);
            lblFoundName.Location = new Point(8, 22);
            lblFoundName.Name = "lblFoundName";
            lblFoundName.Size = new Size(46, 16);
            lblFoundName.TabIndex = 5;
            lblFoundName.Text = "Name: —";
            // 
            // LostID
            // 
            LostID.HeaderText = "colLostID";
            LostID.Name = "LostID";
            LostID.ReadOnly = true;
            // 
            // LostName
            // 
            LostName.HeaderText = "colLostName";
            LostName.Name = "LostName";
            LostName.ReadOnly = true;
            // 
            // LostCat
            // 
            LostCat.HeaderText = "colLostCat";
            LostCat.Name = "LostCat";
            LostCat.ReadOnly = true;
            // 
            // LostDate
            // 
            LostDate.HeaderText = "colLostDate";
            LostDate.Name = "LostDate";
            LostDate.ReadOnly = true;
            // 
            // MatchReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 175, 134);
            Controls.Add(splitMain);
            DoubleBuffered = true;
            Name = "MatchReports";
            Size = new Size(900, 650);
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLostItems).EndInit();
            panelActions.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoundItems).EndInit();
            tablePreview.ResumeLayout(false);
            grpLostDetail.ResumeLayout(false);
            grpLostDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLost).EndInit();
            panelConfirm.ResumeLayout(false);
            panelConfirm.PerformLayout();
            grpFoundDetail.ResumeLayout(false);
            grpFoundDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFound).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitMain;
        private TableLayoutPanel tableLayoutPanel1;

        // ── TOP LEFT: Lost Items ──────────────────────────────
        private GroupBox groupBox1;
        private TextBox txtSearchLost;
        private DataGridView dgvLostItems;

        // ── TOP CENTRE: Action buttons ────────────────────────
        private Panel panelActions;
        private Button btnSelect;
        private Button btnClear;

        // ── TOP RIGHT: Found Items ────────────────────────────
        private GroupBox groupBox2;
        private TextBox txtSearchFound;
        private DataGridView dgvFoundItems;

        // ── BOTTOM: Match Preview (Panel2) ────────────────────
        private TableLayoutPanel tablePreview;

        private GroupBox grpLostDetail;
        private Label lblLostName;
        private Label lblLostDate;
        private Label lblLostLocation;
        private Label lblLostCategory;
        private Label lblLostReporter;
        private PictureBox picLost;

        private GroupBox grpFoundDetail;
        private Label lblFoundName;
        private Label lblFoundDate;
        private Label lblFoundLocation;
        private Label lblFoundCategory;
        private Label lblFoundReporter;
        private PictureBox picFound;

        private Panel panelConfirm;
        private Label lblRemarks;
        private TextBox txtRemarks;
        private Button btnConfirmMatch;
        private DataGridViewTextBoxColumn LostID;
        private DataGridViewTextBoxColumn LostName;
        private DataGridViewTextBoxColumn LostCat;
        private DataGridViewTextBoxColumn LostDate;
        private DataGridViewTextBoxColumn colFoundID;
        private DataGridViewTextBoxColumn colFoundName;
        private DataGridViewTextBoxColumn colFoundCat;
        private DataGridViewTextBoxColumn colFoundDate;
    }
}
