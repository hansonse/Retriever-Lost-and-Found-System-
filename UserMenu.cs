using _DRAFT__OOP_2_FINAL_PROJECT.UserControls;
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
using System.Xml.Linq;

namespace _DRAFT__OOP_2_FINAL_PROJECT
{
    public partial class UserMenu : Form
    {
        private UserControls.ReportFound ucReportFound;
        private UserControls.Inventory ucInventory;
        private UserControls.MyMatches ucMyMatches;
        private UserControls.RequestClaim ucRequestClaim;
        private UserControls.UserHome ucUserHome;
        private ItemManager itemManager = new ItemManager();
        private AccountManager AccountManager = new AccountManager();
        private UserControls.ReportLost ucReportLost;
        private string currentUser;
        private int currentUserID;
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        public UserMenu(string username, int userID)
        {
            InitializeComponent();
            currentUser = username;
            currentUserID = userID;

            
            ucInventory = new UserControls.Inventory(currentUser, "user");
            ucReportLost = new UserControls.ReportLost(itemManager, currentUser, currentUserID);
            ucReportFound = new UserControls.ReportFound(itemManager, currentUser, currentUserID);

            
            ucRequestClaim = new UserControls.RequestClaim();
            ucRequestClaim.CurrentUsername = currentUser;
            ucRequestClaim.CurrentFullName = GetFullName(currentUser);
            ucRequestClaim.CurrentStudentID = GetStudentID(currentUser);

            
            ucMyMatches = new UserControls.MyMatches(currentUser);

            
            ucUserHome = new UserControls.UserHome();

            
            this.Load += (s, e) =>
            {
                LoadPanel(ucUserHome);
                ucUserHome.LoadUser(currentUser);
            };
        }

        
        private void LoadPanel(UserControl uc)
        {
            try
            {
                
                foreach (Control ctrl in splitContainer1.Panel2.Controls)
                {
                    DisposeImagesIn(ctrl);
                }
                splitContainer1.Panel2.Controls.Clear();
                splitContainer1.Panel2.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading panel: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void DisposeImagesIn(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is PictureBox pic)
                {
                    Image old = pic.Image;
                    pic.Image = null;
                    old?.Dispose();
                }
                else if (ctrl.Controls.Count > 0)
                {
                    DisposeImagesIn(ctrl);
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadPanel(ucUserHome);
            ucUserHome.LoadUser(currentUser);
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
        }

        private void btnReportFound_Click(object sender, EventArgs e)
        {
            LoadPanel(ucReportFound);
        }

        private void btnReportLost_Click(object sender, EventArgs e)
        {
            LoadPanel(ucReportLost);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            LoadPanel(ucInventory);
            ucInventory.LoadItems();
        }

        private void btnMyMatches_Click(object sender, EventArgs e)
        {
            LoadPanel(ucMyMatches);
            ucMyMatches.LoadMatches();
        }

        private void btnRequestClaim_Click(object sender, EventArgs e)
        {
            LoadPanel(ucRequestClaim);
        }



        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Log Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                this.Close();
                LogIn logInForm = new LogIn();
                logInForm.Show();
            }
        }

        

        private string GetFullName(string username)
        {
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (OleDbCommand cmd2 = new OleDbCommand(
                        "SELECT [fullName] FROM [Users] WHERE [username] = ?", conn))
                    {
                        cmd2.Parameters.AddWithValue("?", username);
                        object result = cmd2.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            return result.ToString();
                    }
                }
            }
            catch { }
            return username;
        }

        private string GetStudentID(string username)
        {
            try
            {
                using (OleDbConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (OleDbCommand cmd2 = new OleDbCommand(
                        "SELECT [studentID] FROM [Users] WHERE [username] = ?", conn))
                    {
                        cmd2.Parameters.AddWithValue("?", username);
                        object result = cmd2.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            return result.ToString();
                    }
                }
            }
            catch { }
            return "";
        }
    }
}