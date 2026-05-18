namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    partial class Inventory
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvResults = new DataGridView();
            colItemID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colReporter = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            panelHeader = new Panel();
            btnBackToInventory = new Button();
            btnRefresh = new Button();
            lblSub = new Label();
            lblTitle = new Label();
            grpFilters = new GroupBox();
            chkMatched = new CheckBox();
            cmbFilterCategory = new ComboBox();
            btnViewArchive = new Button();
            lblCategory = new Label();
            chkSearchLocation = new CheckBox();
            chkSearchDesc = new CheckBox();
            chkSearchDate = new CheckBox();
            lblSearchBy = new Label();
            chkFound = new CheckBox();
            chkLost = new CheckBox();
            lblStatus = new Label();
            btnClearFilters = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panelDetail = new Panel();
            lblDetailDesc = new Label();
            lblDetailReporter = new Label();
            lblDetailStatus = new Label();
            lblDetailDate = new Label();
            lblDetailLocation = new Label();
            lblDetailCategory = new Label();
            lblDetailID = new Label();
            lblDetailTitle = new Label();
            picItemPhoto = new PictureBox();
            btnCloseDetail = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            panelHeader.SuspendLayout();
            grpFilters.SuspendLayout();
            panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picItemPhoto).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvResults, 0, 2);
            tableLayoutPanel1.Controls.Add(panelHeader, 0, 0);
            tableLayoutPanel1.Controls.Add(grpFilters, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(762, 508);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(244, 199, 195);
            dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.BackgroundColor = Color.FromArgb(217, 175, 134);
            dgvResults.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(250, 240, 170);
            dataGridViewCellStyle6.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Maroon;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Columns.AddRange(new DataGridViewColumn[] { colItemID, colName, colCategory, colLocation, colDate, colStatus, colReporter, colDescription });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(229, 152, 155);
            dataGridViewCellStyle7.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(255, 249, 196);
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvResults.DefaultCellStyle = dataGridViewCellStyle7;
            dgvResults.Dock = DockStyle.Fill;
            dgvResults.EnableHeadersVisualStyles = false;
            dgvResults.Location = new Point(3, 223);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(250, 240, 170);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvResults.RowHeadersVisible = false;
            dgvResults.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResults.Size = new Size(756, 282);
            dgvResults.TabIndex = 3;
            // 
            // colItemID
            // 
            colItemID.HeaderText = "Item ID";
            colItemID.Name = "colItemID";
            colItemID.ReadOnly = true;
            // 
            // colName
            // 
            colName.HeaderText = "Item Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colLocation
            // 
            colLocation.HeaderText = "Location";
            colLocation.Name = "colLocation";
            colLocation.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.HeaderText = "Date";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colReporter
            // 
            colReporter.HeaderText = "Reporter";
            colReporter.Name = "colReporter";
            colReporter.ReadOnly = true;
            // 
            // colDescription
            // 
            colDescription.HeaderText = "Description";
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(btnBackToInventory);
            panelHeader.Controls.Add(btnRefresh);
            panelHeader.Controls.Add(lblSub);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Fill;
            panelHeader.Location = new Point(3, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(756, 64);
            panelHeader.TabIndex = 0;
            // 
            // btnBackToInventory
            // 
            btnBackToInventory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBackToInventory.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToInventory.Location = new Point(448, 32);
            btnBackToInventory.Name = "btnBackToInventory";
            btnBackToInventory.Size = new Size(184, 31);
            btnBackToInventory.TabIndex = 5;
            btnBackToInventory.Text = "Back to Inventory";
            btnBackToInventory.UseVisualStyleBackColor = true;
            btnBackToInventory.Click += btnBackToInventory_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(626, 32);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(129, 31);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // lblSub
            // 
            lblSub.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSub.AutoSize = true;
            lblSub.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSub.Location = new Point(3, 39);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(229, 22);
            lblSub.TabIndex = 3;
            lblSub.Text = "Search and get item details";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Kermit", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(131, 39);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Inventory";
            // 
            // grpFilters
            // 
            grpFilters.Controls.Add(chkMatched);
            grpFilters.Controls.Add(cmbFilterCategory);
            grpFilters.Controls.Add(btnViewArchive);
            grpFilters.Controls.Add(lblCategory);
            grpFilters.Controls.Add(chkSearchLocation);
            grpFilters.Controls.Add(chkSearchDesc);
            grpFilters.Controls.Add(chkSearchDate);
            grpFilters.Controls.Add(lblSearchBy);
            grpFilters.Controls.Add(chkFound);
            grpFilters.Controls.Add(chkLost);
            grpFilters.Controls.Add(lblStatus);
            grpFilters.Controls.Add(btnClearFilters);
            grpFilters.Controls.Add(btnSearch);
            grpFilters.Controls.Add(txtSearch);
            grpFilters.Dock = DockStyle.Fill;
            grpFilters.FlatStyle = FlatStyle.Flat;
            grpFilters.Font = new Font("Kermit", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpFilters.Location = new Point(3, 73);
            grpFilters.Name = "grpFilters";
            grpFilters.Size = new Size(756, 144);
            grpFilters.TabIndex = 1;
            grpFilters.TabStop = false;
            grpFilters.Text = "Search and Filters";
            // 
            // chkMatched
            // 
            chkMatched.AutoSize = true;
            chkMatched.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold);
            chkMatched.Location = new Point(234, 56);
            chkMatched.Name = "chkMatched";
            chkMatched.Size = new Size(95, 26);
            chkMatched.TabIndex = 20;
            chkMatched.Text = "Matched";
            chkMatched.UseVisualStyleBackColor = true;
            // 
            // cmbFilterCategory
            // 
            cmbFilterCategory.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold);
            cmbFilterCategory.FormattingEnabled = true;
            cmbFilterCategory.Items.AddRange(new object[] { "All Categories", "", "Electronics", "", "Clothing", "", "Accessories", "", "Books / Documents", "", "Bag / Wallet", "", "Keys", "", "ID / Cards", "", "Other" });
            cmbFilterCategory.Location = new Point(6, 109);
            cmbFilterCategory.Name = "cmbFilterCategory";
            cmbFilterCategory.Size = new Size(272, 30);
            cmbFilterCategory.TabIndex = 19;
            cmbFilterCategory.SelectedIndexChanged += Filter_Changed;
            // 
            // btnViewArchive
            // 
            btnViewArchive.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnViewArchive.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewArchive.Location = new Point(459, 112);
            btnViewArchive.Name = "btnViewArchive";
            btnViewArchive.Size = new Size(159, 26);
            btnViewArchive.TabIndex = 5;
            btnViewArchive.Text = "View Archive";
            btnViewArchive.UseVisualStyleBackColor = true;
            btnViewArchive.Click += BtnViewArchive_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold);
            lblCategory.Location = new Point(6, 85);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(80, 22);
            lblCategory.TabIndex = 18;
            lblCategory.Text = "Category:";
            // 
            // chkSearchLocation
            // 
            chkSearchLocation.AutoSize = true;
            chkSearchLocation.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold);
            chkSearchLocation.Location = new Point(655, 55);
            chkSearchLocation.Name = "chkSearchLocation";
            chkSearchLocation.Size = new Size(94, 26);
            chkSearchLocation.TabIndex = 17;
            chkSearchLocation.Text = "Location";
            chkSearchLocation.UseVisualStyleBackColor = true;
            // 
            // chkSearchDesc
            // 
            chkSearchDesc.AutoSize = true;
            chkSearchDesc.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold);
            chkSearchDesc.Location = new Point(519, 55);
            chkSearchDesc.Name = "chkSearchDesc";
            chkSearchDesc.Size = new Size(118, 26);
            chkSearchDesc.TabIndex = 16;
            chkSearchDesc.Text = "Description";
            chkSearchDesc.UseVisualStyleBackColor = true;
            // 
            // chkSearchDate
            // 
            chkSearchDate.AutoSize = true;
            chkSearchDate.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold);
            chkSearchDate.Location = new Point(439, 55);
            chkSearchDate.Name = "chkSearchDate";
            chkSearchDate.Size = new Size(65, 26);
            chkSearchDate.TabIndex = 15;
            chkSearchDate.Text = "Date";
            chkSearchDate.UseVisualStyleBackColor = true;
            // 
            // lblSearchBy
            // 
            lblSearchBy.AutoSize = true;
            lblSearchBy.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold);
            lblSearchBy.Location = new Point(341, 57);
            lblSearchBy.Name = "lblSearchBy";
            lblSearchBy.Size = new Size(92, 22);
            lblSearchBy.TabIndex = 14;
            lblSearchBy.Text = "Search by:";
            // 
            // chkFound
            // 
            chkFound.AutoSize = true;
            chkFound.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold);
            chkFound.Location = new Point(149, 57);
            chkFound.Name = "chkFound";
            chkFound.Size = new Size(74, 26);
            chkFound.TabIndex = 13;
            chkFound.Text = "Found";
            chkFound.UseVisualStyleBackColor = true;
            // 
            // chkLost
            // 
            chkLost.AutoSize = true;
            chkLost.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold);
            chkLost.Location = new Point(80, 56);
            chkLost.Name = "chkLost";
            chkLost.Size = new Size(62, 26);
            chkLost.TabIndex = 12;
            chkLost.Text = "Lost";
            chkLost.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold);
            lblStatus.Location = new Point(11, 56);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(63, 22);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Status:";
            // 
            // btnClearFilters
            // 
            btnClearFilters.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClearFilters.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold);
            btnClearFilters.Location = new Point(624, 112);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(129, 26);
            btnClearFilters.TabIndex = 10;
            btnClearFilters.Text = "Clear Filter";
            btnClearFilters.UseVisualStyleBackColor = true;
            btnClearFilters.Click += BtnClearFilters_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold);
            btnSearch.Location = new Point(648, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(102, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold);
            txtSearch.Location = new Point(6, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by name...";
            txtSearch.Size = new Size(645, 29);
            txtSearch.TabIndex = 3;
            // 
            // panelDetail
            // 
            panelDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelDetail.AutoScroll = true;
            panelDetail.AutoScrollMinSize = new Size(0, 500);
            panelDetail.BackColor = Color.Bisque;
            panelDetail.BorderStyle = BorderStyle.FixedSingle;
            panelDetail.Controls.Add(lblDetailDesc);
            panelDetail.Controls.Add(lblDetailReporter);
            panelDetail.Controls.Add(lblDetailStatus);
            panelDetail.Controls.Add(lblDetailDate);
            panelDetail.Controls.Add(lblDetailLocation);
            panelDetail.Controls.Add(lblDetailCategory);
            panelDetail.Controls.Add(lblDetailID);
            panelDetail.Controls.Add(lblDetailTitle);
            panelDetail.Controls.Add(picItemPhoto);
            panelDetail.Controls.Add(btnCloseDetail);
            panelDetail.Location = new Point(440, 220);
            panelDetail.Name = "panelDetail";
            panelDetail.Size = new Size(318, 285);
            panelDetail.TabIndex = 4;
            panelDetail.Visible = false;
            // 
            // lblDetailDesc
            // 
            lblDetailDesc.AutoSize = true;
            lblDetailDesc.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblDetailDesc.Location = new Point(10, 457);
            lblDetailDesc.Name = "lblDetailDesc";
            lblDetailDesc.Size = new Size(16, 21);
            lblDetailDesc.TabIndex = 9;
            lblDetailDesc.Text = "-";
            // 
            // lblDetailReporter
            // 
            lblDetailReporter.AutoSize = true;
            lblDetailReporter.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblDetailReporter.Location = new Point(10, 415);
            lblDetailReporter.Name = "lblDetailReporter";
            lblDetailReporter.Size = new Size(21, 21);
            lblDetailReporter.TabIndex = 8;
            lblDetailReporter.Text = "0";
            // 
            // lblDetailStatus
            // 
            lblDetailStatus.AutoSize = true;
            lblDetailStatus.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblDetailStatus.Location = new Point(10, 373);
            lblDetailStatus.Name = "lblDetailStatus";
            lblDetailStatus.Size = new Size(16, 21);
            lblDetailStatus.TabIndex = 7;
            lblDetailStatus.Text = "-";
            // 
            // lblDetailDate
            // 
            lblDetailDate.AutoSize = true;
            lblDetailDate.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblDetailDate.Location = new Point(10, 336);
            lblDetailDate.Name = "lblDetailDate";
            lblDetailDate.Size = new Size(17, 21);
            lblDetailDate.TabIndex = 6;
            lblDetailDate.Text = "=";
            // 
            // lblDetailLocation
            // 
            lblDetailLocation.AutoSize = true;
            lblDetailLocation.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblDetailLocation.Location = new Point(10, 299);
            lblDetailLocation.Name = "lblDetailLocation";
            lblDetailLocation.Size = new Size(16, 21);
            lblDetailLocation.TabIndex = 5;
            lblDetailLocation.Text = "-";
            // 
            // lblDetailCategory
            // 
            lblDetailCategory.AutoSize = true;
            lblDetailCategory.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblDetailCategory.Location = new Point(10, 257);
            lblDetailCategory.Name = "lblDetailCategory";
            lblDetailCategory.Size = new Size(16, 21);
            lblDetailCategory.TabIndex = 4;
            lblDetailCategory.Text = "-";
            // 
            // lblDetailID
            // 
            lblDetailID.AutoSize = true;
            lblDetailID.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblDetailID.Location = new Point(10, 220);
            lblDetailID.Name = "lblDetailID";
            lblDetailID.Size = new Size(22, 21);
            lblDetailID.TabIndex = 3;
            lblDetailID.Text = "()";
            // 
            // lblDetailTitle
            // 
            lblDetailTitle.AutoSize = true;
            lblDetailTitle.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetailTitle.Location = new Point(102, 3);
            lblDetailTitle.Name = "lblDetailTitle";
            lblDetailTitle.Size = new Size(102, 22);
            lblDetailTitle.TabIndex = 2;
            lblDetailTitle.Text = "Item Detail";
            // 
            // picItemPhoto
            // 
            picItemPhoto.BackColor = Color.White;
            picItemPhoto.Location = new Point(26, 28);
            picItemPhoto.Name = "picItemPhoto";
            picItemPhoto.Size = new Size(261, 180);
            picItemPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picItemPhoto.TabIndex = 1;
            picItemPhoto.TabStop = false;
            // 
            // btnCloseDetail
            // 
            btnCloseDetail.Location = new Point(-1, -1);
            btnCloseDetail.Name = "btnCloseDetail";
            btnCloseDetail.Size = new Size(32, 23);
            btnCloseDetail.TabIndex = 0;
            btnCloseDetail.Text = "X";
            btnCloseDetail.UseVisualStyleBackColor = true;
            btnCloseDetail.Click += BtnCloseDetail_Click;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 175, 134);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelDetail);
            DoubleBuffered = true;
            Name = "Inventory";
            Size = new Size(762, 508);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            grpFilters.ResumeLayout(false);
            grpFilters.PerformLayout();
            panelDetail.ResumeLayout(false);
            panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picItemPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelHeader;
        private Button btnViewArchive;
        private Button btnRefresh;
        private Label lblSub;
        private Label lblTitle;
        private GroupBox grpFilters;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnClearFilters;
        private ComboBox cmbFilterCategory;
        private Label lblCategory;
        private CheckBox chkSearchLocation;
        private CheckBox chkSearchDesc;
        private CheckBox chkSearchDate;
        private Label lblSearchBy;
        private CheckBox chkFound;
        private CheckBox chkLost;
        private Label lblStatus;
        private Panel panelDetail;
        private Label lblDetailTitle;
        private PictureBox picItemPhoto;
        private Button btnCloseDetail;
        private Label lblDetailDesc;
        private Label lblDetailReporter;
        private Label lblDetailStatus;
        private Label lblDetailDate;
        private Label lblDetailLocation;
        private Label lblDetailCategory;
        private Label lblDetailID;
        private DataGridView dgvResults;
        private DataGridViewTextBoxColumn colItemID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colLocation;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colReporter;
        private DataGridViewTextBoxColumn colDescription;
        private Button btnBackToInventory;
        private CheckBox chkMatched;
    }
}