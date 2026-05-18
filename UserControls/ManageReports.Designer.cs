namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    partial class ManageReports
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnArchiveReport = new Button();
            btnMatchReports = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.8032789F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.21311474F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.9836044F));
            tableLayoutPanel1.Size = new Size(1000, 729);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(8, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 78);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 48);
            label2.Name = "label2";
            label2.Size = new Size(212, 21);
            label2.TabIndex = 1;
            label2.Text = "Add and match item reports";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kermit", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(235, 45);
            label1.TabIndex = 0;
            label1.Text = "Manage Reports";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnArchiveReport);
            panel2.Controls.Add(btnMatchReports);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(8, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 45);
            panel2.TabIndex = 1;
            // 
            // btnArchiveReport
            // 
            btnArchiveReport.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnArchiveReport.Location = new Point(810, 7);
            btnArchiveReport.Name = "btnArchiveReport";
            btnArchiveReport.Size = new Size(171, 30);
            btnArchiveReport.TabIndex = 3;
            btnArchiveReport.Text = "Archive Reports";
            btnArchiveReport.UseVisualStyleBackColor = true;
            btnArchiveReport.Click += btnArchiveReport_Click;
            // 
            // btnMatchReports
            // 
            btnMatchReports.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMatchReports.Location = new Point(555, 7);
            btnMatchReports.Name = "btnMatchReports";
            btnMatchReports.Size = new Size(171, 30);
            btnMatchReports.TabIndex = 2;
            btnMatchReports.Text = "Match Reports";
            btnMatchReports.UseVisualStyleBackColor = true;
            btnMatchReports.Click += btnMatchReports_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(277, 7);
            button2.Name = "button2";
            button2.Size = new Size(171, 30);
            button2.TabIndex = 1;
            button2.Text = "Report Lost Item";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 7);
            button1.Name = "button1";
            button1.Size = new Size(171, 30);
            button1.TabIndex = 0;
            button1.Text = "Report Found Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(8, 143);
            panel3.Name = "panel3";
            panel3.Size = new Size(984, 578);
            panel3.TabIndex = 2;
            // 
            // ManageReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 175, 134);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Name = "ManageReports";
            Size = new Size(1000, 729);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button btnMatchReports;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private Button btnArchiveReport;
    }
}
