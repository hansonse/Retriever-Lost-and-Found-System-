namespace _DRAFT__OOP_2_FINAL_PROJECT
{
    partial class Retriever
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Retriever));
            accountMenu = new ContextMenuStrip(components);
            menuProfile = new ToolStripMenuItem();
            menuChangePass = new ToolStripMenuItem();
            menuLogOut = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            btnLogOut = new Button();
            btnInventory = new Button();
            btnHome = new Button();
            btnManageRequests = new Button();
            btnManagReports = new Button();
            btnPhotoGallery = new Button();
            btnLogo = new Button();
            accountMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // accountMenu
            // 
            accountMenu.Items.AddRange(new ToolStripItem[] { menuProfile, menuChangePass, menuLogOut });
            accountMenu.Name = "contextMenuStrip1";
            accountMenu.Size = new Size(169, 70);
            // 
            // menuProfile
            // 
            menuProfile.Name = "menuProfile";
            menuProfile.Size = new Size(168, 22);
            menuProfile.Text = "View Profile";
            // 
            // menuChangePass
            // 
            menuChangePass.Name = "menuChangePass";
            menuChangePass.Size = new Size(168, 22);
            menuChangePass.Text = "Change Password";
            // 
            // menuLogOut
            // 
            menuLogOut.Name = "menuLogOut";
            menuLogOut.Size = new Size(168, 22);
            menuLogOut.Text = "Log out";
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
            splitContainer1.Panel1.Controls.Add(btnManagReports);
            splitContainer1.Panel1.Controls.Add(btnManageRequests);
            splitContainer1.Panel1.Controls.Add(btnLogOut);
            splitContainer1.Panel1.Controls.Add(btnInventory);
            splitContainer1.Panel1.Controls.Add(btnHome);
            splitContainer1.Panel1.Controls.Add(btnPhotoGallery);
            splitContainer1.Panel1.Controls.Add(btnLogo);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel2.BackgroundImage");
            splitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Size = new Size(1350, 729);
            splitContainer1.SplitterDistance = 291;
            splitContainer1.TabIndex = 4;
            // 
            // btnLogOut
            // 
            btnLogOut.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogOut.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(42, 670);
            btnLogOut.Margin = new Padding(15, 8, 15, 8);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(199, 32);
            btnLogOut.TabIndex = 29;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnInventory
            // 
            btnInventory.BackgroundImageLayout = ImageLayout.Stretch;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(42, 388);
            btnInventory.Margin = new Padding(15, 8, 15, 8);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(199, 32);
            btnInventory.TabIndex = 28;
            btnInventory.Text = "📦 Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnPhotoGallery
            // 
            btnPhotoGallery.BackgroundImageLayout = ImageLayout.Stretch;
            btnPhotoGallery.FlatStyle = FlatStyle.Flat;
            btnPhotoGallery.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPhotoGallery.ForeColor = Color.White;
            btnPhotoGallery.Location = new Point(42, 467);
            btnPhotoGallery.Margin = new Padding(15, 8, 15, 8);
            btnPhotoGallery.Name = "btnPhotoGallery";
            btnPhotoGallery.Size = new Size(199, 32);
            btnPhotoGallery.TabIndex = 30;
            btnPhotoGallery.Text = "🖼 Photo Gallery";
            btnPhotoGallery.UseVisualStyleBackColor = true;
            btnPhotoGallery.Click += btnPhotoGallery_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.BackgroundImageLayout = ImageLayout.Stretch;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(42, 151);
            btnHome.Margin = new Padding(15, 13, 15, 13);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(199, 32);
            btnHome.TabIndex = 26;
            btnHome.Text = "🏠 Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnManageRequests
            // 
            btnManageRequests.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnManageRequests.BackgroundImageLayout = ImageLayout.Stretch;
            btnManageRequests.FlatStyle = FlatStyle.Flat;
            btnManageRequests.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageRequests.ForeColor = Color.White;
            btnManageRequests.Location = new Point(42, 309);
            btnManageRequests.Margin = new Padding(15, 13, 15, 13);
            btnManageRequests.Name = "btnManageRequests";
            btnManageRequests.Size = new Size(199, 32);
            btnManageRequests.TabIndex = 20;
            btnManageRequests.Text = "📑 Manage Requests";
            btnManageRequests.UseVisualStyleBackColor = true;
            btnManageRequests.Click += btnManageRequests_Click;
            // 
            // btnManagReports
            // 
            btnManagReports.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnManagReports.BackColor = Color.Transparent;
            btnManagReports.BackgroundImageLayout = ImageLayout.Stretch;
            btnManagReports.FlatStyle = FlatStyle.Flat;
            btnManagReports.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManagReports.ForeColor = Color.White;
            btnManagReports.Location = new Point(42, 230);
            btnManagReports.Margin = new Padding(15, 13, 15, 13);
            btnManagReports.Name = "btnManagReports";
            btnManagReports.Size = new Size(199, 32);
            btnManagReports.TabIndex = 19;
            btnManagReports.Text = "🗂 Manage Reports";
            btnManagReports.UseVisualStyleBackColor = false;
            btnManagReports.Click += btnManagReports_Click;
            // 
            // btnLogo
            // 
            btnLogo.BackColor = Color.Transparent;
            btnLogo.BackgroundImage = (Image)resources.GetObject("btnLogo.BackgroundImage");
            btnLogo.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogo.Dock = DockStyle.Top;
            btnLogo.FlatAppearance.BorderSize = 0;
            btnLogo.FlatStyle = FlatStyle.Flat;
            btnLogo.ForeColor = Color.Transparent;
            btnLogo.Location = new Point(0, 0);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(291, 87);
            btnLogo.TabIndex = 18;
            btnLogo.UseVisualStyleBackColor = false;
            // 
            // Retriever
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Retriever";
            Text = "Retriever Admin";
            WindowState = FormWindowState.Maximized;
            accountMenu.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip accountMenu;
        private ToolStripMenuItem menuProfile;
        private ToolStripMenuItem menuChangePass;
        private ToolStripMenuItem menuLogOut;
        private SplitContainer splitContainer1;
        private Button btnLogo;
        private Button btnManageRequests;
        private Button btnManagReports;
        private Button btnHome;
        private Button btnInventory;
        private Button btnLogOut;
        private Button btnPhotoGallery;
    }
}