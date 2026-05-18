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
    public partial class Retriever : Form
    {
        private UserControls.ManageReports ucManageReports;
        UserControls.ManageRequests ucManageRequests = new UserControls.ManageRequests();
        UserControls.AdminHome ucAdminHome = new UserControls.AdminHome();
        UserControls.MatchReports ucMatchReports = new UserControls.MatchReports();
        UserControls.Inventory ucInventory;
        UserControls.PhotoGallery ucPhotoGallery = new UserControls.PhotoGallery();

        private ItemManager itemManager = new ItemManager();
        private AccountManager AccountManager = new AccountManager();
        private UserControls.ReportLost ucReportLost;
        private string currentUser;
        private int currentUserID;

        public Retriever(string username, int userID)
        {
            InitializeComponent();
            currentUser = username;
            currentUserID = userID;
            ucReportLost = new UserControls.ReportLost(itemManager, currentUser, currentUserID);
            ucManageReports = new UserControls.ManageReports(currentUser, currentUserID);
            ucInventory = new UserControls.Inventory(currentUser, "admin");
            ucAdminHome.LoadAdmin(currentUser);
            LoadPanel(ucAdminHome);
        }

        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;



        
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

        private void btnLogo_Click(object sender, EventArgs e)
        {
            LoadPanel(ucAdminHome);
        }

        private void btnManagReports_Click(object sender, EventArgs e)
        {
            LoadPanel(ucManageReports);
        }

        private void btnManageRequests_Click(object sender, EventArgs e)
        {
            LoadPanel(ucManageRequests);
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadPanel(ucAdminHome);
            ucAdminHome.LoadAnalytics();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            LoadPanel(ucInventory);
        }

        private void btnMatchReports_Click(object sender, EventArgs e)
        {
            LoadPanel(ucMatchReports);
        }

        private void btnPhotoGallery_Click(object sender, EventArgs e)
        {
            try
            {
                ucPhotoGallery.LoadGallery();
                LoadPanel(ucPhotoGallery);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Photo Gallery: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
