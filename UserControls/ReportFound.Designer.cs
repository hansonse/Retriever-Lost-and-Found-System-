namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    partial class ReportFound
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            txtCustomCategory = new TextBox();
            cmbCategory = new ComboBox();
            txtItemName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            btnClearFound = new Button();
            btnSubmitFound = new Button();
            panel2 = new Panel();
            label1 = new Label();
            label14 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            label9 = new Label();
            dtpDateFound = new DateTimePicker();
            txtLocation = new TextBox();
            label8 = new Label();
            label7 = new Label();
            lblLocationSurrendered = new Label();
            txtLocationSurrendered = new TextBox();
            panel5 = new Panel();
            lblPhotoStatus = new Label();
            btnClearPhoto = new Button();
            btnCamera = new Button();
            label13 = new Label();
            btnBrowse = new Button();
            picPreview = new PictureBox();
            label12 = new Label();
            rtbDescription = new RichTextBox();
            label11 = new Label();
            label10 = new Label();
            dgvMyReports = new DataGridView();
            colRItemID = new DataGridViewTextBoxColumn();
            colRName = new DataGridViewTextBoxColumn();
            colRCategory = new DataGridViewTextBoxColumn();
            colRLocation = new DataGridViewTextBoxColumn();
            colRLocationSurrendered = new DataGridViewTextBoxColumn();
            colRDate = new DataGridViewTextBoxColumn();
            colRStatus = new DataGridViewTextBoxColumn();
            colRPhoto = new DataGridViewTextBoxColumn();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMyReports).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvMyReports);
            splitContainer1.Panel2.Controls.Add(label15);
            splitContainer1.Size = new Size(983, 1000);
            splitContainer1.SplitterDistance = 762;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 4);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 0, 2);
            tableLayoutPanel1.Controls.Add(panel5, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(16);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.8728943F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.3767223F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.2463951F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35.5176926F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7843142F));
            tableLayoutPanel1.Size = new Size(983, 762);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtCustomCategory);
            panel3.Controls.Add(cmbCategory);
            panel3.Controls.Add(txtItemName);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(19, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(945, 128);
            panel3.TabIndex = 4;
            // 
            // txtCustomCategory
            // 
            txtCustomCategory.BackColor = Color.Bisque;
            txtCustomCategory.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            txtCustomCategory.Location = new Point(695, 60);
            txtCustomCategory.Name = "txtCustomCategory";
            txtCustomCategory.Size = new Size(183, 32);
            txtCustomCategory.TabIndex = 9;
            txtCustomCategory.Visible = false;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.Bisque;
            cmbCategory.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Electronics", "Clothing", "Accessories", "Books / Documents", "Bag / Wallet", "Keys", "ID / Cards", "Other" });
            cmbCategory.Location = new Point(418, 59);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            label6.Location = new Point(695, 31);
            label6.Name = "label6";
            label6.Size = new Size(160, 26);
            label6.TabIndex = 6;
            label6.Text = "Specify Category";
            label6.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            label5.Location = new Point(415, 31);
            label5.Name = "label5";
            label5.Size = new Size(87, 26);
            label5.TabIndex = 5;
            label5.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            label4.Location = new Point(17, 31);
            label4.Name = "label4";
            label4.Size = new Size(111, 26);
            label4.TabIndex = 4;
            label4.Text = "Item Name";
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
            panel1.Controls.Add(btnClearFound);
            panel1.Controls.Add(btnSubmitFound);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(19, 668);
            panel1.Name = "panel1";
            panel1.Size = new Size(945, 75);
            panel1.TabIndex = 0;
            // 
            // btnClearFound
            // 
            btnClearFound.BackColor = Color.FromArgb(250, 240, 192);
            btnClearFound.FlatAppearance.BorderSize = 0;
            btnClearFound.FlatStyle = FlatStyle.Flat;
            btnClearFound.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold);
            btnClearFound.ForeColor = Color.FromArgb(92, 58, 0);
            btnClearFound.Location = new Point(491, 14);
            btnClearFound.Name = "btnClearFound";
            btnClearFound.Size = new Size(183, 39);
            btnClearFound.TabIndex = 20;
            btnClearFound.Text = "Clear Report";
            btnClearFound.UseVisualStyleBackColor = false;
            // 
            // btnSubmitFound
            // 
            btnSubmitFound.BackColor = Color.FromArgb(107, 21, 38);
            btnSubmitFound.FlatStyle = FlatStyle.Flat;
            btnSubmitFound.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitFound.ForeColor = Color.FromArgb(245, 216, 120);
            btnSubmitFound.Location = new Point(271, 14);
            btnSubmitFound.Name = "btnSubmitFound";
            btnSubmitFound.Size = new Size(183, 39);
            btnSubmitFound.TabIndex = 19;
            btnSubmitFound.Text = "Submit Report";
            btnSubmitFound.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(19, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(945, 73);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(122, 78, 0);
            label1.Location = new Point(0, 47);
            label1.Name = "label1";
            label1.Size = new Size(298, 22);
            label1.TabIndex = 3;
            label1.Text = "Fill in the details of the found item.";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Font = new Font("Kermit", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(90, 31, 31);
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(231, 39);
            label14.TabIndex = 2;
            label14.Text = "Report Found item";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Letters for Learners", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 79);
            label2.Name = "label2";
            label2.Size = new Size(370, 29);
            label2.TabIndex = 1;
            label2.Text = "Fill in the details of the found item.";
            // 
            // panel4
            // 
            panel4.Controls.Add(label9);
            panel4.Controls.Add(dtpDateFound);
            panel4.Controls.Add(txtLocation);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(lblLocationSurrendered);
            panel4.Controls.Add(txtLocationSurrendered);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(19, 232);
            panel4.Name = "panel4";
            panel4.Size = new Size(945, 171);
            panel4.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            label9.Location = new Point(520, 28);
            label9.Name = "label9";
            label9.Size = new Size(111, 26);
            label9.TabIndex = 11;
            label9.Text = "Date Found";
            // 
            // dtpDateFound
            // 
            dtpDateFound.CalendarFont = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDateFound.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDateFound.Location = new Point(520, 57);
            dtpDateFound.Name = "dtpDateFound";
            dtpDateFound.Size = new Size(358, 29);
            dtpDateFound.TabIndex = 10;
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.Bisque;
            txtLocation.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            txtLocation.Location = new Point(17, 57);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(481, 32);
            txtLocation.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            label8.Location = new Point(17, 28);
            label8.Name = "label8";
            label8.Size = new Size(143, 26);
            label8.TabIndex = 8;
            label8.Text = "Location Found";
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
            // lblLocationSurrendered
            // 
            lblLocationSurrendered.AutoSize = true;
            lblLocationSurrendered.BackColor = Color.Transparent;
            lblLocationSurrendered.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            lblLocationSurrendered.Location = new Point(17, 100);
            lblLocationSurrendered.Name = "lblLocationSurrendered";
            lblLocationSurrendered.Size = new Size(198, 26);
            lblLocationSurrendered.TabIndex = 12;
            lblLocationSurrendered.Text = "Location Surrendered";
            // 
            // txtLocationSurrendered
            // 
            txtLocationSurrendered.BackColor = Color.Bisque;
            txtLocationSurrendered.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            txtLocationSurrendered.Location = new Point(17, 128);
            txtLocationSurrendered.Name = "txtLocationSurrendered";
            txtLocationSurrendered.Size = new Size(861, 32);
            txtLocationSurrendered.TabIndex = 13;
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
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label10);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(19, 409);
            panel5.Name = "panel5";
            panel5.Size = new Size(945, 253);
            panel5.TabIndex = 6;
            // 
            // lblPhotoStatus
            // 
            lblPhotoStatus.AutoSize = true;
            lblPhotoStatus.BackColor = Color.Transparent;
            lblPhotoStatus.Font = new Font("Letters for Learners", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhotoStatus.Location = new Point(546, 213);
            lblPhotoStatus.Name = "lblPhotoStatus";
            lblPhotoStatus.Size = new Size(123, 17);
            lblPhotoStatus.TabIndex = 25;
            lblPhotoStatus.Text = "No photo selected";
            // 
            // btnClearPhoto
            // 
            btnClearPhoto.BackColor = Color.FromArgb(192, 192, 255);
            btnClearPhoto.FlatAppearance.BorderSize = 0;
            btnClearPhoto.FlatStyle = FlatStyle.Flat;
            btnClearPhoto.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold);
            btnClearPhoto.ForeColor = Color.Transparent;
            btnClearPhoto.Location = new Point(744, 152);
            btnClearPhoto.Name = "btnClearPhoto";
            btnClearPhoto.Size = new Size(183, 29);
            btnClearPhoto.TabIndex = 24;
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
            btnCamera.Location = new Point(744, 107);
            btnCamera.Name = "btnCamera";
            btnCamera.Size = new Size(183, 29);
            btnCamera.TabIndex = 23;
            btnCamera.Text = "Open Camera";
            btnCamera.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Letters for Learners", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(669, 5);
            label13.Name = "label13";
            label13.Size = new Size(175, 17);
            label13.TabIndex = 22;
            label13.Text = "(JPG and PNG supported)";
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(192, 192, 255);
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold);
            btnBrowse.ForeColor = Color.Transparent;
            btnBrowse.Location = new Point(744, 61);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(183, 29);
            btnBrowse.TabIndex = 21;
            btnBrowse.Text = "Browse Files";
            btnBrowse.UseVisualStyleBackColor = false;
            // 
            // picPreview
            // 
            picPreview.Location = new Point(546, 30);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(180, 180);
            picPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            picPreview.TabIndex = 20;
            picPreview.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            label12.Location = new Point(551, -1);
            label12.Name = "label12";
            label12.Size = new Size(115, 52);
            label12.TabIndex = 19;
            label12.Text = "Item Photo\r\n\r\n";
            // 
            // rtbDescription
            // 
            rtbDescription.BackColor = Color.Bisque;
            rtbDescription.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbDescription.Location = new Point(17, 61);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(481, 176);
            rtbDescription.TabIndex = 10;
            rtbDescription.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            label11.Location = new Point(5, 30);
            label11.Name = "label11";
            label11.Size = new Size(110, 26);
            label11.TabIndex = 9;
            label11.Text = "Description";
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
            // dgvMyReports
            // 
            dgvMyReports.AllowUserToAddRows = false;
            dgvMyReports.AllowUserToDeleteRows = false;
            dgvMyReports.AllowUserToResizeColumns = false;
            dgvMyReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyReports.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMyReports.BackgroundColor = Color.Bisque;
            dgvMyReports.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Letters for Learners", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMyReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMyReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyReports.Columns.AddRange(new DataGridViewColumn[] { colRItemID, colRName, colRCategory, colRLocation, colRLocationSurrendered, colRDate, colRStatus, colRPhoto });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Letters for Learners", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMyReports.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMyReports.Dock = DockStyle.Fill;
            dgvMyReports.Location = new Point(0, 31);
            dgvMyReports.Name = "dgvMyReports";
            dgvMyReports.ReadOnly = true;
            dgvMyReports.RowHeadersVisible = false;
            dgvMyReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMyReports.Size = new Size(983, 203);
            dgvMyReports.TabIndex = 4;
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
            // colRLocationSurrendered
            // 
            colRLocationSurrendered.HeaderText = "Surrendered At";
            colRLocationSurrendered.Name = "colRLocationSurrendered";
            colRLocationSurrendered.ReadOnly = true;
            // 
            // colRDate
            // 
            colRDate.HeaderText = "Date Found";
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
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Top;
            label15.Font = new Font("Kermit", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(0, 0);
            label15.Name = "label15";
            label15.Size = new Size(230, 31);
            label15.TabIndex = 3;
            label15.Text = "My Found Item Reports";
            // 
            // ReportFound
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(983, 1000);
            BackColor = Color.FromArgb(217, 175, 134);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(splitContainer1);
            DoubleBuffered = true;
            Name = "ReportFound";
            Size = new Size(971, 345);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMyReports).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private TextBox txtCustomCategory;
        private ComboBox cmbCategory;
        private TextBox txtItemName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Panel panel4;
        private Label label9;
        private DateTimePicker dtpDateFound;
        private TextBox txtLocation;
        private Label label8;
        private Label label7;
        private Panel panel5;
        private RichTextBox rtbDescription;
        private Label label11;
        private Label label10;
        private Button btnClearPhoto;
        private Button btnCamera;
        private Label label13;
        private Button btnBrowse;
        private PictureBox picPreview;
        private Label label12;
        private Button btnClearFound;
        private Button btnSubmitFound;
        private Label label1;
        private Label label14;
        private Label lblPhotoStatus;
        private DataGridView dgvMyReports;
        private Label label15;
        private DataGridViewTextBoxColumn colRItemID;
        private DataGridViewTextBoxColumn colRName;
        private DataGridViewTextBoxColumn colRCategory;
        private DataGridViewTextBoxColumn colRLocation;
        private DataGridViewTextBoxColumn colRDate;
        private DataGridViewTextBoxColumn colRStatus;
        private DataGridViewTextBoxColumn colRPhoto;
        private TextBox txtLocationSurrendered;
        private Label lblLocationSurrendered;
        private DataGridViewTextBoxColumn colRLocationSurrendered;
    }
}
