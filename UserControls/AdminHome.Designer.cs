namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    partial class AdminHome
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tlpMain = new TableLayoutPanel();
            panelHeader = new Panel();
            lblAdminSub = new Label();
            lblAdminTitle = new Label();
            tlpAdminCards = new TableLayoutPanel();
            cardApproved = new Panel();
            label1 = new Label();
            lblAdminApproved = new Label();
            cardPending = new Panel();
            label2 = new Label();
            lblPendingCount = new Label();
            cardArchived = new Panel();
            label3 = new Label();
            lblArchivedCount = new Label();
            cardFound = new Panel();
            label4 = new Label();
            lblAdminFound = new Label();
            cardLost = new Panel();
            label5 = new Label();
            lblAdminLost = new Label();
            cardTotal = new Panel();
            label7 = new Label();
            lblTotalCount = new Label();
            groupBox1 = new GroupBox();
            dgvAdminActivity = new DataGridView();
            colAdminActivity = new DataGridViewTextBoxColumn();
            colAdminUser = new DataGridViewTextBoxColumn();
            colAdminDate = new DataGridViewTextBoxColumn();
            colAdminStatus = new DataGridViewTextBoxColumn();
            panelChart = new Panel();
            label6 = new Label();
            tlpMain.SuspendLayout();
            panelHeader.SuspendLayout();
            tlpAdminCards.SuspendLayout();
            cardApproved.SuspendLayout();
            cardPending.SuspendLayout();
            cardArchived.SuspendLayout();
            cardFound.SuspendLayout();
            cardLost.SuspendLayout();
            cardTotal.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminActivity).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.BackColor = Color.Transparent;
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(panelHeader, 0, 0);
            tlpMain.Controls.Add(tlpAdminCards, 0, 1);
            tlpMain.Controls.Add(groupBox1, 0, 3);
            tlpMain.Controls.Add(panelChart, 0, 2);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(16);
            tlpMain.RowCount = 4;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 220F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1047, 729);
            tlpMain.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(196, 154, 106);
            panelHeader.Controls.Add(lblAdminSub);
            panelHeader.Controls.Add(lblAdminTitle);
            panelHeader.Dock = DockStyle.Fill;
            panelHeader.Location = new Point(19, 19);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1009, 74);
            panelHeader.TabIndex = 0;
            // 
            // lblAdminSub
            // 
            lblAdminSub.AutoSize = true;
            lblAdminSub.Font = new Font("Letters for Learners", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminSub.ForeColor = Color.White;
            lblAdminSub.Location = new Point(6, 46);
            lblAdminSub.Name = "lblAdminSub";
            lblAdminSub.Size = new Size(0, 17);
            lblAdminSub.TabIndex = 1;
            // 
            // lblAdminTitle
            // 
            lblAdminTitle.AutoSize = true;
            lblAdminTitle.Dock = DockStyle.Top;
            lblAdminTitle.Font = new Font("Kermit", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminTitle.ForeColor = Color.FromArgb(74, 14, 26);
            lblAdminTitle.Location = new Point(0, 0);
            lblAdminTitle.Name = "lblAdminTitle";
            lblAdminTitle.Size = new Size(0, 45);
            lblAdminTitle.TabIndex = 0;
            // 
            // tlpAdminCards
            // 
            tlpAdminCards.ColumnCount = 6;
            tlpAdminCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tlpAdminCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tlpAdminCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tlpAdminCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tlpAdminCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tlpAdminCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tlpAdminCards.Controls.Add(cardApproved, 5, 0);
            tlpAdminCards.Controls.Add(cardPending, 4, 0);
            tlpAdminCards.Controls.Add(cardArchived, 3, 0);
            tlpAdminCards.Controls.Add(cardFound, 2, 0);
            tlpAdminCards.Controls.Add(cardLost, 1, 0);
            tlpAdminCards.Controls.Add(cardTotal, 0, 0);
            tlpAdminCards.Dock = DockStyle.Fill;
            tlpAdminCards.Location = new Point(19, 99);
            tlpAdminCards.Name = "tlpAdminCards";
            tlpAdminCards.RowCount = 1;
            tlpAdminCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAdminCards.Size = new Size(1009, 104);
            tlpAdminCards.TabIndex = 1;
            // 
            // cardApproved
            // 
            cardApproved.BackColor = Color.FromArgb(230, 201, 122);
            cardApproved.Controls.Add(label1);
            cardApproved.Controls.Add(lblAdminApproved);
            cardApproved.Dock = DockStyle.Fill;
            cardApproved.Location = new Point(843, 3);
            cardApproved.Name = "cardApproved";
            cardApproved.Size = new Size(163, 98);
            cardApproved.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Letters for Learners", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(122, 78, 0);
            label1.Location = new Point(45, 15);
            label1.Name = "label1";
            label1.Size = new Size(64, 17);
            label1.TabIndex = 2;
            label1.Text = "Approved";
            // 
            // lblAdminApproved
            // 
            lblAdminApproved.AutoSize = true;
            lblAdminApproved.Font = new Font("Kermit", 15.7499981F, FontStyle.Bold);
            lblAdminApproved.ForeColor = Color.FromArgb(74, 14, 26);
            lblAdminApproved.Location = new Point(66, 32);
            lblAdminApproved.Name = "lblAdminApproved";
            lblAdminApproved.Size = new Size(27, 34);
            lblAdminApproved.TabIndex = 1;
            lblAdminApproved.Text = "0";
            // 
            // cardPending
            // 
            cardPending.BackColor = Color.FromArgb(243, 227, 181);
            cardPending.Controls.Add(label2);
            cardPending.Controls.Add(lblPendingCount);
            cardPending.Dock = DockStyle.Fill;
            cardPending.Location = new Point(675, 3);
            cardPending.Name = "cardPending";
            cardPending.Size = new Size(162, 98);
            cardPending.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Letters for Learners", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(122, 78, 0);
            label2.Location = new Point(22, 15);
            label2.Name = "label2";
            label2.Size = new Size(117, 17);
            label2.TabIndex = 3;
            label2.Text = "Pending Matches";
            // 
            // lblPendingCount
            // 
            lblPendingCount.AutoSize = true;
            lblPendingCount.Font = new Font("Kermit", 15.7499981F, FontStyle.Bold);
            lblPendingCount.ForeColor = Color.FromArgb(74, 14, 26);
            lblPendingCount.Location = new Point(59, 32);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(27, 34);
            lblPendingCount.TabIndex = 1;
            lblPendingCount.Text = "0";
            // 
            // cardArchived
            // 
            cardArchived.BackColor = Color.FromArgb(250, 245, 230);
            cardArchived.Controls.Add(label3);
            cardArchived.Controls.Add(lblArchivedCount);
            cardArchived.Dock = DockStyle.Fill;
            cardArchived.Location = new Point(507, 3);
            cardArchived.Name = "cardArchived";
            cardArchived.Size = new Size(162, 98);
            cardArchived.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Letters for Learners", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(122, 78, 0);
            label3.Location = new Point(53, 15);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 3;
            label3.Text = "Archived";
            // 
            // lblArchivedCount
            // 
            lblArchivedCount.AutoSize = true;
            lblArchivedCount.Font = new Font("Kermit", 15.7499981F, FontStyle.Bold);
            lblArchivedCount.ForeColor = Color.FromArgb(74, 14, 26);
            lblArchivedCount.Location = new Point(70, 32);
            lblArchivedCount.Name = "lblArchivedCount";
            lblArchivedCount.Size = new Size(27, 34);
            lblArchivedCount.TabIndex = 1;
            lblArchivedCount.Text = "0";
            // 
            // cardFound
            // 
            cardFound.BackColor = Color.FromArgb(232, 165, 152);
            cardFound.Controls.Add(label4);
            cardFound.Controls.Add(lblAdminFound);
            cardFound.Dock = DockStyle.Fill;
            cardFound.Location = new Point(339, 3);
            cardFound.Name = "cardFound";
            cardFound.Size = new Size(162, 98);
            cardFound.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Letters for Learners", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(122, 78, 0);
            label4.Location = new Point(36, 15);
            label4.Name = "label4";
            label4.Size = new Size(89, 17);
            label4.TabIndex = 3;
            label4.Text = "Found Items";
            // 
            // lblAdminFound
            // 
            lblAdminFound.AutoSize = true;
            lblAdminFound.Font = new Font("Kermit", 15.7499981F, FontStyle.Bold);
            lblAdminFound.ForeColor = Color.FromArgb(74, 14, 26);
            lblAdminFound.Location = new Point(62, 32);
            lblAdminFound.Name = "lblAdminFound";
            lblAdminFound.Size = new Size(27, 34);
            lblAdminFound.TabIndex = 1;
            lblAdminFound.Text = "0";
            // 
            // cardLost
            // 
            cardLost.BackColor = Color.FromArgb(247, 214, 193);
            cardLost.Controls.Add(label5);
            cardLost.Controls.Add(lblAdminLost);
            cardLost.Dock = DockStyle.Fill;
            cardLost.Location = new Point(171, 3);
            cardLost.Name = "cardLost";
            cardLost.Size = new Size(162, 98);
            cardLost.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Letters for Learners", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(122, 78, 0);
            label5.Location = new Point(41, 15);
            label5.Name = "label5";
            label5.Size = new Size(77, 17);
            label5.TabIndex = 3;
            label5.Text = "Lost Items";
            // 
            // lblAdminLost
            // 
            lblAdminLost.AutoSize = true;
            lblAdminLost.Font = new Font("Kermit", 15.7499981F, FontStyle.Bold);
            lblAdminLost.ForeColor = Color.FromArgb(74, 14, 26);
            lblAdminLost.Location = new Point(67, 32);
            lblAdminLost.Name = "lblAdminLost";
            lblAdminLost.Size = new Size(27, 34);
            lblAdminLost.TabIndex = 1;
            lblAdminLost.Text = "0";
            // 
            // cardTotal
            // 
            cardTotal.BackColor = Color.FromArgb(247, 237, 224);
            cardTotal.Controls.Add(label7);
            cardTotal.Controls.Add(lblTotalCount);
            cardTotal.Dock = DockStyle.Fill;
            cardTotal.Location = new Point(3, 3);
            cardTotal.Name = "cardTotal";
            cardTotal.Size = new Size(162, 98);
            cardTotal.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Letters for Learners", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(122, 78, 0);
            label7.Location = new Point(41, 15);
            label7.Name = "label7";
            label7.Size = new Size(81, 17);
            label7.TabIndex = 3;
            label7.Text = "Total Items";
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Kermit", 15.7499981F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.FromArgb(74, 14, 26);
            lblTotalCount.Location = new Point(64, 32);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(27, 34);
            lblTotalCount.TabIndex = 0;
            lblTotalCount.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvAdminActivity);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(19, 429);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1009, 281);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recent System Activity";
            // 
            // dgvAdminActivity
            // 
            dgvAdminActivity.AllowUserToAddRows = false;
            dgvAdminActivity.AllowUserToDeleteRows = false;
            dgvAdminActivity.AllowUserToResizeColumns = false;
            dgvAdminActivity.AllowUserToResizeRows = false;
            dgvAdminActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdminActivity.BackgroundColor = Color.Bisque;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Bisque;
            dataGridViewCellStyle1.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(74, 14, 26);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(245, 216, 120);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(74, 14, 26);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAdminActivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAdminActivity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminActivity.Columns.AddRange(new DataGridViewColumn[] { colAdminActivity, colAdminUser, colAdminDate, colAdminStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Bisque;
            dataGridViewCellStyle2.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(74, 14, 26);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(245, 216, 120);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(74, 14, 26);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAdminActivity.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAdminActivity.Dock = DockStyle.Fill;
            dgvAdminActivity.EnableHeadersVisualStyles = false;
            dgvAdminActivity.GridColor = Color.FromArgb(217, 175, 134);
            dgvAdminActivity.Location = new Point(3, 25);
            dgvAdminActivity.Name = "dgvAdminActivity";
            dgvAdminActivity.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Bisque;
            dataGridViewCellStyle3.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(74, 14, 26);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(245, 216, 120);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(74, 14, 26);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvAdminActivity.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvAdminActivity.RowHeadersVisible = false;
            dgvAdminActivity.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdminActivity.Size = new Size(1003, 253);
            dgvAdminActivity.TabIndex = 0;
            // 
            // colAdminActivity
            // 
            colAdminActivity.HeaderText = "Activity";
            colAdminActivity.Name = "colAdminActivity";
            colAdminActivity.ReadOnly = true;
            // 
            // colAdminUser
            // 
            colAdminUser.HeaderText = "User";
            colAdminUser.Name = "colAdminUser";
            colAdminUser.ReadOnly = true;
            // 
            // colAdminDate
            // 
            colAdminDate.HeaderText = "Date";
            colAdminDate.Name = "colAdminDate";
            colAdminDate.ReadOnly = true;
            // 
            // colAdminStatus
            // 
            colAdminStatus.HeaderText = "Status";
            colAdminStatus.Name = "colAdminStatus";
            colAdminStatus.ReadOnly = true;
            // 
            // panelChart
            // 
            panelChart.Dock = DockStyle.Fill;
            panelChart.Location = new Point(19, 209);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(1009, 214);
            panelChart.TabIndex = 3;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 0;
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 175, 134);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(tlpMain);
            DoubleBuffered = true;
            Name = "AdminHome";
            Size = new Size(1047, 729);
            tlpMain.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            tlpAdminCards.ResumeLayout(false);
            cardApproved.ResumeLayout(false);
            cardApproved.PerformLayout();
            cardPending.ResumeLayout(false);
            cardPending.PerformLayout();
            cardArchived.ResumeLayout(false);
            cardArchived.PerformLayout();
            cardFound.ResumeLayout(false);
            cardFound.PerformLayout();
            cardLost.ResumeLayout(false);
            cardLost.PerformLayout();
            cardTotal.ResumeLayout(false);
            cardTotal.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAdminActivity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Panel panelHeader;
        private Label lblAdminSub;
        private Label lblAdminTitle;
        private TableLayoutPanel tlpAdminCards;
        private Panel cardApproved;
        private Label lblAdminApproved;
        private Panel cardPending;
        private Label lblPendingCount;
        private Panel cardArchived;
        private Label lblArchivedCount;
        private Panel cardFound;
        private Label lblAdminFound;
        private Panel cardLost;
        private Label lblAdminLost;
        private Panel cardTotal;
        private Label lblTotalCount;
        private GroupBox groupBox1;
        private DataGridView dgvAdminActivity;
        private DataGridViewTextBoxColumn colAdminActivity;
        private DataGridViewTextBoxColumn colAdminUser;
        private DataGridViewTextBoxColumn colAdminDate;
        private DataGridViewTextBoxColumn colAdminStatus;
        private Panel panelChart;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
