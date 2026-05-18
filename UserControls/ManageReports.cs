using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    public partial class ManageReports : UserControl
    {
        
        private UserControls.MatchReports ucMatchReports;
        private UserControls.ReportFound ucReportFound;
        private UserControls.ReportLost ucReportLost;
        private UserControls.ArchiveReports ucArchiveReports;
        private readonly ItemManager _itemManager = new ItemManager();
        private string _username;
        private int _userID;

        
        public ManageReports()
        {
            InitializeComponent();
        }

        public ManageReports(string username, int userID)
        {
            InitializeComponent();
            if (DesignMode) return;
            _username = username;
            _userID = userID;
            ucReportFound = new UserControls.ReportFound(_itemManager, _username, _userID);
            ucMatchReports = new UserControls.MatchReports();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                panel3.Controls.Clear();
                ucReportFound ??= new UserControls.ReportFound(_itemManager, _username, _userID);
                panel3.Controls.Add(ucReportFound);
                ucReportFound.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Report Found: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                panel3.Controls.Clear();
                ucReportLost ??= new UserControls.ReportLost(_itemManager, _username, _userID);
                panel3.Controls.Add(ucReportLost);
                ucReportLost.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Report Lost: " + ex.Message);
            }
        }

        private void btnMatchReports_Click(object sender, EventArgs e)
        {
            try
            {
                panel3.Controls.Clear();
                ucMatchReports ??= new UserControls.MatchReports();
                panel3.Controls.Add(ucMatchReports);
                ucMatchReports.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Match Reports: " + ex.Message);
            }
        }

        private void btnArchiveReport_Click(object sender, EventArgs e)
        {
            try
            {
                panel3.Controls.Clear();
                ucArchiveReports ??= new UserControls.ArchiveReports();
                panel3.Controls.Add(ucArchiveReports);
                ucArchiveReports.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Archive Reports: " + ex.Message);
            }
        }
    }
}