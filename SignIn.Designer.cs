namespace _DRAFT__OOP_2_FINAL_PROJECT
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            lblAdminNote = new Label();
            splitContainer1 = new SplitContainer();
            panelVerify = new Panel();
            panelCreate = new Panel();
            lblCreateError = new Label();
            btnCancel2 = new Button();
            btnCreateAccount = new Button();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtNewPassword = new TextBox();
            lblPassword = new Label();
            label6 = new Label();
            label5 = new Label();
            txtNewUsername = new TextBox();
            lblUsername = new Label();
            lblVerifiedName = new Label();
            txtIDNumber = new TextBox();
            lblError = new Label();
            txtMiddleName = new TextBox();
            lblMiddleName = new Label();
            label2 = new Label();
            label1 = new Label();
            lblIDNumber = new Label();
            btnVerify = new Button();
            btnCancel = new Button();
            lblFirstName = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelVerify.SuspendLayout();
            panelCreate.SuspendLayout();
            SuspendLayout();
            // 
            // lblAdminNote
            // 
            lblAdminNote.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblAdminNote.AutoSize = true;
            lblAdminNote.BackColor = Color.Transparent;
            lblAdminNote.Font = new Font("Super Starfish", 14.25F);
            lblAdminNote.Location = new Point(12, 216);
            lblAdminNote.Name = "lblAdminNote";
            lblAdminNote.Size = new Size(0, 21);
            lblAdminNote.TabIndex = 21;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel1.BackgroundImage");
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(panelVerify);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel2.BackgroundImage");
            splitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Size = new Size(884, 461);
            splitContainer1.SplitterDistance = 614;
            splitContainer1.TabIndex = 26;
            // 
            // panelVerify
            // 
            panelVerify.BackColor = Color.Transparent;
            panelVerify.Controls.Add(panelCreate);
            panelVerify.Controls.Add(txtIDNumber);
            panelVerify.Controls.Add(lblError);
            panelVerify.Controls.Add(txtMiddleName);
            panelVerify.Controls.Add(lblMiddleName);
            panelVerify.Controls.Add(label2);
            panelVerify.Controls.Add(label1);
            panelVerify.Controls.Add(lblIDNumber);
            panelVerify.Controls.Add(btnVerify);
            panelVerify.Controls.Add(btnCancel);
            panelVerify.Controls.Add(lblFirstName);
            panelVerify.Controls.Add(txtLastName);
            panelVerify.Controls.Add(lblLastName);
            panelVerify.Controls.Add(txtFirstName);
            panelVerify.Dock = DockStyle.Fill;
            panelVerify.Location = new Point(0, 0);
            panelVerify.Name = "panelVerify";
            panelVerify.Size = new Size(614, 461);
            panelVerify.TabIndex = 0;
            // 
            // panelCreate
            // 
            panelCreate.Controls.Add(lblCreateError);
            panelCreate.Controls.Add(btnCancel2);
            panelCreate.Controls.Add(btnCreateAccount);
            panelCreate.Controls.Add(txtConfirmPassword);
            panelCreate.Controls.Add(lblConfirmPassword);
            panelCreate.Controls.Add(txtNewPassword);
            panelCreate.Controls.Add(lblPassword);
            panelCreate.Controls.Add(label6);
            panelCreate.Controls.Add(label5);
            panelCreate.Controls.Add(txtNewUsername);
            panelCreate.Controls.Add(lblUsername);
            panelCreate.Controls.Add(lblVerifiedName);
            panelCreate.Dock = DockStyle.Fill;
            panelCreate.Location = new Point(0, 0);
            panelCreate.Name = "panelCreate";
            panelCreate.Size = new Size(614, 461);
            panelCreate.TabIndex = 39;
            panelCreate.Visible = false;
            // 
            // lblCreateError
            // 
            lblCreateError.AutoSize = true;
            lblCreateError.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblCreateError.ForeColor = Color.Red;
            lblCreateError.Location = new Point(17, 331);
            lblCreateError.Name = "lblCreateError";
            lblCreateError.Size = new Size(56, 21);
            lblCreateError.TabIndex = 44;
            lblCreateError.Text = "(error)";
            lblCreateError.Visible = false;
            // 
            // btnCancel2
            // 
            btnCancel2.BackColor = Color.FromArgb(250, 240, 192);
            btnCancel2.FlatStyle = FlatStyle.Flat;
            btnCancel2.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            btnCancel2.ForeColor = Color.FromArgb(92, 58, 0);
            btnCancel2.Location = new Point(294, 387);
            btnCancel2.Name = "btnCancel2";
            btnCancel2.Size = new Size(269, 34);
            btnCancel2.TabIndex = 43;
            btnCancel2.Text = "← Back";
            btnCancel2.UseVisualStyleBackColor = false;
            btnCancel2.Click += btnBack_Click;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.FromArgb(107, 21, 38);
            btnCreateAccount.FlatStyle = FlatStyle.Flat;
            btnCreateAccount.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            btnCreateAccount.ForeColor = Color.FromArgb(245, 216, 120);
            btnCreateAccount.Location = new Point(17, 387);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(269, 34);
            btnCreateAccount.TabIndex = 42;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(250, 240, 192);
            txtConfirmPassword.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            txtConfirmPassword.Location = new Point(16, 289);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Re-enter password";
            txtConfirmPassword.Size = new Size(272, 27);
            txtConfirmPassword.TabIndex = 41;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.FromArgb(74, 14, 26);
            lblConfirmPassword.Location = new Point(15, 260);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(141, 21);
            lblConfirmPassword.TabIndex = 40;
            lblConfirmPassword.Text = "Confirm password:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.FromArgb(250, 240, 192);
            txtNewPassword.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            txtNewPassword.Location = new Point(17, 212);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PlaceholderText = "At least 6 characters";
            txtNewPassword.Size = new Size(272, 27);
            txtNewPassword.TabIndex = 39;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(74, 14, 26);
            lblPassword.Location = new Point(16, 183);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(81, 21);
            lblPassword.TabIndex = 38;
            lblPassword.Text = "Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(92, 58, 0);
            label6.Location = new Point(12, 47);
            label6.Name = "label6";
            label6.Size = new Size(399, 21);
            label6.TabIndex = 37;
            label6.Text = "Set your credentials, set your username and password.\r\n";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Kermit", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(74, 14, 26);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(280, 47);
            label5.TabIndex = 36;
            label5.Text = "Create an account";
            // 
            // txtNewUsername
            // 
            txtNewUsername.BackColor = Color.FromArgb(250, 240, 192);
            txtNewUsername.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            txtNewUsername.Location = new Point(16, 135);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.PlaceholderText = "Choose a username";
            txtNewUsername.Size = new Size(272, 27);
            txtNewUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(74, 14, 26);
            lblUsername.Location = new Point(15, 106);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(84, 21);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblVerifiedName
            // 
            lblVerifiedName.AutoSize = true;
            lblVerifiedName.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblVerifiedName.ForeColor = Color.Green;
            lblVerifiedName.Location = new Point(13, 73);
            lblVerifiedName.Name = "lblVerifiedName";
            lblVerifiedName.Size = new Size(114, 21);
            lblVerifiedName.TabIndex = 0;
            lblVerifiedName.Text = "(label verified)";
            // 
            // txtIDNumber
            // 
            txtIDNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtIDNumber.BackColor = Color.FromArgb(250, 240, 192);
            txtIDNumber.BorderStyle = BorderStyle.FixedSingle;
            txtIDNumber.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            txtIDNumber.ForeColor = Color.Black;
            txtIDNumber.Location = new Point(15, 105);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.PlaceholderText = " \U0001faaa Enter ID  Number";
            txtIDNumber.Size = new Size(359, 27);
            txtIDNumber.TabIndex = 29;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblError.AutoSize = true;
            lblError.BackColor = Color.Transparent;
            lblError.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(46, 310);
            lblError.MaximumSize = new Size(249, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 21);
            lblError.TabIndex = 34;
            lblError.Visible = false;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMiddleName.BackColor = Color.FromArgb(250, 240, 192);
            txtMiddleName.BorderStyle = BorderStyle.FixedSingle;
            txtMiddleName.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            txtMiddleName.Location = new Point(13, 227);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.PlaceholderText = " 🐱 Enter middle name";
            txtMiddleName.Size = new Size(359, 27);
            txtMiddleName.TabIndex = 38;
            // 
            // lblMiddleName
            // 
            lblMiddleName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblMiddleName.AutoSize = true;
            lblMiddleName.BackColor = Color.Transparent;
            lblMiddleName.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblMiddleName.Location = new Point(13, 203);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(105, 21);
            lblMiddleName.TabIndex = 37;
            lblMiddleName.Text = "Middle Name:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            label2.Location = new Point(15, 57);
            label2.Name = "label2";
            label2.Size = new Size(243, 21);
            label2.TabIndex = 36;
            label2.Text = "Fill in your details to get started";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Kermit", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 10);
            label1.Name = "label1";
            label1.Size = new Size(280, 47);
            label1.TabIndex = 35;
            label1.Text = "Create an account";
            // 
            // lblIDNumber
            // 
            lblIDNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblIDNumber.AutoSize = true;
            lblIDNumber.BackColor = Color.Transparent;
            lblIDNumber.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblIDNumber.Location = new Point(15, 81);
            lblIDNumber.Name = "lblIDNumber";
            lblIDNumber.Size = new Size(89, 21);
            lblIDNumber.TabIndex = 27;
            lblIDNumber.Text = "ID Number";
            // 
            // btnVerify
            // 
            btnVerify.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnVerify.BackColor = Color.FromArgb(107, 21, 38);
            btnVerify.FlatStyle = FlatStyle.Flat;
            btnVerify.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            btnVerify.ForeColor = Color.FromArgb(245, 216, 120);
            btnVerify.Location = new Point(15, 416);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(273, 34);
            btnVerify.TabIndex = 30;
            btnVerify.Text = "Verify Record";
            btnVerify.UseVisualStyleBackColor = false;
            btnVerify.Click += btnVerify_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(250, 240, 192);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(92, 58, 0);
            btnCancel.Location = new Point(335, 416);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(273, 34);
            btnCancel.TabIndex = 33;
            btnCancel.Text = "Back";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblFirstName.Location = new Point(13, 142);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(91, 21);
            lblFirstName.TabIndex = 28;
            lblFirstName.Text = "First Name:";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.BackColor = Color.FromArgb(250, 240, 192);
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            txtLastName.Location = new Point(13, 288);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = " 🐱 Enter last name";
            txtLastName.Size = new Size(359, 27);
            txtLastName.TabIndex = 31;
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblLastName.Location = new Point(13, 264);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(88, 21);
            lblLastName.TabIndex = 32;
            lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.BackColor = Color.FromArgb(250, 240, 192);
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            txtFirstName.Location = new Point(13, 166);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = " 🐱 Enter first name";
            txtFirstName.Size = new Size(359, 27);
            txtFirstName.TabIndex = 26;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 461);
            Controls.Add(splitContainer1);
            Controls.Add(lblAdminNote);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Retriever";
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelVerify.ResumeLayout(false);
            panelVerify.PerformLayout();
            panelCreate.ResumeLayout(false);
            panelCreate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAdminNote;
        private SplitContainer splitContainer1;
        private Panel panelVerify;
        private Panel panelCreate;
        private Label lblUsername;
        private Label lblVerifiedName;
        private TextBox txtIDNumber;
        private Label lblError;
        private TextBox txtMiddleName;
        private Label lblMiddleName;
        private Label label2;
        private Label label1;
        private Label lblIDNumber;
        private Button btnVerify;
        private Button btnCancel;
        private Label lblFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private TextBox txtNewUsername;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassword;
        private TextBox txtNewPassword;
        private Label lblPassword;
        private Label label6;
        private Label label5;
        private Button btnCancel2;
        private Button btnCreateAccount;
        private Label lblCreateError;
    }
}