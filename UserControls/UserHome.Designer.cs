namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    partial class UserHome
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tlpMain = new TableLayoutPanel();
            panelHeader = new Panel();
            lblWelcomeSub = new Label();
            lblWelcome = new Label();
            panelCards = new Panel();
            tlpCards = new TableLayoutPanel();
            cardLost = new Panel();
            label1 = new Label();
            lblLostCount = new Label();
            cardFound = new Panel();
            label2 = new Label();
            lblFoundCount = new Label();
            cardRequests = new Panel();
            label3 = new Label();
            lblRequestCount = new Label();
            cardApproved = new Panel();
            label4 = new Label();
            lblApprovedCount = new Label();
            panelChart = new Panel();
            groupBox1 = new GroupBox();
            dgvActivity = new DataGridView();
            colActivity = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            tlpMain.SuspendLayout();
            panelHeader.SuspendLayout();
            panelCards.SuspendLayout();
            tlpCards.SuspendLayout();
            cardLost.SuspendLayout();
            cardFound.SuspendLayout();
            cardRequests.SuspendLayout();
            cardApproved.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivity).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.BackColor = Color.Transparent;
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(panelHeader, 0, 0);
            tlpMain.Controls.Add(panelCards, 0, 1);
            tlpMain.Controls.Add(panelChart, 0, 2);
            tlpMain.Controls.Add(groupBox1, 0, 3);
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
            panelHeader.Controls.Add(lblWelcomeSub);
            panelHeader.Controls.Add(lblWelcome);
            panelHeader.Dock = DockStyle.Fill;
            panelHeader.Location = new Point(19, 19);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1009, 74);
            panelHeader.TabIndex = 0;
            // 
            // lblWelcomeSub
            // 
            lblWelcomeSub.AutoSize = true;
            lblWelcomeSub.Font = new Font("Letters for Learners", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeSub.ForeColor = Color.White;
            lblWelcomeSub.Location = new Point(6, 46);
            lblWelcomeSub.Name = "lblWelcomeSub";
            lblWelcomeSub.Size = new Size(0, 17);
            lblWelcomeSub.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Dock = DockStyle.Top;
            lblWelcome.Font = new Font("Kermit", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(74, 14, 26);
            lblWelcome.Location = new Point(0, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 45);
            lblWelcome.TabIndex = 0;
            // 
            // panelCards
            // 
            panelCards.Controls.Add(tlpCards);
            panelCards.Dock = DockStyle.Fill;
            panelCards.Location = new Point(19, 99);
            panelCards.Name = "panelCards";
            panelCards.Size = new Size(1009, 104);
            panelCards.TabIndex = 1;
            // 
            // tlpCards
            // 
            tlpCards.ColumnCount = 4;
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.Controls.Add(cardLost, 0, 0);
            tlpCards.Controls.Add(cardFound, 1, 0);
            tlpCards.Controls.Add(cardRequests, 2, 0);
            tlpCards.Controls.Add(cardApproved, 3, 0);
            tlpCards.Dock = DockStyle.Fill;
            tlpCards.Location = new Point(0, 0);
            tlpCards.Name = "tlpCards";
            tlpCards.RowCount = 1;
            tlpCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCards.Size = new Size(1009, 104);
            tlpCards.TabIndex = 0;
            // 
            // cardLost
            // 
            cardLost.BackColor = Color.FromArgb(230, 201, 122);
            cardLost.Controls.Add(label1);
            cardLost.Controls.Add(lblLostCount);
            cardLost.Dock = DockStyle.Fill;
            cardLost.Location = new Point(3, 3);
            cardLost.Name = "cardLost";
            cardLost.Size = new Size(246, 98);
            cardLost.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Letters for Learners", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(122, 78, 0);
            label1.Location = new Point(45, 15);
            label1.Name = "label1";
            label1.Size = new Size(110, 17);
            label1.TabIndex = 1;
            label1.Text = "My Lost Reports";
            // 
            // lblLostCount
            // 
            lblLostCount.AutoSize = true;
            lblLostCount.Font = new Font("Kermit", 15.75F, FontStyle.Bold);
            lblLostCount.ForeColor = Color.FromArgb(74, 14, 26);
            lblLostCount.Location = new Point(83, 40);
            lblLostCount.Name = "lblLostCount";
            lblLostCount.Size = new Size(27, 34);
            lblLostCount.TabIndex = 0;
            lblLostCount.Text = "0";
            // 
            // cardFound
            // 
            cardFound.BackColor = Color.FromArgb(230, 201, 122);
            cardFound.Controls.Add(label2);
            cardFound.Controls.Add(lblFoundCount);
            cardFound.Dock = DockStyle.Fill;
            cardFound.Location = new Point(255, 3);
            cardFound.Name = "cardFound";
            cardFound.Size = new Size(246, 98);
            cardFound.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Letters for Learners", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(122, 78, 0);
            label2.Location = new Point(45, 15);
            label2.Name = "label2";
            label2.Size = new Size(122, 17);
            label2.TabIndex = 1;
            label2.Text = "My Found Reports";
            // 
            // lblFoundCount
            // 
            lblFoundCount.AutoSize = true;
            lblFoundCount.Font = new Font("Kermit", 15.75F, FontStyle.Bold);
            lblFoundCount.ForeColor = Color.FromArgb(74, 14, 26);
            lblFoundCount.Location = new Point(89, 40);
            lblFoundCount.Name = "lblFoundCount";
            lblFoundCount.Size = new Size(27, 34);
            lblFoundCount.TabIndex = 0;
            lblFoundCount.Text = "0";
            // 
            // cardRequests
            // 
            cardRequests.BackColor = Color.FromArgb(230, 201, 122);
            cardRequests.Controls.Add(label3);
            cardRequests.Controls.Add(lblRequestCount);
            cardRequests.Dock = DockStyle.Fill;
            cardRequests.Location = new Point(507, 3);
            cardRequests.Name = "cardRequests";
            cardRequests.Size = new Size(246, 98);
            cardRequests.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Letters for Learners", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(122, 78, 0);
            label3.Location = new Point(66, 15);
            label3.Name = "label3";
            label3.Size = new Size(106, 17);
            label3.TabIndex = 1;
            label3.Text = "Pending Claims";
            // 
            // lblRequestCount
            // 
            lblRequestCount.AutoSize = true;
            lblRequestCount.Font = new Font("Kermit", 15.75F, FontStyle.Bold);
            lblRequestCount.ForeColor = Color.FromArgb(74, 14, 26);
            lblRequestCount.Location = new Point(104, 40);
            lblRequestCount.Name = "lblRequestCount";
            lblRequestCount.Size = new Size(27, 34);
            lblRequestCount.TabIndex = 0;
            lblRequestCount.Text = "0";
            // 
            // cardApproved
            // 
            cardApproved.BackColor = Color.FromArgb(230, 201, 122);
            cardApproved.Controls.Add(label4);
            cardApproved.Controls.Add(lblApprovedCount);
            cardApproved.Dock = DockStyle.Fill;
            cardApproved.Location = new Point(759, 3);
            cardApproved.Name = "cardApproved";
            cardApproved.Size = new Size(247, 98);
            cardApproved.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Letters for Learners", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(122, 78, 0);
            label4.Location = new Point(70, 15);
            label4.Name = "label4";
            label4.Size = new Size(130, 17);
            label4.TabIndex = 1;
            label4.Text = "Confirmed Matches";
            // 
            // lblApprovedCount
            // 
            lblApprovedCount.AutoSize = true;
            lblApprovedCount.Font = new Font("Kermit", 15.75F, FontStyle.Bold);
            lblApprovedCount.ForeColor = Color.FromArgb(74, 14, 26);
            lblApprovedCount.Location = new Point(112, 40);
            lblApprovedCount.Name = "lblApprovedCount";
            lblApprovedCount.Size = new Size(27, 34);
            lblApprovedCount.TabIndex = 0;
            lblApprovedCount.Text = "0";
            // 
            // panelChart
            // 
            panelChart.Dock = DockStyle.Fill;
            panelChart.Location = new Point(19, 209);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(1009, 214);
            panelChart.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvActivity);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(19, 429);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1009, 281);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "My Recent Activity";
            // 
            // dgvActivity
            // 
            dgvActivity.AllowUserToAddRows = false;
            dgvActivity.AllowUserToDeleteRows = false;
            dgvActivity.AllowUserToResizeColumns = false;
            dgvActivity.AllowUserToResizeRows = false;
            dgvActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActivity.BackgroundColor = Color.Bisque;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Bisque;
            dataGridViewCellStyle1.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(74, 14, 26);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(245, 216, 120);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(74, 14, 26);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvActivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvActivity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivity.Columns.AddRange(new DataGridViewColumn[] { colActivity, colDate, colStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Wheat;
            dataGridViewCellStyle2.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(74, 14, 26);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(245, 216, 120);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(74, 14, 26);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvActivity.DefaultCellStyle = dataGridViewCellStyle2;
            dgvActivity.Dock = DockStyle.Fill;
            dgvActivity.EnableHeadersVisualStyles = false;
            dgvActivity.GridColor = Color.FromArgb(217, 175, 134);
            dgvActivity.Location = new Point(3, 23);
            dgvActivity.Name = "dgvActivity";
            dgvActivity.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(196, 154, 106);
            dataGridViewCellStyle3.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(74, 14, 26);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(245, 216, 120);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(74, 14, 26);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvActivity.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvActivity.RowHeadersVisible = false;
            dgvActivity.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActivity.Size = new Size(1003, 255);
            dgvActivity.TabIndex = 0;
            // 
            // colActivity
            // 
            colActivity.HeaderText = "Activity";
            colActivity.Name = "colActivity";
            colActivity.ReadOnly = true;
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
            // UserHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 175, 134);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(tlpMain);
            DoubleBuffered = true;
            Name = "UserHome";
            Size = new Size(1047, 729);
            tlpMain.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelCards.ResumeLayout(false);
            tlpCards.ResumeLayout(false);
            cardLost.ResumeLayout(false);
            cardLost.PerformLayout();
            cardFound.ResumeLayout(false);
            cardFound.PerformLayout();
            cardRequests.ResumeLayout(false);
            cardRequests.PerformLayout();
            cardApproved.ResumeLayout(false);
            cardApproved.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvActivity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Panel panelHeader;
        private Label lblWelcomeSub;
        private Label lblWelcome;
        private Panel panelCards;
        private TableLayoutPanel tlpCards;
        private Panel cardLost;
        private Label label1;
        private Label lblLostCount;
        private Panel cardFound;
        private Label label2;
        private Label lblFoundCount;
        private Panel cardRequests;
        private Label label3;
        private Label lblRequestCount;
        private Panel cardApproved;
        private Label label4;
        private Label lblApprovedCount;
        private Panel panelChart;
        private GroupBox groupBox1;
        private DataGridView dgvActivity;
        private DataGridViewTextBoxColumn colActivity;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colStatus;
    }
}