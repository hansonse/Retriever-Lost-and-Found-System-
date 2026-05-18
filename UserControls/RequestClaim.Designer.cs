namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    partial class RequestClaim
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel3 = new Panel();
            btnMyClaimSlip = new Button();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            cbxCategories = new ComboBox();
            dgvFoundItems = new DataGridView();
            colFItemID = new DataGridViewTextBoxColumn();
            colFName = new DataGridViewTextBoxColumn();
            colFCategory = new DataGridViewTextBoxColumn();
            colFLocation = new DataGridViewTextBoxColumn();
            colFDate = new DataGridViewTextBoxColumn();
            label3 = new Label();
            panel4 = new Panel();
            lblSelectedItem = new Label();
            btnSubmitClaim = new Button();
            btnClear = new Button();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoundItems).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel4, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(16);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75.91707F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.0829353F));
            tableLayoutPanel1.Size = new Size(1000, 729);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(19, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 64);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnMyClaimSlip);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(962, 64);
            panel3.TabIndex = 0;
            // 
            // btnMyClaimSlip
            // 
            btnMyClaimSlip.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMyClaimSlip.Location = new Point(786, 15);
            btnMyClaimSlip.Name = "btnMyClaimSlip";
            btnMyClaimSlip.Size = new Size(173, 33);
            btnMyClaimSlip.TabIndex = 3;
            btnMyClaimSlip.Text = "My Claim Slip";
            btnMyClaimSlip.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 39);
            label2.Name = "label2";
            label2.Size = new Size(314, 22);
            label2.TabIndex = 2;
            label2.Text = "Select a found item to submit a claim";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Kermit", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(235, 39);
            label1.TabIndex = 1;
            label1.Text = "Request and Claim";
            // 
            // panel2
            // 
            panel2.Controls.Add(cbxCategories);
            panel2.Controls.Add(dgvFoundItems);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(19, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(962, 470);
            panel2.TabIndex = 3;
            // 
            // cbxCategories
            // 
            cbxCategories.Dock = DockStyle.Top;
            cbxCategories.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbxCategories.FormattingEnabled = true;
            cbxCategories.Location = new Point(0, 17);
            cbxCategories.Name = "cbxCategories";
            cbxCategories.Size = new Size(962, 29);
            cbxCategories.TabIndex = 6;
            cbxCategories.Text = "Categories";
            // 
            // dgvFoundItems
            // 
            dgvFoundItems.AllowUserToAddRows = false;
            dgvFoundItems.AllowUserToDeleteRows = false;
            dgvFoundItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFoundItems.BackgroundColor = Color.Bisque;
            dgvFoundItems.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFoundItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFoundItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoundItems.Columns.AddRange(new DataGridViewColumn[] { colFItemID, colFName, colFCategory, colFLocation, colFDate });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFoundItems.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFoundItems.Dock = DockStyle.Bottom;
            dgvFoundItems.Location = new Point(0, 43);
            dgvFoundItems.MultiSelect = false;
            dgvFoundItems.Name = "dgvFoundItems";
            dgvFoundItems.ReadOnly = true;
            dgvFoundItems.RowHeadersVisible = false;
            dgvFoundItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoundItems.Size = new Size(962, 427);
            dgvFoundItems.TabIndex = 5;
            // 
            // colFItemID
            // 
            colFItemID.HeaderText = "Item ID";
            colFItemID.Name = "colFItemID";
            colFItemID.ReadOnly = true;
            // 
            // colFName
            // 
            colFName.HeaderText = "Item Name";
            colFName.Name = "colFName";
            colFName.ReadOnly = true;
            // 
            // colFCategory
            // 
            colFCategory.HeaderText = "Category";
            colFCategory.Name = "colFCategory";
            colFCategory.ReadOnly = true;
            // 
            // colFLocation
            // 
            colFLocation.HeaderText = "Found Location";
            colFLocation.Name = "colFLocation";
            colFLocation.ReadOnly = true;
            // 
            // colFDate
            // 
            colFDate.HeaderText = "Date Found";
            colFDate.Name = "colFDate";
            colFDate.ReadOnly = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Letters for Learners", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(231, 17);
            label3.TabIndex = 4;
            label3.Text = "Found Items — Select one to claim";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 249, 196);
            panel4.Controls.Add(lblSelectedItem);
            panel4.Controls.Add(btnSubmitClaim);
            panel4.Controls.Add(btnClear);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(richTextBox1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(19, 565);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(962, 145);
            panel4.TabIndex = 4;
            // 
            // lblSelectedItem
            // 
            lblSelectedItem.AutoSize = true;
            lblSelectedItem.Font = new Font("Letters for Learners", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedItem.Location = new Point(8, 105);
            lblSelectedItem.Name = "lblSelectedItem";
            lblSelectedItem.Size = new Size(47, 17);
            lblSelectedItem.TabIndex = 4;
            lblSelectedItem.Text = "label5";
            // 
            // btnSubmitClaim
            // 
            btnSubmitClaim.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitClaim.Location = new Point(681, 105);
            btnSubmitClaim.Name = "btnSubmitClaim";
            btnSubmitClaim.Size = new Size(192, 32);
            btnSubmitClaim.TabIndex = 3;
            btnSubmitClaim.Text = "Submit Claim Request";
            btnSubmitClaim.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(879, 105);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 32);
            btnClear.TabIndex = 2;
            btnClear.Text = "clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(8, 5);
            label4.Name = "label4";
            label4.Size = new Size(345, 21);
            label4.TabIndex = 1;
            label4.Text = "Selected item · Add a message with your claim";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Info;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.Maroon;
            richTextBox1.Location = new Point(16, 29);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(938, 56);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // RequestClaim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 175, 134);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Name = "RequestClaim";
            Size = new Size(1000, 729);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoundItems).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private DataGridView dgvFoundItems;
        private DataGridViewTextBoxColumn colFItemID;
        private DataGridViewTextBoxColumn colFName;
        private DataGridViewTextBoxColumn colFCategory;
        private DataGridViewTextBoxColumn colFLocation;
        private DataGridViewTextBoxColumn colFDate;
        private Label label3;
        private Button btnMyClaimSlip;
        private Panel panel4;
        private Label label4;
        private RichTextBox richTextBox1;
        private Label lblSelectedItem;
        private Button btnSubmitClaim;
        private Button btnClear;
        private ComboBox cbxCategories;
    }
}
