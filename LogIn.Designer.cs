namespace _DRAFT__OOP_2_FINAL_PROJECT
{
    partial class LogIn
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            panelLogin = new Panel();
            btnToggle = new Button();
            label2 = new Label();
            lblPassword = new Label();
            lblUsername = new Label();
            pictureBox1 = new PictureBox();
            lblError = new Label();
            label1 = new Label();
            btnSignIn = new Button();
            btnLogIn = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            pictureBox2 = new PictureBox();
            panelAdminCreate = new Panel();
            btnToggleAdminConfirm = new Button();
            btnToggleAdminPass = new Button();
            lblAdminTitle = new Label();
            label4 = new Label();
            label8 = new Label();
            lblAdminFirstName = new Label();
            txtAdminFirstName = new TextBox();
            lblAdminMiddleName = new Label();
            txtAdminMiddleName = new TextBox();
            lblAdminLastName = new Label();
            txtAdminLastName = new TextBox();
            lblAdminEmployeeID = new Label();
            txtAdminEmployeeID = new TextBox();
            lblAdminDept = new Label();
            cmbAdminDept = new ComboBox();
            lblUsernamePreview = new Label();
            label6 = new Label();
            lblAdminPassword = new Label();
            txtAdminPassword = new TextBox();
            lblAdminConfirmPass = new Label();
            txtAdminConfirmPass = new TextBox();
            lblAdminCreateError = new Label();
            btnCreateAdmin = new Button();
            btnAdminCreateBack = new Button();
            label3 = new Label();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelAdminCreate.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackgroundImage = (Image)resources.GetObject("panelLogin.BackgroundImage");
            panelLogin.BackgroundImageLayout = ImageLayout.Stretch;
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(btnToggle);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(lblPassword);
            panelLogin.Controls.Add(lblUsername);
            panelLogin.Controls.Add(pictureBox1);
            panelLogin.Controls.Add(lblError);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(btnSignIn);
            panelLogin.Controls.Add(btnLogIn);
            panelLogin.Controls.Add(txtUsername);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(pictureBox2);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(0, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(884, 511);
            panelLogin.TabIndex = 1;
            // 
            // btnToggle
            // 
            btnToggle.BackColor = Color.FromArgb(250, 240, 192);
            btnToggle.Cursor = Cursors.Hand;
            btnToggle.FlatAppearance.BorderSize = 0;
            btnToggle.FlatStyle = FlatStyle.Flat;
            btnToggle.ForeColor = Color.FromArgb(107, 21, 38);
            btnToggle.Location = new Point(820, 195);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(30, 24);
            btnToggle.TabIndex = 26;
            btnToggle.TabStop = false;
            btnToggle.Text = "👁";
            btnToggle.UseVisualStyleBackColor = false;
            btnToggle.Click += btnToggle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(92, 58, 0);
            label2.Location = new Point(478, 57);
            label2.Name = "label2";
            label2.Size = new Size(356, 21);
            label2.TabIndex = 25;
            label2.Text = "Enter your credentials to access your dashboard";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(92, 58, 0);
            lblPassword.Location = new Point(478, 170);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(81, 21);
            lblPassword.TabIndex = 23;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(92, 58, 0);
            lblUsername.Location = new Point(478, 116);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(84, 21);
            lblUsername.TabIndex = 22;
            lblUsername.Text = "Username:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(91, 178);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.None;
            lblError.AutoSize = true;
            lblError.BackColor = Color.Transparent;
            lblError.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(478, 226);
            lblError.MaximumSize = new Size(370, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(112, 21);
            lblError.TabIndex = 18;
            lblError.Text = "Error Message";
            lblError.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(92, 58, 0);
            label1.Location = new Point(482, 400);
            label1.Name = "label1";
            label1.Size = new Size(204, 21);
            label1.TabIndex = 16;
            label1.Text = "Don't have an account yet?";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(245, 216, 120);
            btnSignIn.FlatAppearance.MouseDownBackColor = Color.FromArgb(196, 138, 0);
            btnSignIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 200, 64);
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.FromArgb(74, 14, 26);
            btnSignIn.Location = new Point(483, 424);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(199, 34);
            btnSignIn.TabIndex = 15;
            btnSignIn.Text = "Create an Account";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(107, 21, 38);
            btnLogIn.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 14, 26);
            btnLogIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(139, 26, 48);
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Letters for Learners", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.FromArgb(245, 216, 120);
            btnLogIn.Location = new Point(478, 270);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(371, 34);
            btnLogIn.TabIndex = 14;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(250, 240, 192);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            txtUsername.ForeColor = Color.FromArgb(196, 138, 0);
            txtUsername.Location = new Point(478, 140);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = " 🐱 Enter username...";
            txtUsername.Size = new Size(375, 27);
            txtUsername.TabIndex = 13;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(250, 240, 192);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            txtPassword.ForeColor = Color.FromArgb(122, 78, 0);
            txtPassword.Location = new Point(478, 194);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = " 🔒 Enter Password...";
            txtPassword.Size = new Size(375, 27);
            txtPassword.TabIndex = 12;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(701, 227);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(183, 334);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // panelAdminCreate
            // 
            panelAdminCreate.BackColor = Color.Transparent;
            panelAdminCreate.BackgroundImage = (Image)resources.GetObject("panelAdminCreate.BackgroundImage");
            panelAdminCreate.BackgroundImageLayout = ImageLayout.Stretch;
            panelAdminCreate.Controls.Add(btnToggleAdminConfirm);
            panelAdminCreate.Controls.Add(btnToggleAdminPass);
            panelAdminCreate.Controls.Add(lblAdminTitle);
            panelAdminCreate.Controls.Add(label4);
            panelAdminCreate.Controls.Add(label8);
            panelAdminCreate.Controls.Add(lblAdminFirstName);
            panelAdminCreate.Controls.Add(txtAdminFirstName);
            panelAdminCreate.Controls.Add(lblAdminMiddleName);
            panelAdminCreate.Controls.Add(txtAdminMiddleName);
            panelAdminCreate.Controls.Add(lblAdminLastName);
            panelAdminCreate.Controls.Add(txtAdminLastName);
            panelAdminCreate.Controls.Add(lblAdminEmployeeID);
            panelAdminCreate.Controls.Add(txtAdminEmployeeID);
            panelAdminCreate.Controls.Add(lblAdminDept);
            panelAdminCreate.Controls.Add(cmbAdminDept);
            panelAdminCreate.Controls.Add(lblUsernamePreview);
            panelAdminCreate.Controls.Add(label6);
            panelAdminCreate.Controls.Add(lblAdminPassword);
            panelAdminCreate.Controls.Add(txtAdminPassword);
            panelAdminCreate.Controls.Add(lblAdminConfirmPass);
            panelAdminCreate.Controls.Add(txtAdminConfirmPass);
            panelAdminCreate.Controls.Add(lblAdminCreateError);
            panelAdminCreate.Controls.Add(btnCreateAdmin);
            panelAdminCreate.Controls.Add(btnAdminCreateBack);
            panelAdminCreate.Dock = DockStyle.Fill;
            panelAdminCreate.Location = new Point(0, 0);
            panelAdminCreate.Name = "panelAdminCreate";
            panelAdminCreate.Size = new Size(884, 511);
            panelAdminCreate.TabIndex = 29;
            panelAdminCreate.Visible = false;
            // 
            // btnToggleAdminConfirm
            // 
            btnToggleAdminConfirm.BackColor = Color.FromArgb(250, 240, 192);
            btnToggleAdminConfirm.Cursor = Cursors.Hand;
            btnToggleAdminConfirm.FlatAppearance.BorderSize = 0;
            btnToggleAdminConfirm.FlatStyle = FlatStyle.Flat;
            btnToggleAdminConfirm.ForeColor = Color.FromArgb(107, 21, 38);
            btnToggleAdminConfirm.Location = new Point(693, 392);
            btnToggleAdminConfirm.Name = "btnToggleAdminConfirm";
            btnToggleAdminConfirm.Size = new Size(30, 24);
            btnToggleAdminConfirm.TabIndex = 43;
            btnToggleAdminConfirm.TabStop = false;
            btnToggleAdminConfirm.Text = "👁";
            btnToggleAdminConfirm.UseVisualStyleBackColor = false;
            btnToggleAdminConfirm.Click += btnToggleAdminConfirm_Click;
            // 
            // btnToggleAdminPass
            // 
            btnToggleAdminPass.BackColor = Color.FromArgb(250, 240, 192);
            btnToggleAdminPass.Cursor = Cursors.Hand;
            btnToggleAdminPass.FlatAppearance.BorderSize = 0;
            btnToggleAdminPass.FlatStyle = FlatStyle.Flat;
            btnToggleAdminPass.ForeColor = Color.FromArgb(107, 21, 38);
            btnToggleAdminPass.Location = new Point(693, 340);
            btnToggleAdminPass.Name = "btnToggleAdminPass";
            btnToggleAdminPass.Size = new Size(30, 24);
            btnToggleAdminPass.TabIndex = 42;
            btnToggleAdminPass.TabStop = false;
            btnToggleAdminPass.Text = "👁";
            btnToggleAdminPass.UseVisualStyleBackColor = false;
            btnToggleAdminPass.Click += btnToggleAdminPass_Click;
            // 
            // lblAdminTitle
            // 
            lblAdminTitle.AutoSize = true;
            lblAdminTitle.BackColor = Color.Transparent;
            lblAdminTitle.Font = new Font("Kermit", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminTitle.ForeColor = Color.FromArgb(74, 14, 26);
            lblAdminTitle.Location = new Point(286, 1);
            lblAdminTitle.Name = "lblAdminTitle";
            lblAdminTitle.Size = new Size(313, 45);
            lblAdminTitle.TabIndex = 29;
            lblAdminTitle.Text = "Create Admin Account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Letters for Learners", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.FromArgb(92, 58, 0);
            label4.Location = new Point(296, 42);
            label4.Name = "label4";
            label4.Size = new Size(235, 16);
            label4.TabIndex = 32;
            label4.Text = "Username is generated automatically";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold | FontStyle.Underline);
            label8.ForeColor = Color.FromArgb(92, 58, 0);
            label8.Location = new Point(293, 60);
            label8.Name = "label8";
            label8.Size = new Size(156, 21);
            label8.TabIndex = 33;
            label8.Text = "PERSONAL DETAILS";
            // 
            // lblAdminFirstName
            // 
            lblAdminFirstName.AutoSize = true;
            lblAdminFirstName.BackColor = Color.Transparent;
            lblAdminFirstName.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblAdminFirstName.ForeColor = Color.FromArgb(92, 58, 0);
            lblAdminFirstName.Location = new Point(295, 81);
            lblAdminFirstName.Name = "lblAdminFirstName";
            lblAdminFirstName.Size = new Size(90, 21);
            lblAdminFirstName.TabIndex = 30;
            lblAdminFirstName.Text = "First name:";
            // 
            // txtAdminFirstName
            // 
            txtAdminFirstName.BackColor = Color.FromArgb(250, 240, 192);
            txtAdminFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtAdminFirstName.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            txtAdminFirstName.ForeColor = Color.FromArgb(196, 138, 0);
            txtAdminFirstName.Location = new Point(297, 103);
            txtAdminFirstName.Multiline = true;
            txtAdminFirstName.Name = "txtAdminFirstName";
            txtAdminFirstName.PlaceholderText = " Enter first name...";
            txtAdminFirstName.Size = new Size(180, 23);
            txtAdminFirstName.TabIndex = 27;
            txtAdminFirstName.TextChanged += txtAdminFirstName_TextChanged;
            // 
            // lblAdminMiddleName
            // 
            lblAdminMiddleName.AutoSize = true;
            lblAdminMiddleName.BackColor = Color.Transparent;
            lblAdminMiddleName.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblAdminMiddleName.ForeColor = Color.FromArgb(92, 58, 0);
            lblAdminMiddleName.Location = new Point(493, 81);
            lblAdminMiddleName.Name = "lblAdminMiddleName";
            lblAdminMiddleName.Size = new Size(104, 21);
            lblAdminMiddleName.TabIndex = 45;
            lblAdminMiddleName.Text = "Middle name:";
            // 
            // txtAdminMiddleName
            // 
            txtAdminMiddleName.BackColor = Color.FromArgb(250, 240, 192);
            txtAdminMiddleName.BorderStyle = BorderStyle.FixedSingle;
            txtAdminMiddleName.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            txtAdminMiddleName.ForeColor = Color.FromArgb(196, 138, 0);
            txtAdminMiddleName.Location = new Point(494, 103);
            txtAdminMiddleName.Multiline = true;
            txtAdminMiddleName.Name = "txtAdminMiddleName";
            txtAdminMiddleName.PlaceholderText = " Enter middle name...";
            txtAdminMiddleName.Size = new Size(180, 23);
            txtAdminMiddleName.TabIndex = 44;
            // 
            // lblAdminLastName
            // 
            lblAdminLastName.AutoSize = true;
            lblAdminLastName.BackColor = Color.Transparent;
            lblAdminLastName.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblAdminLastName.ForeColor = Color.FromArgb(92, 58, 0);
            lblAdminLastName.Location = new Point(691, 81);
            lblAdminLastName.Name = "lblAdminLastName";
            lblAdminLastName.Size = new Size(87, 21);
            lblAdminLastName.TabIndex = 34;
            lblAdminLastName.Text = "Last name:";
            // 
            // txtAdminLastName
            // 
            txtAdminLastName.BackColor = Color.FromArgb(250, 240, 192);
            txtAdminLastName.BorderStyle = BorderStyle.FixedSingle;
            txtAdminLastName.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            txtAdminLastName.ForeColor = Color.FromArgb(196, 138, 0);
            txtAdminLastName.Location = new Point(691, 103);
            txtAdminLastName.Multiline = true;
            txtAdminLastName.Name = "txtAdminLastName";
            txtAdminLastName.PlaceholderText = " Enter last name...";
            txtAdminLastName.Size = new Size(180, 23);
            txtAdminLastName.TabIndex = 35;
            txtAdminLastName.TextChanged += txtAdminFirstName_TextChanged;
            // 
            // lblAdminEmployeeID
            // 
            lblAdminEmployeeID.AutoSize = true;
            lblAdminEmployeeID.BackColor = Color.Transparent;
            lblAdminEmployeeID.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblAdminEmployeeID.ForeColor = Color.FromArgb(92, 58, 0);
            lblAdminEmployeeID.Location = new Point(295, 134);
            lblAdminEmployeeID.Name = "lblAdminEmployeeID";
            lblAdminEmployeeID.Size = new Size(103, 21);
            lblAdminEmployeeID.TabIndex = 47;
            lblAdminEmployeeID.Text = "Employee ID:";
            // 
            // txtAdminEmployeeID
            // 
            txtAdminEmployeeID.BackColor = Color.FromArgb(250, 240, 192);
            txtAdminEmployeeID.BorderStyle = BorderStyle.FixedSingle;
            txtAdminEmployeeID.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            txtAdminEmployeeID.ForeColor = Color.FromArgb(196, 138, 0);
            txtAdminEmployeeID.Location = new Point(295, 156);
            txtAdminEmployeeID.Name = "txtAdminEmployeeID";
            txtAdminEmployeeID.PlaceholderText = " Enter Employee ID...";
            txtAdminEmployeeID.Size = new Size(430, 27);
            txtAdminEmployeeID.TabIndex = 46;
            txtAdminEmployeeID.TextChanged += txtAdminEmployeeID_TextChanged;
            // 
            // lblAdminDept
            // 
            lblAdminDept.AutoSize = true;
            lblAdminDept.BackColor = Color.Transparent;
            lblAdminDept.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblAdminDept.ForeColor = Color.FromArgb(92, 58, 0);
            lblAdminDept.Location = new Point(297, 200);
            lblAdminDept.Name = "lblAdminDept";
            lblAdminDept.Size = new Size(96, 21);
            lblAdminDept.TabIndex = 49;
            lblAdminDept.Text = "Department:";
            // 
            // cmbAdminDept
            // 
            cmbAdminDept.BackColor = Color.FromArgb(250, 240, 192);
            cmbAdminDept.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAdminDept.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            cmbAdminDept.ForeColor = Color.FromArgb(196, 138, 0);
            cmbAdminDept.Location = new Point(297, 222);
            cmbAdminDept.Name = "cmbAdminDept";
            cmbAdminDept.Size = new Size(430, 29);
            cmbAdminDept.TabIndex = 48;
            // 
            // lblUsernamePreview
            // 
            lblUsernamePreview.AutoSize = true;
            lblUsernamePreview.BackColor = Color.Transparent;
            lblUsernamePreview.Font = new Font("Letters for Learners", 11.25F, FontStyle.Italic);
            lblUsernamePreview.ForeColor = Color.FromArgb(92, 58, 0);
            lblUsernamePreview.Location = new Point(296, 265);
            lblUsernamePreview.Name = "lblUsernamePreview";
            lblUsernamePreview.Size = new Size(146, 16);
            lblUsernamePreview.TabIndex = 36;
            lblUsernamePreview.Text = "Username will appear here";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold | FontStyle.Underline);
            label6.ForeColor = Color.FromArgb(92, 58, 0);
            label6.Location = new Point(293, 292);
            label6.Name = "label6";
            label6.Size = new Size(128, 21);
            label6.TabIndex = 37;
            label6.Text = "SET PASSWORD";
            // 
            // lblAdminPassword
            // 
            lblAdminPassword.AutoSize = true;
            lblAdminPassword.BackColor = Color.Transparent;
            lblAdminPassword.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblAdminPassword.ForeColor = Color.FromArgb(92, 58, 0);
            lblAdminPassword.Location = new Point(293, 314);
            lblAdminPassword.Name = "lblAdminPassword";
            lblAdminPassword.Size = new Size(81, 21);
            lblAdminPassword.TabIndex = 31;
            lblAdminPassword.Text = "Password:";
            // 
            // txtAdminPassword
            // 
            txtAdminPassword.BackColor = Color.FromArgb(250, 240, 192);
            txtAdminPassword.BorderStyle = BorderStyle.FixedSingle;
            txtAdminPassword.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            txtAdminPassword.ForeColor = Color.FromArgb(122, 78, 0);
            txtAdminPassword.Location = new Point(295, 338);
            txtAdminPassword.Name = "txtAdminPassword";
            txtAdminPassword.PasswordChar = '●';
            txtAdminPassword.PlaceholderText = " 🔒 Enter Password...";
            txtAdminPassword.Size = new Size(430, 27);
            txtAdminPassword.TabIndex = 26;
            // 
            // lblAdminConfirmPass
            // 
            lblAdminConfirmPass.AutoSize = true;
            lblAdminConfirmPass.BackColor = Color.Transparent;
            lblAdminConfirmPass.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            lblAdminConfirmPass.ForeColor = Color.FromArgb(92, 58, 0);
            lblAdminConfirmPass.Location = new Point(295, 368);
            lblAdminConfirmPass.Name = "lblAdminConfirmPass";
            lblAdminConfirmPass.Size = new Size(69, 21);
            lblAdminConfirmPass.TabIndex = 39;
            lblAdminConfirmPass.Text = "Confirm:";
            // 
            // txtAdminConfirmPass
            // 
            txtAdminConfirmPass.BackColor = Color.FromArgb(250, 240, 192);
            txtAdminConfirmPass.BorderStyle = BorderStyle.FixedSingle;
            txtAdminConfirmPass.Font = new Font("Letters for Learners", 14.25F, FontStyle.Bold);
            txtAdminConfirmPass.ForeColor = Color.FromArgb(122, 78, 0);
            txtAdminConfirmPass.Location = new Point(295, 390);
            txtAdminConfirmPass.Name = "txtAdminConfirmPass";
            txtAdminConfirmPass.PasswordChar = '●';
            txtAdminConfirmPass.PlaceholderText = " 🔒 Confirm...";
            txtAdminConfirmPass.Size = new Size(430, 27);
            txtAdminConfirmPass.TabIndex = 38;
            // 
            // lblAdminCreateError
            // 
            lblAdminCreateError.AutoSize = true;
            lblAdminCreateError.BackColor = Color.Transparent;
            lblAdminCreateError.Font = new Font("Letters for Learners", 11.25F, FontStyle.Bold);
            lblAdminCreateError.ForeColor = Color.Red;
            lblAdminCreateError.Location = new Point(296, 424);
            lblAdminCreateError.MaximumSize = new Size(430, 0);
            lblAdminCreateError.Name = "lblAdminCreateError";
            lblAdminCreateError.Size = new Size(94, 16);
            lblAdminCreateError.TabIndex = 41;
            lblAdminCreateError.Text = "error message";
            lblAdminCreateError.Visible = false;
            // 
            // btnCreateAdmin
            // 
            btnCreateAdmin.BackColor = Color.FromArgb(107, 21, 38);
            btnCreateAdmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 14, 26);
            btnCreateAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(139, 26, 48);
            btnCreateAdmin.FlatStyle = FlatStyle.Flat;
            btnCreateAdmin.Font = new Font("Letters for Learners", 13.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAdmin.ForeColor = Color.FromArgb(245, 216, 120);
            btnCreateAdmin.Location = new Point(293, 454);
            btnCreateAdmin.Name = "btnCreateAdmin";
            btnCreateAdmin.Size = new Size(210, 34);
            btnCreateAdmin.TabIndex = 28;
            btnCreateAdmin.Text = "Create Admin Account";
            btnCreateAdmin.UseVisualStyleBackColor = false;
            btnCreateAdmin.Click += btnCreateAdmin_Click;
            // 
            // btnAdminCreateBack
            // 
            btnAdminCreateBack.BackColor = Color.FromArgb(250, 240, 192);
            btnAdminCreateBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 14, 26);
            btnAdminCreateBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(139, 26, 48);
            btnAdminCreateBack.FlatStyle = FlatStyle.Flat;
            btnAdminCreateBack.Font = new Font("Letters for Learners", 13.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminCreateBack.ForeColor = Color.FromArgb(92, 58, 0);
            btnAdminCreateBack.Location = new Point(509, 454);
            btnAdminCreateBack.Name = "btnAdminCreateBack";
            btnAdminCreateBack.Size = new Size(210, 34);
            btnAdminCreateBack.TabIndex = 40;
            btnAdminCreateBack.Text = "← Back to Login";
            btnAdminCreateBack.UseVisualStyleBackColor = false;
            btnAdminCreateBack.Click += btnAdminCreateBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Kermit", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(74, 14, 26);
            label3.Location = new Point(478, 9);
            label3.Name = "label3";
            label3.Size = new Size(148, 45);
            label3.TabIndex = 30;
            label3.Text = "Welcome!";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 511);
            Controls.Add(panelAdminCreate);
            Controls.Add(panelLogin);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Retriever";
            Load += LogIn_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelAdminCreate.ResumeLayout(false);
            panelAdminCreate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Label label1;
        private Button btnSignIn;
        private Button btnLogIn;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblError;
        private PictureBox pictureBox1;
        private Label lblPassword;
        private Label lblUsername;
        private Label label2;
        private PictureBox pictureBox2;
        private Button btnToggle;
        private Panel panelAdminCreate;
        private Button btnToggleAdminConfirm;
        private Button btnToggleAdminPass;
        private Label lblAdminCreateError;
        private Button btnAdminCreateBack;
        private Label lblAdminConfirmPass;
        private TextBox txtAdminConfirmPass;
        private Label label6;
        private Label lblUsernamePreview;
        private TextBox txtAdminLastName;
        private Label lblAdminLastName;
        private TextBox txtAdminMiddleName;
        private Label lblAdminMiddleName;
        private TextBox txtAdminEmployeeID;
        private Label lblAdminEmployeeID;
        private ComboBox cmbAdminDept;
        private Label lblAdminDept;
        private Label label8;
        private Label label4;
        private Label lblAdminPassword;
        private Label lblAdminFirstName;
        private Label lblAdminTitle;
        private Button btnCreateAdmin;
        private TextBox txtAdminFirstName;
        private TextBox txtAdminPassword;
        private Label label3;
    }
}