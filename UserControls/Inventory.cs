using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    public partial class Inventory : UserControl
    {
       
        private ItemManager itemManager = new ItemManager();
        private List<Item> allItems = new List<Item>();
        private string currentUser = "";
        private string currentRole = "admin";   
        private bool _viewingArchive = false;
        private bool _photoRestricted = false;


        
        private static readonly HashSet<string> RestrictedCategories =
        new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        { "ID / Cards", "Bag / Wallet", "Books / Documents" };

        

        public Inventory()
        {
            InitializeComponent();
        }

        public Inventory(string username, string role)
        {
            InitializeComponent();
            if (DesignMode) return;

            currentUser = username;
            currentRole = role.ToLower();

            
            picItemPhoto.Paint += PicItemPhoto_Paint;
            dgvResults.CellClick += DgvResults_CellClick;
            txtSearch.KeyDown += TxtSearch_KeyDown;

            
            chkLost.CheckedChanged += Filter_Changed;
            chkFound.CheckedChanged += Filter_Changed;
            chkSearchLocation.CheckedChanged += Filter_Changed;
            chkSearchDesc.CheckedChanged += Filter_Changed;
            chkSearchDate.CheckedChanged += Filter_Changed;
            chkMatched.CheckedChanged += Filter_Changed;


            dgvResults.ClearSelection();
            SetupForRole();
            LoadItems();
        }

        

        private void SetupForRole()
        {
            if (currentRole == "admin")
            {
                lblTitle.Text = "Inventory (Admin)";
                lblSub.Text = "All reported lost and found items";

                colItemID.Visible = true;
                colReporter.Visible = true;

                btnViewArchive.Visible = true;
                chkMatched.Visible = true;
            }
            else
            {
                lblTitle.Text = "Inventory";
                lblSub.Text = "Browse lost and found items";


                colItemID.Visible = false;
                colReporter.Visible = false;

                btnViewArchive.Visible = false;
                btnBackToInventory.Visible = false;
                chkMatched.Visible = false;
            }

            cmbFilterCategory.SelectedIndex = 0;
        }

        

        public void LoadItems()
        {
            if (_viewingArchive && currentRole == "admin")
                allItems = itemManager.GetArchivedItems();
            else
                allItems = itemManager.GetAllItems(currentRole == "admin");
            RefreshCategoryDropdown();
            ApplyFilters();
        }

        private void RefreshCategoryDropdown()
        {
            string previousSelection = cmbFilterCategory.SelectedItem?.ToString() ?? "All Categories";

            cmbFilterCategory.SelectedIndexChanged -= Filter_Changed; 
            cmbFilterCategory.Items.Clear();

            
            cmbFilterCategory.Items.Add("All Categories");

            
            var predefined = new List<string>
    {
        "Electronics", "Clothing", "Accessories", "Books / Documents",
        "Bag / Wallet", "Keys", "ID / Cards", "Other"
    };

            
            var existingInData = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (Item item in allItems)
                if (!string.IsNullOrWhiteSpace(item.Category))
                    existingInData.Add(item.Category);

            
            foreach (string cat in predefined)
                if (existingInData.Contains(cat))
                    cmbFilterCategory.Items.Add(cat);

            
            foreach (string cat in existingInData)
                if (!predefined.Contains(cat) && cat != "All Categories")
                    cmbFilterCategory.Items.Add(cat + " *"); 

            
            if (cmbFilterCategory.Items.Contains(previousSelection))
                cmbFilterCategory.SelectedItem = previousSelection;
            else
                cmbFilterCategory.SelectedIndex = 0;

            cmbFilterCategory.SelectedIndexChanged += Filter_Changed; 
        }

        private void ApplyFilters()
        {
            string rawSearch = txtSearch.Text.Trim().ToLower();
            string category = cmbFilterCategory.Text.Trim().TrimEnd(' ', '*');
            string selectedCategory = string.IsNullOrWhiteSpace(category) ? "All Categories" : category;
            bool filterLost = chkLost.Checked;
            bool filterFound = chkFound.Checked;
            bool searchInLocation = chkSearchLocation.Checked;
            bool searchInDesc = chkSearchDesc.Checked;
            bool searchInDate = chkSearchDate.Checked;

            
            string[] tokens = rawSearch.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            dgvResults.Rows.Clear();

            foreach (Item item in allItems)
            {

                bool filterMatched = chkMatched.Checked;

                
                if (currentRole != "admin" && item.Status == "Matched")
                    continue;

                if (filterLost || filterFound || filterMatched)
                {
                    bool show = (filterLost && item.Status == "Lost") ||
                                (filterFound && item.Status == "Found") ||
                                (filterMatched && item.Status == "Matched");
                    if (!show) continue;
                }

                
                if (filterLost || filterFound)
                {
                    bool show = (filterLost && item.Status == "Lost") ||
                                (filterFound && item.Status == "Found");
                    if (!show) continue;
                }

                
                if (!string.IsNullOrWhiteSpace(selectedCategory) &&
                    selectedCategory != "All Categories" &&
                    !item.Category.Equals(selectedCategory, StringComparison.OrdinalIgnoreCase))
                    continue;

                
                if (tokens.Length > 0)
                {
                    bool allTokensMatch = true;

                    foreach (string token in tokens)
                    {
                        
                        bool matchName = item.Name.ToLower().Contains(token);

                        
                        bool matchLoc = searchInLocation && item.Location.ToLower().Contains(token);
                        bool matchDesc = searchInDesc && item.Description.ToLower().Contains(token);

                        
                        bool matchDate = searchInDate && (
                            item.Date.ToShortDateString().Contains(token) ||
                            item.Date.ToString("M/d/yyyy").Contains(token) ||
                            item.Date.ToString("MM/dd/yyyy").Contains(token) ||
                            item.Date.ToString("yyyy-MM-dd").Contains(token) ||
                            item.Date.ToString("MMMM d, yyyy").ToLower().Contains(token) ||
                            item.Date.ToString("MMM d, yyyy").ToLower().Contains(token) ||
                            item.Date.ToString("MMMM").ToLower().Contains(token) ||
                            item.Date.ToString("MMM").ToLower().Contains(token) ||
                            item.Date.Day.ToString().Contains(token) ||
                            item.Date.Year.ToString().Contains(token)
                        );

                        if (!matchName && !matchLoc && !matchDesc && !matchDate)
                        {
                            allTokensMatch = false;
                            break;
                        }
                    }

                    if (!allTokensMatch) continue;
                }

                
                string reporterDisplay = (currentRole == "admin") ? item.Reporter : "[Hidden]";

                string descDisplay = (currentRole == "admin")
                    ? item.Description
                    : RestrictedCategories.Contains(item.Category)
                        ? "[Restricted]"
                        : item.Description;

                int rowIndex = dgvResults.Rows.Add(
                    item.ItemID,
                    item.Name,
                    item.Category,
                    item.Location,
                    item.Date.ToShortDateString(),
                    item.Status,
                    reporterDisplay,
                    descDisplay
                );

                dgvResults.Rows[rowIndex].Tag = item.ItemID;

                Color statusColor =
                    item.Status == "Lost" ? Color.Crimson :
                    item.Status == "Archived" ? Color.Gray : Color.DarkGreen;

                dgvResults.Rows[rowIndex].Cells["colStatus"].Style.ForeColor = statusColor;
                dgvResults.Rows[rowIndex].Cells["colStatus"].Style.Font =
                    new Font("Letters for Learners", 11F, FontStyle.Bold);
            }

            if (dgvResults.Rows.Count == 0)
            {
                dgvResults.ClearSelection();
                HideDetail();
            }
        }

        

        private void ShowDetail(Item item)
        {
            bool isRestricted = RestrictedCategories.Contains(item.Category);

            lblDetailTitle.Text = item.Name;
            lblDetailID.Text = "ID: " + item.ItemID;
            lblDetailDate.Text = "📅 " + item.Date.ToShortDateString();
            lblDetailLocation.Text = "📍 " + item.Location;
            lblDetailCategory.Text = "📦 " + item.Category;
            lblDetailStatus.Text = "Status: " + item.Status;

            lblDetailStatus.ForeColor =
                item.Status == "Lost"     ? Color.Crimson :
                item.Status == "Archived" ? Color.Gray    :
                                            Color.DarkGreen;

            if (currentRole == "admin")
            {
                lblDetailReporter.Text = "👤 Reporter: " + item.Reporter;
                lblDetailDesc.Text = "Description:\n" + item.Description;
                _photoRestricted = false;
            }
            else if (isRestricted)
            {
                lblDetailReporter.Text = "👤 Reporter: [Hidden]";
                lblDetailDesc.Text = "Description: [Restricted — visit the lost & found office]";
                _photoRestricted = true;
            }
            else if (item.Status == "Lost")
            {
                lblDetailReporter.Text = "👤 Reporter: [Hidden]";
                lblDetailDesc.Text = "Description:\n" + item.Description;
                _photoRestricted = true;
            }
            else
            {
                lblDetailReporter.Text = "👤 Reporter: [Hidden]";
                lblDetailDesc.Text = "Description:\n" + item.Description;
                _photoRestricted = false;
            }


            if (currentRole == "admin" && item.Status == "Matched")
            {
                System.Data.DataRow match = itemManager.GetMatchInfoForItem(item.ItemID);
                if (match != null)
                {
                    bool isLost = item.ItemID == match["lostItemID"].ToString();
                    string partnerName     = isLost ? match["foundName"].ToString()     : match["lostName"].ToString();
                    string partnerReporter = isLost ? match["foundReporter"].ToString() : match["lostReporter"].ToString();
                    string partnerRole     = isLost ? "Found" : "Lost";
                    string matchDate       = match["matchDate"] != DBNull.Value
                        ? Convert.ToDateTime(match["matchDate"]).ToString("MMM dd, yyyy") : "—";
                    string remarks         = match["remarks"]?.ToString() ?? "";

                    string matchInfo =
                        $"\n──────────────────────\n" +
                        $"🔗 Matched with ({partnerRole} item):\n" +
                        $"   {partnerName}  [{(isLost ? match["foundItemID"] : match["lostItemID"])}]\n" +
                        $"   Reporter: {partnerReporter}\n" +
                        $"   Match Date: {matchDate}\n" +
                        (string.IsNullOrWhiteSpace(remarks) ? "" : $"   Remarks: {remarks}");

                    lblDetailDesc.Text += matchInfo;
                }
            }

           
            if (currentRole == "admin" && item.Status == "Archived")
            {
                var (reason, adminName) = itemManager.GetArchiveInfoForItem(item.ItemID);
                string archiveInfo =
                    $"\n──────────────────────\n" +
                    $"📦 Archived by: {(string.IsNullOrWhiteSpace(adminName) ? "—" : adminName)}\n" +
                    (string.IsNullOrWhiteSpace(reason) ? "" : $"   Reason: {reason}");
                lblDetailDesc.Text += archiveInfo;
            }

            
            Image oldImage = picItemPhoto.Image;
            picItemPhoto.Image = null;
            oldImage?.Dispose();

            picItemPhoto.BackColor = _photoRestricted ? Color.LightGray : Color.WhiteSmoke;

            if (!_photoRestricted &&
                !string.IsNullOrEmpty(item.ImagePath) &&
                File.Exists(item.ImagePath))
            {
                try
                {
                    using (var fs = new FileStream(item.ImagePath, FileMode.Open, FileAccess.Read))
                        picItemPhoto.Image = Image.FromStream(fs);
                }
                catch { picItemPhoto.Image = null; }
            }

            picItemPhoto.Invalidate();

            if (panelDetail.Parent != this)
                this.Controls.Add(panelDetail);

            panelDetail.Visible = true;
            this.Controls.SetChildIndex(panelDetail, 0);
            panelDetail.BringToFront();
        }

        private void HideDetail()
        {
            panelDetail.Visible = false;
            
            Image oldImage = picItemPhoto.Image;
            picItemPhoto.Image = null;
            oldImage?.Dispose();
            _photoRestricted = false;
        }

        

        private Item GetSelectedItem()
        {
            if (dgvResults.CurrentRow == null) return null;

            string itemID = dgvResults.CurrentRow.Tag?.ToString();
            if (string.IsNullOrWhiteSpace(itemID)) return null;

            return allItems.Find(i => i.ItemID == itemID);
        }

        

        private void BtnSearch_Click(object sender, EventArgs e)
            => ApplyFilters();

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ApplyFilters();
        }

        private void Filter_Changed(object sender, EventArgs e)
            => ApplyFilters();

        private void BtnClearFilters_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            chkLost.Checked = false;
            chkFound.Checked = false;
            cmbFilterCategory.SelectedIndex = 0;
            chkSearchLocation.Checked = false;
            chkSearchDesc.Checked = false;
            chkSearchDate.Checked = false;
            chkMatched.Checked = false;
            HideDetail();
            ApplyFilters();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            HideDetail();
            LoadItems();
        }

        

        private void BtnViewArchive_Click(object sender, EventArgs e)
        {
            _viewingArchive = !_viewingArchive;

            btnViewArchive.Text = _viewingArchive ? "View Active" : "View Archive";
            lblSub.Text = _viewingArchive
                ? "Showing archived items (Admin View)"
                : "All reported lost and found items";

            chkLost.Checked = false;
            chkFound.Checked = false;

            HideDetail();
            LoadItems();
        }

        private void DgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string itemID = dgvResults.Rows[e.RowIndex].Tag?.ToString();
            if (string.IsNullOrWhiteSpace(itemID)) { HideDetail(); return; }

            Item selected = allItems.Find(i => i.ItemID == itemID);
            if (selected == null) { HideDetail(); return; }

            ShowDetail(selected);
        }

        private void BtnCloseDetail_Click(object sender, EventArgs e)
            => HideDetail();

        private void btnBackToInventory_Click(object sender, EventArgs e)
        {
            _viewingArchive = false;
            btnViewArchive.Text = "View Archive";
            lblSub.Text = currentRole == "admin"
                ? "All reported lost and found items"
                : "Browse lost and found items";
            HideDetail();
            LoadItems();
        }

        

        private void PicItemPhoto_Paint(object sender, PaintEventArgs e)
        {
            if (_photoRestricted)
            {
                string msg = "🔒 Photo Restricted";
                using Font f = new Font("Segoe UI", 10F, FontStyle.Italic);
                SizeF sz = e.Graphics.MeasureString(msg, f);
                float x = (picItemPhoto.Width - sz.Width) / 2;
                float y = (picItemPhoto.Height - sz.Height) / 2;
                e.Graphics.DrawString(msg, f, Brushes.Gray, x, y);
            }
        }

    }
}