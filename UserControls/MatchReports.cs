using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    public partial class MatchReports : UserControl
    {
        
        private readonly ItemManager _itemMgr = new ItemManager();
        private List<Item> _lostItems = new List<Item>();
        private List<Item> _foundItems = new List<Item>();

        private Item _selectedLost = null;
        private Item _selectedFound = null;

        
        public MatchReports()
        {
            InitializeComponent();
            if (DesignMode) return;

            WireEvents();
            LoadItems();
        }

        
        private void WireEvents()
        {
            txtSearchLost.TextChanged  += (s, e) => FilterLost();
            txtSearchFound.TextChanged += (s, e) => FilterFound();

            
            dgvLostItems.CellClick  += DgvLostItems_CellClick;
            dgvFoundItems.CellClick += DgvFoundItems_CellClick;

            btnSelect.Click       += BtnSelect_Click;
            btnClear.Click        += BtnClear_Click;
            btnConfirmMatch.Click += BtnConfirmMatch_Click;
        }

        
        private void LoadItems()
        {
            _lostItems = _itemMgr.GetLostItemsForMatching();
            _foundItems = _itemMgr.GetFoundItemsForMatching();
            FilterLost();
            FilterFound();
        }

        
        private void FilterLost()
        {
            string q = txtSearchLost.Text.Trim().ToLower();
            dgvLostItems.Rows.Clear();

            foreach (Item item in _lostItems)
            {
                if (!string.IsNullOrEmpty(q) &&
                    !item.Name.ToLower().Contains(q) &&
                    !item.Category.ToLower().Contains(q))
                    continue;

                dgvLostItems.Rows.Add(
                    item.ItemID,
                    item.Name,
                    item.Category,
                    item.Date.ToShortDateString()
                );
            }

            if (dgvLostItems.Rows.Count == 0)
                dgvLostItems.Rows.Add("", "No items.", "", "");
        }

        
        private void FilterFound()
        {
            string q = txtSearchFound.Text.Trim().ToLower();
            dgvFoundItems.Rows.Clear();

            foreach (Item item in _foundItems)
            {
                if (!string.IsNullOrEmpty(q) &&
                    !item.Name.ToLower().Contains(q) &&
                    !item.Category.ToLower().Contains(q))
                    continue;

                dgvFoundItems.Rows.Add(
                    item.ItemID,
                    item.Name,
                    item.Category,
                    item.Date.ToShortDateString()
                );
            }

            if (dgvFoundItems.Rows.Count == 0)
                dgvFoundItems.Rows.Add("", "No items.", "", "");
        }

        
        private void DgvLostItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string id = dgvLostItems.Rows[e.RowIndex]
                                    .Cells["LostID"].Value?.ToString() ?? "";
            Item item = _lostItems.Find(i => i.ItemID == id);
            if (item != null)
                ShowLostDetail(item);   
        }

        
        private void DgvFoundItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string id = dgvFoundItems.Rows[e.RowIndex]
                                     .Cells["colFoundID"].Value?.ToString() ?? "";
            Item item = _foundItems.Find(i => i.ItemID == id);
            if (item != null)
                ShowFoundDetail(item);  
        }

        
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            
            if (dgvLostItems.CurrentRow != null)
            {
                string id = dgvLostItems.CurrentRow
                                        .Cells["LostID"].Value?.ToString() ?? "";
                Item item = _lostItems.Find(i => i.ItemID == id);
                if (item != null)
                {
                    _selectedLost = item;
                    ShowLostDetail(item);
                    
                    dgvLostItems.CurrentRow.DefaultCellStyle.BackColor =
                        Color.PaleGreen;
                }
            }

            
            if (dgvFoundItems.CurrentRow != null)
            {
                string id = dgvFoundItems.CurrentRow
                                         .Cells["colFoundID"].Value?.ToString() ?? "";
                Item item = _foundItems.Find(i => i.ItemID == id);
                if (item != null)
                {
                    _selectedFound = item;
                    ShowFoundDetail(item);
                    dgvFoundItems.CurrentRow.DefaultCellStyle.BackColor =
                        Color.PaleGreen;
                }
            }

            UpdateConfirmButton();
        }

        
        private void BtnClear_Click(object sender, EventArgs e)
        {
            _selectedLost  = null;
            _selectedFound = null;
            txtRemarks.Clear();
            ClearLostDetail();
            ClearFoundDetail();
            UpdateConfirmButton();

            
            foreach (DataGridViewRow row in dgvLostItems.Rows)
                row.DefaultCellStyle.BackColor = Color.Empty;
            foreach (DataGridViewRow row in dgvFoundItems.Rows)
                row.DefaultCellStyle.BackColor = Color.Empty;
        }

        
        private void ShowLostDetail(Item item)
        {
            lblLostName.Text = "Name:     " + item.Name;
            lblLostDate.Text = "Date:     " + item.Date.ToShortDateString();
            lblLostLocation.Text = "Location: " + item.Location;
            lblLostCategory.Text = "Category: " + item.Category;
            lblLostReporter.Text = "Reporter: " + item.Reporter;

            
            Image oldLost = picLost.Image;
            picLost.Image = null;
            oldLost?.Dispose();
            picLost.BackColor = Color.WhiteSmoke;

            if (!string.IsNullOrEmpty(item.ImagePath) && File.Exists(item.ImagePath))
            {
                try
                {
                    using (var fs = new FileStream(item.ImagePath, FileMode.Open, FileAccess.Read))
                        picLost.Image = Image.FromStream(fs);
                }
                catch { DrawNoPhoto(picLost); }
            }
            else { DrawNoPhoto(picLost); }
        }

        
        private void ShowFoundDetail(Item item)
        {
            lblFoundName.Text = "Name:     " + item.Name;
            lblFoundDate.Text = "Date:     " + item.Date.ToShortDateString();
            lblFoundLocation.Text = "Location: " + item.Location;
            lblFoundCategory.Text = "Category: " + item.Category;
            lblFoundReporter.Text = "Reporter: " + item.Reporter;

            
            Image oldFound = picFound.Image;
            picFound.Image = null;
            oldFound?.Dispose();
            picFound.BackColor = Color.WhiteSmoke;

            if (!string.IsNullOrEmpty(item.ImagePath) && File.Exists(item.ImagePath))
            {
                try
                {
                    using (var fs = new FileStream(item.ImagePath, FileMode.Open, FileAccess.Read))
                        picFound.Image = Image.FromStream(fs);
                }
                catch { DrawNoPhoto(picFound); }
            }
            else { DrawNoPhoto(picFound); }
        }

        
        private void DrawNoPhoto(PictureBox pic)
        {
            pic.Image = null;
            pic.BackColor = Color.LightGray;

            Bitmap bmp = new Bitmap(pic.Width, pic.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGray);
                using Font f = new Font("Segoe UI", 8F, FontStyle.Italic);
                string msg = "No Photo";
                SizeF sz = g.MeasureString(msg, f);
                g.DrawString(msg, f, Brushes.Gray,
                             (bmp.Width - sz.Width) / 2,
                             (bmp.Height - sz.Height) / 2);
            }
            pic.Image = bmp;
        }

        
        private void ClearLostDetail()
        {
            lblLostName.Text = "Name: —";
            lblLostDate.Text = "Date: —";
            lblLostLocation.Text = "Location: —";
            lblLostCategory.Text = "Category: —";
            lblLostReporter.Text = "Reporter: —";
            Image old = picLost.Image; picLost.Image = null; old?.Dispose();
            picLost.BackColor = Color.WhiteSmoke;
        }

        private void ClearFoundDetail()
        {
            lblFoundName.Text = "Name: —";
            lblFoundDate.Text = "Date: —";
            lblFoundLocation.Text = "Location: —";
            lblFoundCategory.Text = "Category: —";
            lblFoundReporter.Text = "Reporter: —";
            Image old = picFound.Image; picFound.Image = null; old?.Dispose();
            picFound.BackColor = Color.WhiteSmoke;
        }

        
        private void UpdateConfirmButton()
        {
            btnConfirmMatch.Enabled = (_selectedLost != null && _selectedFound != null);
            btnConfirmMatch.BackColor = btnConfirmMatch.Enabled
                ? Color.SeaGreen
                : Color.Gray;
        }

        
        private void BtnConfirmMatch_Click(object sender, EventArgs e)
        {
            if (_selectedLost == null || _selectedFound == null)
            {
                MessageBox.Show("Select both a lost item and a found item first.",
                    "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string remarks = txtRemarks.Text.Trim();

            DialogResult confirm = MessageBox.Show(
                $"Confirm match?\n\n" +
                $"  Lost  : {_selectedLost.Name}  ({_selectedLost.ItemID})\n" +
                $"  Found : {_selectedFound.Name}  ({_selectedFound.ItemID})\n\n" +
                (string.IsNullOrEmpty(remarks) ? "" : $"  Remarks: {remarks}\n"),
                "Confirm Match",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            
            bool success = _itemMgr.CreateMatchByStringID(
                _selectedLost.ItemID,
                _selectedFound.ItemID,
                "admin",           
                remarks,
                out string error);

            if (success)
            {
                MessageBox.Show("Match created successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                BtnClear_Click(null, null);
                LoadItems();
            }
            else
            {
                MessageBox.Show("Failed to create match:\n" + error,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}