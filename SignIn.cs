using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _DRAFT__OOP_2_FINAL_PROJECT
{
    public partial class SignIn : Form
    {
        private AccountManager accountManager;

        
        private string verifiedStudentID = "";
        private string verifiedFullName = "";
        private string verifiedDepartment = "";

        public SignIn()
        {
            InitializeComponent();
        }

        public SignIn(AccountManager manager)
        {
            InitializeComponent();
            accountManager = manager;
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            
            panelVerify.Visible = true;
            panelCreate.Visible = false;
            lblError.Visible = false;
        }

        

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string studentID = txtIDNumber.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string middleName = txtMiddleName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            
            if (string.IsNullOrWhiteSpace(studentID))
            {
                ShowError("Please enter your Student ID.");
                txtIDNumber.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(firstName))
            {
                ShowError("Please enter your first name.");
                txtFirstName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                ShowError("Please enter your last name.");
                txtLastName.Focus();
                return;
            }

            
            string fullName;
            string department;
            string errorMessage;

            bool verified = accountManager.VerifyStudent(
                studentID, firstName, middleName, lastName,
                out fullName, out department, out errorMessage
            );

            if (verified)
            {
                verifiedStudentID = studentID;
                verifiedFullName = fullName;
                verifiedDepartment = department;

                lblError.Visible = false;

                
                panelCreate.Visible = true;
                panelCreate.BringToFront();

                lblVerifiedName.Text =
                    "Verified: " + fullName +
                    " (" + studentID + ")";
            }
            else
            {
                ShowError(errorMessage);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = txtNewUsername.Text.Trim();
            string password = txtNewPassword.Text;
            string confirmPass = txtConfirmPassword.Text;

            
            if (string.IsNullOrWhiteSpace(username))
            {
                ShowCreateError("Please enter a username.");
                txtNewUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                ShowCreateError("Please enter a password.");
                txtNewPassword.Focus();
                return;
            }

            if (password.Length < 6)
            {
                ShowCreateError(
                    "Password must be at least 6 characters.");
                txtNewPassword.Focus();
                return;
            }

            if (password != confirmPass)
            {
                ShowCreateError(
                    "Passwords do not match. Please try again.");
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                return;
            }

            
            string errorMessage;
            bool success = accountManager.Register(
                username, password,
                verifiedStudentID,
                verifiedFullName,
                verifiedDepartment,
                out errorMessage
            );

            if (success)
            {
                MessageBox.Show(
                    "Account created successfully!\n\n" +
                    "Name:     " + verifiedFullName + "\n" +
                    "Username: " + username + "\n\n" +
                    "You can now log in.",
                    "Welcome to Retriever!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Close();
            }
            else
            {
                ShowCreateError(errorMessage);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelCreate.Visible = false;
            lblCreateError.Visible = false;

            txtNewUsername.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
        }

       

        private void ShowError(string message)
        {
            lblError.Text = message;
            lblError.Visible = true;
        }

        private void ShowCreateError(string message)
        {
            lblCreateError.Text = message;
            lblCreateError.Visible = true;
        }
    }
}