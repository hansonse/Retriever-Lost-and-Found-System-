using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using _DRAFT__OOP_2_FINAL_PROJECT;

namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    public partial class RequestClaim : UserControl
    {
        public string CurrentUsername { get; set; } = "";
        public string CurrentFullName { get; set; } = "";
        public string CurrentStudentID { get; set; } = "";

        private readonly ClaimRequestManager _manager = new ClaimRequestManager();
        private readonly ItemManager _itemManager = new ItemManager();

        private List<Item> _allFoundItems = new List<Item>();

        private string _selectedItemId = "";
        private string _selectedItemName = "";
        private string _selectedCategory = "";
        private string _selectedLocation = "";
        private DateTime _selectedDateFound = DateTime.MinValue;

        public RequestClaim()
        {
            InitializeComponent();
            if (DesignMode) return;

            SetupGrid();
            WireEvents();
            LoadFoundItems();
        }

        private void SetupGrid()
        {
            dgvFoundItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoundItems.MultiSelect = false;
            dgvFoundItems.ReadOnly = true;
        }

        private void WireEvents()
        {
            dgvFoundItems.SelectionChanged += DgvFoundItems_SelectionChanged;
            btnSubmitClaim.Click += BtnSubmitClaim_Click;
            btnClear.Click += BtnClear_Click;
            btnMyClaimSlip.Click += BtnMyClaimSlip_Click;
            cbxCategories.SelectedIndexChanged += CbxCategories_Changed;
        }

        private void LoadFoundItems()
        {
            _allFoundItems = _itemManager.GetFoundItemsForMatching();

            cbxCategories.SelectedIndexChanged -= CbxCategories_Changed;
            cbxCategories.Items.Clear();
            cbxCategories.Items.Add("All Categories");

            HashSet<string> seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (Item item in _allFoundItems)
            {
                if (!string.IsNullOrWhiteSpace(item.Category) && seen.Add(item.Category))
                {
                    cbxCategories.Items.Add(item.Category);
                }
            }

            cbxCategories.SelectedIndex = 0;
            cbxCategories.SelectedIndexChanged += CbxCategories_Changed;

            ClearSelection();
            ApplyCategoryFilter();
        }

        private void ApplyCategoryFilter()
        {
            string selected = cbxCategories.SelectedItem?.ToString() ?? "All Categories";
            bool showAll = selected == "All Categories";

            dgvFoundItems.Rows.Clear();

            foreach (Item item in _allFoundItems)
            {
                if (!showAll &&
                    !item.Category.Equals(selected, StringComparison.OrdinalIgnoreCase))
                    continue;

                int idx = dgvFoundItems.Rows.Add(
                    item.ItemID,
                    item.Name,
                    item.Category,
                    item.Location,
                    item.Date == DateTime.MinValue ? "" : item.Date.ToString("MMM d, yyyy")
                );

                dgvFoundItems.Rows[idx].Tag = item;
            }

            if (dgvFoundItems.Rows.Count == 0)
                dgvFoundItems.Rows.Add("", "No found items.", "", "", "");
        }

        private void CbxCategories_Changed(object sender, EventArgs e)
        {
            ApplyCategoryFilter();
        }

        private void DgvFoundItems_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFoundItems.CurrentRow == null) return;

            Item item = dgvFoundItems.CurrentRow.Tag as Item;
            if (item == null)
            {
                ClearSelection();
                return;
            }

            _selectedItemId = item.ItemID;
            _selectedItemName = item.Name;
            _selectedCategory = item.Category;
            _selectedLocation = item.Location;
            _selectedDateFound = item.Date;

            lblSelectedItem.Text = $"Selected: {item.Name}  ({item.ItemID})";
            lblSelectedItem.ForeColor = Color.Maroon;
        }

        private void BtnSubmitClaim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedItemId))
            {
                MessageBox.Show("Please select an item from the list first.");
                return;
            }

            if (string.IsNullOrEmpty(CurrentUsername))
            {
                MessageBox.Show("User session not set. Please log in again.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Submit a claim request for \"{_selectedItemName}\"?",
                "Confirm Claim",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            string userMessage = richTextBox1.Text.Trim();

            string requestID = _manager.SubmitRequest(
                itemID: _selectedItemId,
                itemName: _selectedItemName,
                category: _selectedCategory,
                location: _selectedLocation,
                dateFound: _selectedDateFound,
                username: CurrentUsername,
                fullName: CurrentFullName,
                studentID: CurrentStudentID,
                userMessage: userMessage,
                errorMessage: out string err
            );

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err);
                return;
            }

            ClaimRequest req = new ClaimRequest(
                requestID,
                _selectedItemId,
                _selectedItemName,
                _selectedCategory,
                _selectedLocation,
                _selectedDateFound,
                CurrentUsername,
                CurrentFullName,
                CurrentStudentID,
                DateTime.Now,
                "Pending",
                userMessage
            );

            ClaimSlipForm.ShowSlip(req, this);

            BtnClear_Click(null, null);
            LoadFoundItems();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearSelection();
            richTextBox1.Clear();
            dgvFoundItems.ClearSelection();
        }

        private void ClearSelection()
        {
            _selectedItemId = "";
            _selectedItemName = "";
            _selectedCategory = "";
            _selectedLocation = "";
            _selectedDateFound = DateTime.MinValue;

            lblSelectedItem.Text = "No item selected";
            lblSelectedItem.ForeColor = Color.Gray;
        }

        private void BtnMyClaimSlip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentUsername))
            {
                MessageBox.Show("User session not set.");
                return;
            }

            List<ClaimRequest> myRequests = _manager.GetRequestsByUser(CurrentUsername);

            if (myRequests.Count == 0)
            {
                MessageBox.Show("You have no claim requests yet.");
                return;
            }

            using (var picker = new ClaimSlipRecordsForm(myRequests, this))
                picker.ShowDialog(this);
        }
    }
}