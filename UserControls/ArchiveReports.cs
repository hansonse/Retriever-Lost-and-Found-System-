using System;
using System.Data;
using System.Windows.Forms;

namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    public partial class ArchiveReports : UserControl
    {
        private ItemManager manager = new ItemManager();
        private string selectedItemID = "";

        public ArchiveReports()
        {
            InitializeComponent();
            LoadItems();
        }

       
        private void LoadItems()
        {
            dgvItems.DataSource = manager.GetAllItems();
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvItems.Rows[e.RowIndex];

                selectedItemID = row.Cells["itemID"].Value.ToString();

                lblSelected.Text = "Selected ID: " + selectedItemID;
            }
        }

        
        private void btnArchive_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedItemID))
            {
                MessageBox.Show("Please select an item first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                MessageBox.Show("Please enter an archive reason.");
                return;
            }

            string adminName = Environment.UserName;

            string error;

            bool success = manager.ArchiveItem(
                selectedItemID,
                adminName,
                txtReason.Text,
                out error
            );

            if (success)
            {
                MessageBox.Show("Item archived successfully.");

                txtReason.Clear();
                selectedItemID = "";
                lblSelected.Text = "Selected ID: None";

                LoadItems();
            }
            else
            {
                MessageBox.Show(error);
            }
        }
    }
}