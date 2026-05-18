namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    partial class ArchiveReports
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Label lblSelected;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvItems = new DataGridView();
            txtReason = new TextBox();
            lblReason = new Label();
            btnArchive = new Button();
            lblSelected = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AllowUserToResizeColumns = false;
            dgvItems.AllowUserToResizeRows = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.BackgroundColor = Color.Bisque;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Letters for Learners", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dataGridViewCellStyle2;
            dgvItems.Location = new Point(20, 20);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(900, 350);
            dgvItems.TabIndex = 0;
            dgvItems.CellClick += dgvItems_CellClick;
            // 
            // txtReason
            // 
            txtReason.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtReason.Location = new Point(20, 410);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(600, 80);
            txtReason.TabIndex = 1;
            // 
            // lblReason
            // 
            lblReason.AutoSize = true;
            lblReason.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReason.ForeColor = Color.FromArgb(122, 78, 0);
            lblReason.Location = new Point(22, 386);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(132, 22);
            lblReason.TabIndex = 2;
            lblReason.Text = "Archive Reason:";
            // 
            // btnArchive
            // 
            btnArchive.BackColor = Color.FromArgb(107, 21, 38);
            btnArchive.FlatStyle = FlatStyle.Flat;
            btnArchive.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnArchive.ForeColor = Color.FromArgb(230, 201, 122);
            btnArchive.Location = new Point(680, 410);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(200, 40);
            btnArchive.TabIndex = 3;
            btnArchive.Text = "Archive Item";
            btnArchive.UseVisualStyleBackColor = false;
            btnArchive.Click += btnArchive_Click;
            // 
            // lblSelected
            // 
            lblSelected.AutoSize = true;
            lblSelected.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelected.ForeColor = Color.FromArgb(122, 78, 0);
            lblSelected.Location = new Point(703, 468);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(154, 22);
            lblSelected.TabIndex = 4;
            lblSelected.Text = "Selected ID: None";
            // 
            // ArchiveReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 175, 134);
            Controls.Add(dgvItems);
            Controls.Add(txtReason);
            Controls.Add(lblReason);
            Controls.Add(btnArchive);
            Controls.Add(lblSelected);
            Name = "ArchiveReports";
            Size = new Size(950, 520);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}