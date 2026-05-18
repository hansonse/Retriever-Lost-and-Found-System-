using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _DRAFT__OOP_2_FINAL_PROJECT
{
    public partial class LogIn : Form
    {
        private AccountManager accountManager = new AccountManager();
        private bool _showPassword = false;
        private bool _showAdminPass = false;
        private bool _showAdminConfirm = false;

        public LogIn()
        {
            InitializeComponent();
            this.ActiveControl = null;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            
            txtPassword.PasswordChar = '●';
            btnToggle.Text = "👁";
            btnToggle.Cursor = Cursors.Hand;

            RoundTextBox(txtUsername, 10);
            RoundTextBox(txtPassword, 10);

            
            txtAdminPassword.PasswordChar = '●';
            txtAdminConfirmPass.PasswordChar = '●';
            btnToggleAdminPass.Text = "👁";
            btnToggleAdminConfirm.Text = "👁";
            btnToggleAdminPass.Cursor = Cursors.Hand;
            btnToggleAdminConfirm.Cursor = Cursors.Hand;

            panelAdminCreate.Visible = false;
            lblAdminCreateError.Visible = false;
            lblError.Visible = false;
            lblUsernamePreview.Text = "Username will appear here";

            
            lblAdminPassword.Visible      = false;
            txtAdminPassword.Visible      = false;
            btnToggleAdminPass.Visible    = false;
            lblAdminConfirmPass.Visible   = false;
            txtAdminConfirmPass.Visible   = false;
            btnToggleAdminConfirm.Visible = false;
            label6.Visible                = false;
            btnCreateAdmin.Text           = "Verify & Continue";

            
            cmbAdminDept.Items.AddRange(new string[]
            {
                "-- Select Department --",
                
                "BS Computer Science",
                "BS Information Technology",
                
                "BS Nursing",
                "BS Pharmacy",
                "BS Medical Technology",
                
                "BS Criminology",
                
                "AB Communication",
                "AB English with Applied Linguistics",
                "BS Biology",
                "BS Math with Applied Industrial Mathematics",
                "BS Psychology",
                
                "Bachelor of Elementary Education",
                "Bachelor of Secondary Education Major in English",
                "Bachelor of Secondary Education Major in Filipino",
                "Bachelor of Secondary Education Major in Mathematics",
                "Bachelor of Secondary Education Major in Science",
                "Bachelor of Multimedia Arts",
                "Bachelor of Special Needs Education (Generalist)",
                
                "BS Accountancy",
                "BS Accounting Information Systems",
                "BS Management Accounting",
                "BS Business Administration - Banking & Financial Management",
                "BS Business Administration - Business Analytics",
                "BS Business Administration - General Business Management",
                "BS Business Administration - Human Resource Management",
                "BS Business Administration - Marketing Management",
                "BS Business Administration - Operations Management",
                "BS Business Administration - Quality Management",
                "BS Hospitality Management",
                "BS Tourism Management",
                "BS Office Administration",
                "Associate in Office Administration",
                "Bachelor in Public Administration",
                
                "BS Architecture",
                "BS Chemical Engineering",
                "BS Civil Engineering",
                "BS Computer Engineering",
                "BS Electrical Engineering",
                "BS Electronics Engineering",
                "BS Industrial Engineering",
                "BS Mechanical Engineering with Computational Science",
                "BS Mechanical Engineering with Mechatronics",
                "BS Mining Engineering"
            });
            cmbAdminDept.SelectedIndex = 0;

           
            this.BeginInvoke(new Action(() =>
            {
                this.ActiveControl = null;
            }));
        }

        

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                ShowError("Please enter your username.");
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                ShowError("Please enter your password.");
                txtPassword.Focus();
                return;
            }

            
            string keyError;
            if (accountManager.VerifyAdminKey(username, password, out keyError))
            {
                lblError.Visible = false;
                txtUsername.Clear();
                txtPassword.Clear();
                _showPassword = false;
                txtPassword.PasswordChar = '●';
                btnToggle.Text = "👁";

                panelAdminCreate.Visible = true;
                panelAdminCreate.BringToFront();
                txtAdminFirstName.Focus();
                return;
            }

            
            if (accountManager.SignIn(username, password))
            {
                lblError.Visible = false;
                string role = accountManager.GetRole(username);
                int userID = accountManager.GetUserID(username);

                if (role == "admin")
                {
                    Retriever adminMenu = new Retriever(username, userID);
                    adminMenu.Show();
                    this.Hide();
                }
                else
                {
                    UserMenu userMenu = new UserMenu(username, userID);
                    userMenu.Show();
                    this.Hide();
                }
            }
            else
            {
                ShowError("Invalid username or password. Please try again.");
                txtPassword.Clear();
                txtPassword.Focus();
                _showPassword = false;
                txtPassword.PasswordChar = '●';
                btnToggle.Text = "👁";
            }
        }

        

        private void btnToggle_Click(object sender, EventArgs e)
        {
            _showPassword = !_showPassword;
            txtPassword.PasswordChar = _showPassword ? '\0' : '●';
            btnToggle.Text = _showPassword ? "🙈" : "👁";
            txtPassword.Focus();
            txtPassword.SelectionStart = txtPassword.Text.Length;
        }

        

        private void btnToggleAdminPass_Click(object sender, EventArgs e)
        {
            _showAdminPass = !_showAdminPass;
            txtAdminPassword.PasswordChar = _showAdminPass ? '\0' : '●';
            btnToggleAdminPass.Text = _showAdminPass ? "🙈" : "👁";
            txtAdminPassword.Focus();
            txtAdminPassword.SelectionStart = txtAdminPassword.Text.Length;
        }

        
        private void btnToggleAdminConfirm_Click(object sender, EventArgs e)
        {
            _showAdminConfirm = !_showAdminConfirm;
            txtAdminConfirmPass.PasswordChar = _showAdminConfirm ? '\0' : '●';
            btnToggleAdminConfirm.Text = _showAdminConfirm ? "🙈" : "👁";
            txtAdminConfirmPass.Focus();
            txtAdminConfirmPass.SelectionStart = txtAdminConfirmPass.Text.Length;
        }

        

        private void txtAdminFirstName_TextChanged(object sender, EventArgs e)
        {
            string first = txtAdminFirstName.Text.Trim();
            string last = txtAdminLastName.Text.Trim();

            if (string.IsNullOrWhiteSpace(first) && string.IsNullOrWhiteSpace(last))
            {
                lblUsernamePreview.Text = "Username will appear here";
                return;
            }

            string year = DateTime.Now.Year.ToString();
            lblUsernamePreview.Text = "Preview: ADM-" + year + "-??? · " + first + " " + last;
        }

        private bool _employeeVerified = false;
        private string _verifiedEmployeeID = "";
        private string _verifiedDepartment = "";

        

        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            
            if (!_employeeVerified)
            {
                VerifyEmployeeStep();
                return;
            }

            
            CreateAdminStep();
        }

        private void VerifyEmployeeStep()
        {
            string firstName  = txtAdminFirstName.Text.Trim();
            string middleName = txtAdminMiddleName.Text.Trim();
            string lastName   = txtAdminLastName.Text.Trim();
            string employeeID = txtAdminEmployeeID.Text.Trim();
            string department = cmbAdminDept.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(firstName))
            { ShowAdminCreateError("Please enter your first name."); txtAdminFirstName.Focus(); return; }

            if (string.IsNullOrWhiteSpace(lastName))
            { ShowAdminCreateError("Please enter your last name."); txtAdminLastName.Focus(); return; }

            if (string.IsNullOrWhiteSpace(employeeID))
            { ShowAdminCreateError("Please enter your Employee ID."); txtAdminEmployeeID.Focus(); return; }

            if (department == "-- Select Department --" || string.IsNullOrWhiteSpace(department))
            { ShowAdminCreateError("Please select your department."); cmbAdminDept.Focus(); return; }

            
            if (!accountManager.VerifyEmployeeRecord(firstName, middleName, lastName, employeeID))
            {
                ShowAdminCreateError(
                    "❌ No matching employee record found.\n" +
                    "Please check your name and Employee ID.");
                return;
            }

            
            _employeeVerified    = true;
            _verifiedEmployeeID  = employeeID;
            _verifiedDepartment  = department;

            txtAdminFirstName.Enabled  = false;
            txtAdminMiddleName.Enabled = false;
            txtAdminLastName.Enabled   = false;
            txtAdminEmployeeID.Enabled = false;
            cmbAdminDept.Enabled       = false;

            
            lblAdminPassword.Visible    = true;
            txtAdminPassword.Visible    = true;
            btnToggleAdminPass.Visible  = true;
            lblAdminConfirmPass.Visible = true;
            txtAdminConfirmPass.Visible = true;
            btnToggleAdminConfirm.Visible = true;
            label6.Visible              = true;

            lblAdminCreateError.ForeColor = Color.DarkGreen;
            ShowAdminCreateError("✔ Employee record verified! Now set your password.");
            txtAdminPassword.Focus();
            btnCreateAdmin.Text = "Create Account";
        }

        private void CreateAdminStep()
        {
            string firstName  = txtAdminFirstName.Text.Trim();
            string middleName = txtAdminMiddleName.Text.Trim();
            string lastName   = txtAdminLastName.Text.Trim();
            string password   = txtAdminPassword.Text;
            string confirmPass = txtAdminConfirmPass.Text;

            if (string.IsNullOrWhiteSpace(password))
            { ShowAdminCreateError("Please enter a password."); txtAdminPassword.Focus(); return; }

            if (password.Length < 6)
            { ShowAdminCreateError("Password must be at least 6 characters."); txtAdminPassword.Focus(); return; }

            if (password != confirmPass)
            {
                ShowAdminCreateError("Passwords do not match. Please try again.");
                txtAdminConfirmPass.Clear();
                txtAdminConfirmPass.Focus();
                return;
            }

            string errorMessage, generatedUsername;
            bool success = accountManager.RegisterAdmin(
                firstName, middleName, lastName,
                _verifiedEmployeeID, _verifiedDepartment,
                password,
                out errorMessage,
                out generatedUsername);

            if (success)
            {
                MessageBox.Show(
                    "Admin account created successfully!\n\n" +
                    "Username:    " + generatedUsername + "\n" +
                    "Name:        " + firstName + " " + lastName + "\n" +
                    "Employee ID: " + _verifiedEmployeeID + "\n" +
                    "Department:  " + _verifiedDepartment + "\n\n" +
                    "Please save your username. You can now log in.",
                    "Admin Account Created",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                GoToLogin();
            }
            else
            {
                lblAdminCreateError.ForeColor = Color.Red;
                ShowAdminCreateError(errorMessage);
            }
        }

        

        private void btnAdminCreateBack_Click(object sender, EventArgs e)
        {
            GoToLogin();
        }

        

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn(accountManager);
            signIn.ShowDialog();

            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
            lblError.Visible = false;
            _showPassword = false;
            txtPassword.PasswordChar = '●';
            btnToggle.Text = "👁";
        }

        

        private void GoToLogin()
        {
            panelLogin.Visible = true;
            panelAdminCreate.Visible = false;
            lblError.Visible = false;
            lblError.ForeColor = Color.Red;
            lblAdminCreateError.Visible = false;
            lblAdminCreateError.ForeColor = Color.Red;

            
            _employeeVerified   = false;
            _verifiedEmployeeID = "";
            _verifiedDepartment = "";

            
            txtAdminFirstName.Enabled  = true;
            txtAdminMiddleName.Enabled = true;
            txtAdminLastName.Enabled   = true;
            txtAdminEmployeeID.Enabled = true;
            cmbAdminDept.Enabled       = true;

            
            lblAdminPassword.Visible      = false;
            txtAdminPassword.Visible      = false;
            btnToggleAdminPass.Visible    = false;
            lblAdminConfirmPass.Visible   = false;
            txtAdminConfirmPass.Visible   = false;
            btnToggleAdminConfirm.Visible = false;
            label6.Visible                = false;

            btnCreateAdmin.Text = "Verify & Continue";

            txtUsername.Clear();
            txtPassword.Clear();
            txtAdminFirstName.Clear();
            txtAdminMiddleName.Clear();
            txtAdminLastName.Clear();
            txtAdminEmployeeID.Clear();
            cmbAdminDept.SelectedIndex = 0;
            txtAdminPassword.Clear();
            txtAdminConfirmPass.Clear();
            lblUsernamePreview.Text = "Username will appear here";
            _showPassword     = false;
            _showAdminPass    = false;
            _showAdminConfirm = false;
            txtPassword.PasswordChar         = '●';
            txtAdminPassword.PasswordChar    = '●';
            txtAdminConfirmPass.PasswordChar = '●';
            btnToggle.Text             = "👁";
            btnToggleAdminPass.Text    = "👁";
            btnToggleAdminConfirm.Text = "👁";
            txtUsername.Focus();
        }

        private void ShowError(string message)
        {
            lblError.Text = message;
            lblError.Visible = true;
        }

        private void ShowAdminCreateError(string message)
        {
            lblAdminCreateError.Text = message;
            lblAdminCreateError.Visible = true;
        }

        private void RoundTextBox(TextBox txt, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(txt.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(txt.Width - radius, txt.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, txt.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            txt.Region = new Region(path);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void txtAdminEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}