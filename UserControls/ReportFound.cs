
using _DRAFT__OOP_2_FINAL_PROJECT;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    public partial class ReportFound : UserControl
    {
        private ItemManager itemManager;
        private string currentUser;
        private int currentUserID;
        private string selectedImagePath = "";

        
        
        public ReportFound()
        {
            InitializeComponent();
        }

        
        public ReportFound(ItemManager manager,
                           string username,
                           int userID)
        {
            InitializeComponent();
            if (DesignMode) return;

            itemManager = manager ?? throw new ArgumentNullException(nameof(manager));
            currentUser = username ?? "";
            currentUserID = userID;

            SetupForm();
        }

        

        private void SetupForm()
        {
            
            dtpDateFound.MaxDate = DateTime.Today;
            dtpDateFound.Value = DateTime.Today;

            
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(new object[]
            {
                "Electronics",
                "Clothing",
                "Accessories",
                "Books / Documents",
                "Bag / Wallet",
                "Keys",
                "ID / Cards",
                "Other"
            });

           
            cmbCategory.SelectedIndexChanged += (s, e) =>
            {
                bool isOther = cmbCategory.SelectedItem?.ToString() == "Other";
                txtCustomCategory.Visible = isOther;
                label6.Visible = isOther;
            };

            txtCustomCategory.Visible = false;
            label6.Visible = false;

            
            picPreview.BackColor = Color.WhiteSmoke;
            picPreview.SizeMode = PictureBoxSizeMode.Zoom;

            
            btnBrowse.Click += BtnBrowse_Click;
            btnCamera.Click += BtnCamera_Click;
            btnClearPhoto.Click += BtnClearPhoto_Click;
            btnSubmitFound.Click += BtnSubmitFound_Click;
            btnClearFound.Click += BtnClearFound_Click;

            
            dgvMyReports.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvMyReports.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMyReports.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvMyReports.EnableHeadersVisualStyles = false;
            dgvMyReports.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(240, 248, 255);

            

            LoadMyReports();
        }

       

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Item Photo";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    picPreview.Image = Image.FromFile(selectedImagePath);
                    lblPhotoStatus.Text = Path.GetFileName(selectedImagePath);
                    lblPhotoStatus.ForeColor = Color.DarkGreen;
                }
            }
        }



        private void BtnCamera_Click(object sender, EventArgs e)
        {
            using (CameraCapture cam = new CameraCapture())
            {
                if (cam.ShowDialog() == DialogResult.OK &&
                    !string.IsNullOrEmpty(cam.CapturedImagePath))
                {
                    selectedImagePath = cam.CapturedImagePath;
                    picPreview.Image = Image.FromFile(selectedImagePath);
                    lblPhotoStatus.Text = "Photo captured from camera";
                    lblPhotoStatus.ForeColor = Color.DarkGreen;
                }
            }
        }



        private void BtnClearPhoto_Click(object sender, EventArgs e)
        {
            
            picPreview.Image?.Dispose();
            selectedImagePath = "";
            picPreview.Image = null;
            picPreview.BackColor = Color.WhiteSmoke;
            lblPhotoStatus.Text = "No photo selected";
            lblPhotoStatus.ForeColor = Color.Gray;
        }



        private void BtnSubmitFound_Click(object sender, EventArgs e)
        {
            
            if (itemManager == null)
            {
                MessageBox.Show("itemManager is null — use the runtime constructor.",
                    "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                ShowWarning("Please enter the item name.", txtItemName);
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                ShowWarning("Please select a category.", cmbCategory);
                return;
            }

            if (cmbCategory.SelectedItem.ToString() == "Other" &&
                string.IsNullOrWhiteSpace(txtCustomCategory.Text))
            {
                ShowWarning("Please specify your custom category.", txtCustomCategory);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                ShowWarning("Please enter where you found the item.", txtLocation);
                return;
            }

            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                ShowWarning("Please enter a description.", rtbDescription);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLocationSurrendered.Text))
            {
                ShowWarning("Please enter where you are surrendering the item.", txtLocationSurrendered);
                return;
            }

            DatabaseHelper.EnsureFolderExists();


            bool success = itemManager.ReportFoundItem(
                txtItemName.Text.Trim(),
                rtbDescription.Text.Trim(),
                txtLocation.Text.Trim(),
                txtLocationSurrendered.Text.Trim(),
                dtpDateFound.Value,
                cmbCategory.SelectedItem.ToString(),
                txtCustomCategory.Text.Trim(),
                currentUser,
                currentUserID,
                selectedImagePath,
                out string newItemID,
                out string errorMessage
            );

            if (success)
            {
                
                string category = itemManager.ClassifyItem(
                    cmbCategory.SelectedItem.ToString(),
                    txtCustomCategory.Text.Trim());

                string photoLine = string.IsNullOrEmpty(selectedImagePath)
                    ? ""
                    : "\nPhoto    : Saved";

                MessageBox.Show(
                    "Found item reported successfully!\n\n" +
                    "Item ID  : " + newItemID + "\n" +
                    "Item     : " + txtItemName.Text + "\n" +
                    "Category : " + category + "\n" +
                    "Location : " + txtLocation.Text + "\n" +
                    "Date     : " + dtpDateFound.Value.ToShortDateString() +
                    photoLine,
                    "Report Submitted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                BtnClearFound_Click(sender, e);
                LoadMyReports();
            }
            else
            {
                MessageBox.Show(errorMessage, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void BtnClearFound_Click(object sender, EventArgs e)
        {
            txtItemName.Clear();
            cmbCategory.SelectedIndex = -1;
            txtCustomCategory.Clear();
            txtCustomCategory.Visible = false;
            label6.Visible = false;
            txtLocation.Clear();
            txtLocationSurrendered.Clear();
            rtbDescription.Clear();
            dtpDateFound.Value = DateTime.Today;
            BtnClearPhoto_Click(sender, e);
        }



        public void LoadMyReports()
        {
            
            if (itemManager == null) return;

            dgvMyReports.Rows.Clear();

            
            List<Item> myReports = itemManager.GetUserReports(currentUser, "Found");

            if (myReports.Count == 0)
            {
                dgvMyReports.Rows.Add("—", "No found item reports yet",
                    "—", "—", "—", "—", "—");
                return;
            }

            foreach (Item item in myReports)
            {
                int idx = dgvMyReports.Rows.Add(
                    item.ItemID,
                    item.Name,
                    item.Category,
                    item.Location,
                    item.LocationSurrendered,
                    item.Date.ToShortDateString(),
                    item.Status,
                    string.IsNullOrEmpty(item.ImagePath) ? "No" : "Yes"
                );


                DataGridViewCell cell =
                    dgvMyReports.Rows[idx].Cells["colRStatus"];
                cell.Style.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                cell.Style.ForeColor =
                    item.Status == "Returned" ? Color.DarkGreen :
                    item.Status == "Matched" ? Color.DarkOrange :
                                                Color.DodgerBlue;  
            }
        }

        

        private static void ShowWarning(string message, Control focusTarget = null)
        {
            MessageBox.Show(message, "Missing Field",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            focusTarget?.Focus();
        }

        
        private void label12_Click(object sender, EventArgs e) { }
    }
}