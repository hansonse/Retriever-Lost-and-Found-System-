namespace _DRAFT__OOP_2_FINAL_PROJECT
{
    partial class UserMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMenu));
            splitContainer1 = new SplitContainer();
            btnLogOut = new Button();
            btnMyMatches = new Button();
            btnInventory = new Button();
            btnRequestClaim = new Button();
            btnReportLost = new Button();
            btnHome = new Button();
            btnReportFound = new Button();
            btnLogo = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(107, 21, 38);
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(btnLogOut);
            splitContainer1.Panel1.Controls.Add(btnMyMatches);
            splitContainer1.Panel1.Controls.Add(btnInventory);
            splitContainer1.Panel1.Controls.Add(btnRequestClaim);
            splitContainer1.Panel1.Controls.Add(btnReportLost);
            splitContainer1.Panel1.Controls.Add(btnHome);
            splitContainer1.Panel1.Controls.Add(btnReportFound);
            splitContainer1.Panel1.Controls.Add(btnLogo);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel2.BackgroundImage");
            splitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Size = new Size(1350, 729);
            splitContainer1.SplitterDistance = 299;
            splitContainer1.TabIndex = 2;
            // 
            // btnLogOut
            // 
            btnLogOut.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogOut.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(48, 667);
            btnLogOut.Margin = new Padding(15, 8, 15, 8);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(199, 32);
            btnLogOut.TabIndex = 28;
            btnLogOut.Text = "Log out";
            toolTip1.SetToolTip(btnLogOut, "Log out of your account");
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnMyMatches
            // 
            btnMyMatches.BackgroundImageLayout = ImageLayout.Stretch;
            btnMyMatches.FlatStyle = FlatStyle.Flat;
            btnMyMatches.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMyMatches.ForeColor = Color.White;
            btnMyMatches.Location = new Point(48, 412);
            btnMyMatches.Margin = new Padding(15, 8, 15, 8);
            btnMyMatches.Name = "btnMyMatches";
            btnMyMatches.Size = new Size(199, 32);
            btnMyMatches.TabIndex = 29;
            btnMyMatches.Text = "🔗 My Matches";
            toolTip1.SetToolTip(btnMyMatches, "View items matched to your lost reports");
            btnMyMatches.UseVisualStyleBackColor = true;
            btnMyMatches.Click += btnMyMatches_Click;
            // 
            // btnInventory
            // 
            btnInventory.BackgroundImageLayout = ImageLayout.Stretch;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(48, 477);
            btnInventory.Margin = new Padding(15, 8, 15, 8);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(199, 32);
            btnInventory.TabIndex = 27;
            btnInventory.Text = "📦 Browse Items";
            toolTip1.SetToolTip(btnInventory, "Browse all lost and found items");
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnRequestClaim
            // 
            btnRequestClaim.BackgroundImageLayout = ImageLayout.Stretch;
            btnRequestClaim.FlatStyle = FlatStyle.Flat;
            btnRequestClaim.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRequestClaim.ForeColor = Color.White;
            btnRequestClaim.Location = new Point(48, 347);
            btnRequestClaim.Margin = new Padding(15, 13, 15, 13);
            btnRequestClaim.Name = "btnRequestClaim";
            btnRequestClaim.Size = new Size(199, 32);
            btnRequestClaim.TabIndex = 26;
            btnRequestClaim.Text = "𓂃🖊 Request Claim";
            toolTip1.SetToolTip(btnRequestClaim, "View your claim requests, track request status, and check incoming claim notifications");
            btnRequestClaim.UseVisualStyleBackColor = true;
            btnRequestClaim.Click += btnRequestClaim_Click;
            // 
            // btnReportLost
            // 
            btnReportLost.BackColor = Color.Transparent;
            btnReportLost.BackgroundImageLayout = ImageLayout.Stretch;
            btnReportLost.FlatStyle = FlatStyle.Flat;
            btnReportLost.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportLost.ForeColor = Color.White;
            btnReportLost.Location = new Point(48, 282);
            btnReportLost.Margin = new Padding(15, 13, 15, 13);
            btnReportLost.Name = "btnReportLost";
            btnReportLost.Size = new Size(199, 32);
            btnReportLost.TabIndex = 20;
            btnReportLost.Text = "⸮﹖ Report Lost Item";
            toolTip1.SetToolTip(btnReportLost, "Report an item you have found");
            btnReportLost.UseVisualStyleBackColor = false;
            btnReportLost.Click += btnReportLost_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.BackgroundImageLayout = ImageLayout.Stretch;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(48, 152);
            btnHome.Margin = new Padding(15, 13, 15, 13);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(199, 32);
            btnHome.TabIndex = 19;
            btnHome.Text = "🏠 Home";
            toolTip1.SetToolTip(btnHome, "Go to home");
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnReportFound
            // 
            btnReportFound.BackColor = Color.Transparent;
            btnReportFound.BackgroundImageLayout = ImageLayout.Stretch;
            btnReportFound.FlatStyle = FlatStyle.Flat;
            btnReportFound.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportFound.ForeColor = Color.White;
            btnReportFound.Location = new Point(48, 217);
            btnReportFound.Margin = new Padding(15, 13, 15, 13);
            btnReportFound.Name = "btnReportFound";
            btnReportFound.Size = new Size(199, 32);
            btnReportFound.TabIndex = 18;
            btnReportFound.Text = "🔍Report Found Item";
            toolTip1.SetToolTip(btnReportFound, "Report an item you have lost");
            btnReportFound.UseVisualStyleBackColor = false;
            btnReportFound.Click += btnReportFound_Click;
            // 
            // btnLogo
            // 
            btnLogo.BackColor = Color.Transparent;
            btnLogo.BackgroundImage = (Image)resources.GetObject("btnLogo.BackgroundImage");
            btnLogo.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogo.FlatAppearance.BorderSize = 0;
            btnLogo.FlatStyle = FlatStyle.Flat;
            btnLogo.ForeColor = Color.Transparent;
            btnLogo.Location = new Point(0, 8);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(299, 87);
            btnLogo.TabIndex = 17;
            btnLogo.UseVisualStyleBackColor = false;
            btnLogo.Click += btnLogo_Click;
            // 
            // UserMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Retriever";
            WindowState = FormWindowState.Maximized;
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private ToolTip toolTip1;
        private Button btnLogo;
        private Button btnHome;
        private Button btnReportFound;
        private Button btnMyMatches;
        private Button btnInventory;
        private Button btnRequestClaim;
        private Button btnReportLost;
        private Button btnLogOut;
    }
}