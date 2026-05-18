namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    partial class ReportLost
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            panelReportLost = new TableLayoutPanel();
            panel5 = new Panel();
            lblPhotoStatus = new Label();
            btnClearPhoto = new Button();
            btnCamera = new Button();
            label13 = new Label();
            btnBrowse = new Button();
            picPreview = new PictureBox();
            label12 = new Label();
            rtbDescription = new RichTextBox();
            lblDescription = new Label();
            label10 = new Label();
            panel3 = new Panel();
            txtCustomCategory = new TextBox();
            cmbCategory = new ComboBox();
            txtItemName = new TextBox();
            lblCustomCategory = new Label();
            lblCategory = new Label();
            lblItemName = new Label();
            label3 = new Label();
            panel1 = new Panel();
            btnClearLost = new Button();
            btnSubmitLost = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            label9 = new Label();
            dtpDateLost = new DateTimePicker();
            txtLocation = new TextBox();
            lblLocation = new Label();
            label7 = new Label();
            dgvMyReports = new DataGridView();
            colRItemID = new DataGridViewTextBoxColumn();
            colRName = new DataGridViewTextBoxColumn();
            colRCategory = new DataGridViewTextBoxColumn();
            colRLocation = new DataGridViewTextBoxColumn();
            colRDate = new DataGridViewTextBoxColumn();
            colRStatus = new DataGridViewTextBoxColumn();
            colRPhoto = new DataGridViewTextBoxColumn();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelReportLost.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyReports).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panelReportLost);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvMyReports);
            splitContainer1.Panel2.Controls.Add(label14);
            splitContainer1.Size = new Size(1060, 1000);
            splitContainer1.SplitterDistance = 685;
            splitContainer1.TabIndex = 0;
            // 
            // panelReportLost
            // 
            panelReportLost.BackColor = Color.Transparent;
            panelReportLost.ColumnCount = 1;
            panelReportLost.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelReportLost.Controls.Add(panel5, 0, 3);
            panelReportLost.Controls.Add(panel3, 0, 1);
            panelReportLost.Controls.Add(panel1, 0, 4);
            panelReportLost.Controls.Add(panel2, 0, 0);
            panelReportLost.Controls.Add(panel4, 0, 2);
            panelReportLost.Dock = DockStyle.Fill;
            panelReportLost.Location = new Point(0, 0);
            panelReportLost.Name = "panelReportLost";
            panelReportLost.Padding = new Padding(16);
            panelReportLost.RowCount = 5;
            panelReportLost.RowStyles.Add(new RowStyle(SizeType.Percent, 10.973937F));
            panelReportLost.RowStyles.Add(new RowStyle(SizeType.Percent, 16.23277F));
            panelReportLost.RowStyles.Add(new RowStyle(SizeType.Percent, 15.6202145F));
            panelReportLost.RowStyles.Add(new RowStyle(SizeType.Percent, 43.7978554F));
            panelReportLost.RowStyles.Add(new RowStyle(SizeType.Percent, 13.7825422F));
            panelReportLost.Size = new Size(1060, 685);
            panelReportLost.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblPhotoStatus);
            panel5.Controls.Add(btnClearPhoto);
            panel5.Controls.Add(btnCamera);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(btnBrowse);
            panel5.Controls.Add(picPreview);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(rtbDescription);
            panel5.Controls.Add(lblDescription);
            panel5.Controls.Add(label10);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(19, 296);
            panel5.Name = "panel5";
            panel5.Size = new Size(1022, 278);
            panel5.TabIndex = 7;
            // 
            // lblPhotoStatus
            // 
            lblPhotoStatus.AutoSize = true;
            lblPhotoStatus.BackColor = Color.Transparent;
            lblPhotoStatus.Font = new Font("Letters for Learners", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhotoStatus.Location = new Point(547, 244);
            lblPhotoStatus.Name = "lblPhotoStatus";
            lblPhotoStatus.Size = new Size(123, 17);
            lblPhotoStatus.TabIndex = 17;
            lblPhotoStatus.Text = "No photo selected";
            // 
            // btnClearPhoto
            // 
            btnClearPhoto.BackColor = Color.FromArgb(192, 192, 255);
            btnClearPhoto.FlatAppearance.BorderSize = 0;
            btnClearPhoto.FlatStyle = FlatStyle.Flat;
            btnClearPhoto.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold);
            btnClearPhoto.ForeColor = Color.Transparent;
            btnClearPhoto.Location = new Point(740, 183);
            btnClearPhoto.Name = "btnClearPhoto";
            btnClearPhoto.Size = new Size(183, 29);
            btnClearPhoto.TabIndex = 16;
            btnClearPhoto.Text = "Clear Photo";
            btnClearPhoto.UseVisualStyleBackColor = false;
            // 
            // btnCamera
            // 
            btnCamera.BackColor = Color.FromArgb(192, 192, 255);
            btnCamera.FlatAppearance.BorderSize = 0;
            btnCamera.FlatStyle = FlatStyle.Flat;
            btnCamera.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold);
            btnCamera.ForeColor = Color.Transparent;
            btnCamera.Location = new Point(740, 138);
            btnCamera.Name = "btnCamera";
            btnCamera.Size = new Size(183, 29);
            btnCamera.TabIndex = 15;
            btnCamera.Text = "Open Camera";
            btnCamera.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Letters for Learners", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(665, 36);
            label13.Name = "label13";
            label13.Size = new Size(175, 17);
            label13.TabIndex = 14;
            label13.Text = "(JPG and PNG supported)";
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(192, 192, 255);
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold);
            btnBrowse.ForeColor = Color.Transparent;
            btnBrowse.Location = new Point(740, 92);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(183, 29);
            btnBrowse.TabIndex = 13;
            btnBrowse.Text = "Browse Files";
            btnBrowse.UseVisualStyleBackColor = false;
            // 
            // picPreview
            // 
            picPreview.Location = new Point(542, 61);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(180, 180);
            picPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            picPreview.TabIndex = 12;
            picPreview.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            label12.Location = new Point(547, 30);
            label12.Name = "label12";
            label12.Size = new Size(115, 52);
            label12.TabIndex = 11;
            label12.Text = "Item Photo\r\n\r\n";
            // 
            // rtbDescription
            // 
            rtbDescription.BackColor = Color.Bisque;
            rtbDescription.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbDescription.Location = new Point(17, 56);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(465, 196);
            rtbDescription.TabIndex = 10;
            rtbDescription.Text = "";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            lblDescription.Location = new Point(5, 25);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(110, 26);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(192, 64, 0);
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(163, 26);
            label10.TabIndex = 4;
            label10.Text = "Additional Details";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtCustomCategory);
            panel3.Controls.Add(cmbCategory);
            panel3.Controls.Add(txtItemName);
            panel3.Controls.Add(lblCustomCategory);
            panel3.Controls.Add(lblCategory);
            panel3.Controls.Add(lblItemName);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(19, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(1022, 99);
            panel3.TabIndex = 4;
            // 
            // txtCustomCategory
            // 
            txtCustomCategory.BackColor = Color.Bisque;
            txtCustomCategory.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            txtCustomCategory.Location = new Point(684, 60);
            txtCustomCategory.Name = "txtCustomCategory";
            txtCustomCategory.Size = new Size(186, 32);
            txtCustomCategory.TabIndex = 9;
            txtCustomCategory.Visible = false;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.Bisque;
            cmbCategory.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Electronics", "Clothing", "Accessories", "Books / Documents", "Bag / Wallet", "Keys", "ID / Cards", "Other" });
            cmbCategory.Location = new Point(412, 59);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(257, 34);
            cmbCategory.TabIndex = 8;
            // 
            // txtItemName
            // 
            txtItemName.BackColor = Color.Bisque;
            txtItemName.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            txtItemName.Location = new Point(17, 60);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(382, 32);
            txtItemName.TabIndex = 7;
            // 
            // lblCustomCategory
            // 
            lblCustomCategory.AutoSize = true;
            lblCustomCategory.BackColor = Color.Transparent;
            lblCustomCategory.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            lblCustomCategory.Location = new Point(684, 31);
            lblCustomCategory.Name = "lblCustomCategory";
            lblCustomCategory.Size = new Size(160, 26);
            lblCustomCategory.TabIndex = 6;
            lblCustomCategory.Text = "Specify Category";
            lblCustomCategory.Visible = false;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            lblCategory.Location = new Point(409, 31);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(87, 26);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.BackColor = Color.Transparent;
            lblItemName.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            lblItemName.Location = new Point(17, 31);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(111, 26);
            lblItemName.TabIndex = 4;
            lblItemName.Text = "Item Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(192, 64, 0);
            label3.Location = new Point(5, 5);
            label3.Name = "label3";
            label3.Size = new Size(123, 26);
            label3.TabIndex = 3;
            label3.Text = "Item Details";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClearLost);
            panel1.Controls.Add(btnSubmitLost);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(19, 580);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 86);
            panel1.TabIndex = 0;
            // 
            // btnClearLost
            // 
            btnClearLost.BackColor = Color.FromArgb(250, 240, 192);
            btnClearLost.FlatAppearance.BorderSize = 0;
            btnClearLost.FlatStyle = FlatStyle.Flat;
            btnClearLost.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold);
            btnClearLost.ForeColor = Color.FromArgb(92, 58, 0);
            btnClearLost.Location = new Point(450, 34);
            btnClearLost.Name = "btnClearLost";
            btnClearLost.Size = new Size(183, 39);
            btnClearLost.TabIndex = 1;
            btnClearLost.Text = "Clear Report";
            btnClearLost.UseVisualStyleBackColor = false;
            btnClearLost.Click += BtnClearLost_Click;
            // 
            // btnSubmitLost
            // 
            btnSubmitLost.BackColor = Color.FromArgb(107, 21, 38);
            btnSubmitLost.FlatStyle = FlatStyle.Flat;
            btnSubmitLost.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitLost.ForeColor = Color.FromArgb(245, 216, 120);
            btnSubmitLost.Location = new Point(230, 34);
            btnSubmitLost.Name = "btnSubmitLost";
            btnSubmitLost.Size = new Size(183, 39);
            btnSubmitLost.TabIndex = 0;
            btnSubmitLost.Text = "Submit Report";
            btnSubmitLost.UseVisualStyleBackColor = false;
            btnSubmitLost.Click += BtnSubmitLost_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(19, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(1022, 65);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(122, 78, 0);
            label2.Location = new Point(-3, 39);
            label2.Name = "label2";
            label2.Size = new Size(283, 22);
            label2.TabIndex = 1;
            label2.Text = "Fill in the details of the lost item.";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Kermit", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(90, 31, 31);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 39);
            label1.TabIndex = 0;
            label1.Text = "Report lost item";
            // 
            // panel4
            // 
            panel4.Controls.Add(label9);
            panel4.Controls.Add(dtpDateLost);
            panel4.Controls.Add(txtLocation);
            panel4.Controls.Add(lblLocation);
            panel4.Controls.Add(label7);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(19, 195);
            panel4.Name = "panel4";
            panel4.Size = new Size(1022, 95);
            panel4.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            label9.Location = new Point(507, 26);
            label9.Name = "label9";
            label9.Size = new Size(97, 26);
            label9.TabIndex = 11;
            label9.Text = "Date Lost";
            // 
            // dtpDateLost
            // 
            dtpDateLost.CalendarFont = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDateLost.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDateLost.Location = new Point(496, 55);
            dtpDateLost.MaxDate = new DateTime(2026, 4, 22, 0, 0, 0, 0);
            dtpDateLost.Name = "dtpDateLost";
            dtpDateLost.Size = new Size(403, 29);
            dtpDateLost.TabIndex = 10;
            dtpDateLost.Value = new DateTime(2026, 4, 9, 0, 0, 0, 0);
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.Bisque;
            txtLocation.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            txtLocation.Location = new Point(17, 55);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(465, 32);
            txtLocation.TabIndex = 9;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.BackColor = Color.Transparent;
            lblLocation.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            lblLocation.Location = new Point(17, 26);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(299, 26);
            lblLocation.TabIndex = 8;
            lblLocation.Text = "Location Lost (Possible location)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(192, 64, 0);
            label7.Location = new Point(5, 0);
            label7.Name = "label7";
            label7.Size = new Size(170, 26);
            label7.TabIndex = 4;
            label7.Text = "Location and Time";
            // 
            // dgvMyReports
            // 
            dgvMyReports.AllowUserToAddRows = false;
            dgvMyReports.AllowUserToDeleteRows = false;
            dgvMyReports.AllowUserToResizeColumns = false;
            dgvMyReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyReports.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMyReports.BackgroundColor = Color.Bisque;
            dgvMyReports.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Letters for Learners", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvMyReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvMyReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyReports.Columns.AddRange(new DataGridViewColumn[] { colRItemID, colRName, colRCategory, colRLocation, colRDate, colRStatus, colRPhoto });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Transparent;
            dataGridViewCellStyle4.Font = new Font("Letters for Learners", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvMyReports.DefaultCellStyle = dataGridViewCellStyle4;
            dgvMyReports.Dock = DockStyle.Fill;
            dgvMyReports.Location = new Point(0, 31);
            dgvMyReports.Name = "dgvMyReports";
            dgvMyReports.ReadOnly = true;
            dgvMyReports.RowHeadersVisible = false;
            dgvMyReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMyReports.Size = new Size(1060, 280);
            dgvMyReports.TabIndex = 2;
            // 
            // colRItemID
            // 
            colRItemID.HeaderText = "Item ID";
            colRItemID.Name = "colRItemID";
            colRItemID.ReadOnly = true;
            // 
            // colRName
            // 
            colRName.HeaderText = "Item Name";
            colRName.Name = "colRName";
            colRName.ReadOnly = true;
            // 
            // colRCategory
            // 
            colRCategory.HeaderText = "Category";
            colRCategory.Name = "colRCategory";
            colRCategory.ReadOnly = true;
            // 
            // colRLocation
            // 
            colRLocation.HeaderText = "Location";
            colRLocation.Name = "colRLocation";
            colRLocation.ReadOnly = true;
            // 
            // colRDate
            // 
            colRDate.HeaderText = "Date Lost";
            colRDate.Name = "colRDate";
            colRDate.ReadOnly = true;
            // 
            // colRStatus
            // 
            colRStatus.HeaderText = "Status";
            colRStatus.Name = "colRStatus";
            colRStatus.ReadOnly = true;
            // 
            // colRPhoto
            // 
            colRPhoto.HeaderText = "Has Photo";
            colRPhoto.Name = "colRPhoto";
            colRPhoto.ReadOnly = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Top;
            label14.Font = new Font("Kermit", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(211, 31);
            label14.TabIndex = 1;
            label14.Text = "My Lost Item Reports";
            // 
            // ReportLost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(983, 1000);
            BackColor = Color.FromArgb(217, 175, 134);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(splitContainer1);
            DoubleBuffered = true;
            Name = "ReportLost";
            Size = new Size(1060, 569);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelReportLost.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyReports).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dtpDateLost;
        
        private Button btnClearLost;
        private Button btnSubmitLost;
        
        
        
        private Label lblCustomCategory;
        
        
        
        private SplitContainer splitContainer1;
        private TableLayoutPanel panelReportLost;
        private Panel panel5;
        private Button btnCamera;
        private Label label13;
        private Button btnBrowse;
        private PictureBox picPreview;
        private Label label12;
        private RichTextBox rtbDescription;
        private Label lblDescription;
        private Label label10;
        private Panel panel3;
        private TextBox txtCustomCategory;
        private ComboBox cmbCategory;
        private TextBox txtItemName;
        private Label lblCategory;
        private Label lblItemName;
        private Label label3;
        private Panel panel1;

        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private Label label9;

        private TextBox txtLocation;
        private Label lblLocation;
        private Label label7;
        private Label lblPhotoStatus;
        private Button btnClearPhoto;
        private DataGridView dgvMyReports;
        private DataGridViewTextBoxColumn colRItemID;
        private DataGridViewTextBoxColumn colRName;
        private DataGridViewTextBoxColumn colRCategory;
        private DataGridViewTextBoxColumn colRLocation;
        private DataGridViewTextBoxColumn colRDate;
        private DataGridViewTextBoxColumn colRStatus;
        private DataGridViewTextBoxColumn colRPhoto;
        private Label label14;

    }
}
