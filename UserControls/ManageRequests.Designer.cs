namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    partial class ManageRequests
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            lblSub = new Label();
            lblTitle = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.04348F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.5854073F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.47927F));
            tableLayoutPanel1.Size = new Size(1000, 729);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblSub);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(8, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 87);
            panel1.TabIndex = 0;
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSub.Location = new Point(8, 45);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(308, 22);
            lblSub.TabIndex = 3;
            lblSub.Text = "Review and respond to claim requests";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Pixelated Display", 21.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(3, 7);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(287, 33);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Manage Requests";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Bisque;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column6, Column5 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(8, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(984, 350);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Request ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Item ID";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Item Name";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Requester";
            Column4.Name = "Column4";
            // 
            // Column6
            // 
            Column6.HeaderText = "Actions";
            Column6.Name = "Column6";
            // 
            // Column5
            // 
            Column5.HeaderText = "Status";
            Column5.Name = "Column5";
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            // btnAllClaimSlips
            btnAllClaimSlips = new Button();
            btnAllClaimSlips.Text = "All Claim Slips";
            btnAllClaimSlips.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAllClaimSlips.Location = new Point(416, 69);
            btnAllClaimSlips.Size = new Size(196, 44);
            btnAllClaimSlips.BackColor = Color.FromArgb(26, 58, 92);
            btnAllClaimSlips.ForeColor = Color.White;
            btnAllClaimSlips.FlatStyle = FlatStyle.Flat;
            btnAllClaimSlips.TabIndex = 4;
            panel2.Controls.Add(btnAllClaimSlips);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(8, 457);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 264);
            panel2.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.FlatAppearance.BorderColor = Color.Red;
            button2.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(210, 69);
            button2.Name = "button2";
            button2.Size = new Size(196, 44);
            button2.TabIndex = 3;
            button2.Text = "Reject with remarks";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.FlatAppearance.BorderColor = Color.Lime;
            button1.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(8, 69);
            button1.Name = "button1";
            button1.Size = new Size(196, 44);
            button1.TabIndex = 2;
            button1.Text = "Approve with remarks";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            textBox1.Location = new Point(8, 31);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter remarks for the requester . . .";
            textBox1.Size = new Size(863, 32);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Letters for Learners", 17.9999981F, FontStyle.Bold);
            label1.Location = new Point(4, 3);
            label1.Name = "label1";
            label1.Size = new Size(305, 26);
            label1.TabIndex = 0;
            label1.Text = "Add Remarks (select a row first)";
            // 
            // ManageRequests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 175, 134);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Name = "ManageRequests";
            Size = new Size(1000, 729);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label lblSub;
        private Label lblTitle;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button btnAllClaimSlips;
    }
}
