using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    public partial class PhotoGallery : UserControl
    {
        private List<Item> _foundItems = new List<Item>();
        private readonly ItemManager _itemManager = new ItemManager();

        public PhotoGallery()
        {
            InitializeComponent();
            this.Load += PhotoGallery_Load;
        }

        private void PhotoGallery_Load(object sender, EventArgs e)
        {
            LoadGallery();
        }

        public void LoadGallery()
        {
            
            foreach (Control card in flowPanel.Controls)
                foreach (Control ctrl in card.Controls)
                    if (ctrl is PictureBox pb) { Image old = pb.Image; pb.Image = null; old?.Dispose(); }

            flowPanel.Controls.Clear();
            _foundItems = _itemManager.GetFoundItemsForMatching();

            if (_foundItems.Count == 0)
            {
                Label empty = new Label
                {
                    Text = "No found item reports with photos yet.",
                    Font = new Font("Segoe UI", 13F),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Margin = new Padding(20)
                };
                flowPanel.Controls.Add(empty);
                return;
            }

            foreach (Item item in _foundItems)
            {
                Panel card = BuildCard(item);
                flowPanel.Controls.Add(card);
            }
        }

        private Panel BuildCard(Item item)
        {
            Panel card = new Panel
            {
                Width = 200,
                Height = 240,
                Margin = new Padding(10),
                BackColor = Color.White,
                Cursor = Cursors.Hand,
                Tag = item
            };

            
            card.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
                    Color.FromArgb(200, 200, 200), ButtonBorderStyle.Solid);
            };

            
            PictureBox pb = new PictureBox
            {
                Width = 200,
                Height = 160,
                Location = new Point(0, 0),
                SizeMode = PictureMode(item.ImagePath),
                BackColor = Color.FromArgb(240, 240, 240)
            };
            TryLoadImage(pb, item.ImagePath);

            
            Label lblName = new Label
            {
                Text = item.Name,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(50, 50, 50),
                Location = new Point(5, 165),
                Width = 190,
                Height = 20,
                AutoEllipsis = true
            };

            
            Label lblLoc = new Label
            {
                Text = "📍 " + item.Location,
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.Gray,
                Location = new Point(5, 185),
                Width = 190,
                Height = 18,
                AutoEllipsis = true
            };

            
            Label lblDate = new Label
            {
                Text = "📅 " + item.Date.ToString("MMM dd, yyyy"),
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.Gray,
                Location = new Point(5, 203),
                Width = 190,
                Height = 18
            };

            
            Label lblCat = new Label
            {
                Text = item.Category,
                Font = new Font("Segoe UI", 7.5F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(107, 21, 38),
                Location = new Point(5, 222),
                AutoSize = true,
                Padding = new Padding(3, 1, 3, 1)
            };

            card.Controls.AddRange(new Control[] { pb, lblName, lblLoc, lblDate, lblCat });

            
            EventHandler clickHandler = (s, e) => ShowDetail(item);
            card.Click += clickHandler;
            pb.Click += clickHandler;
            lblName.Click += clickHandler;
            lblLoc.Click += clickHandler;
            lblDate.Click += clickHandler;
            lblCat.Click += clickHandler;

            return card;
        }

        private PictureBoxSizeMode PictureMode(string path)
        {
            return (string.IsNullOrEmpty(path) || !File.Exists(path))
                ? PictureBoxSizeMode.CenterImage
                : PictureBoxSizeMode.Zoom;
        }

        private void TryLoadImage(PictureBox pb, string path)
        {
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                try
                {
                    
                    using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        pb.Image = Image.FromStream(fs);
                    }
                    return;
                }
                catch { }
            }
            
            Bitmap bmp = new Bitmap(200, 160);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.FromArgb(230, 230, 230));
                g.DrawString("No Photo", new Font("Segoe UI", 10F),
                    Brushes.Gray, new PointF(60, 65));
            }
            pb.Image = bmp;
        }

        private void ShowDetail(Item item)
        {
            Form detail = new Form
            {
                Text = "Found Item Details — " + item.Name,
                Size = new Size(520, 560),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                BackColor = Color.White
            };

            Panel scrollContainer = new Panel
            {
                Location = new Point(0, 0),
                Size = new Size(520, 500),
                AutoScroll = true
            };
            detail.Controls.Add(scrollContainer);
            
            PictureBox pic = new PictureBox
            {
                Size = new Size(480, 220),
                Location = new Point(15, 15),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(240, 240, 240)
            };
            TryLoadImage(pic, item.ImagePath);
            scrollContainer.Controls.Add(pic);

            
            Panel info = new Panel
            {
                Location = new Point(15, 245),
                Size = new Size(480, 260),
                BackColor = Color.White,
                AutoScroll = true
            };

            
            int y = 0;
            AddDetailRow(info, "Item ID",     item.ItemID,                    ref y);
            AddDetailRow(info, "Name",        item.Name,                      ref y);
            AddDetailRow(info, "Category",    item.Category,                  ref y);
            AddDetailRow(info, "Description", item.Description,               ref y);
            AddDetailRow(info, "Location",    item.Location,                  ref y);
            AddDetailRow(info, "Date Found",  item.Date.ToString("MMMM dd, yyyy"), ref y);
            AddDetailRow(info, "Reporter",    item.Reporter,                  ref y);
            AddDetailRow(info, "Status",      item.Status,                    ref y);

            scrollContainer.Controls.Add(info);

            Button btnClose = new Button
            {
                Text = "Close",
                Size = new Size(100, 35),
                BackColor = Color.FromArgb(107, 21, 38),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold)
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => detail.Close();
            detail.Controls.Add(btnClose);
            btnClose.Location = new Point(195, 480);
            btnClose.BringToFront(); 

            detail.ShowDialog();
        }

        private void AddDetailRow(Panel parent, string label, string value, ref int y)
        {
            Label lbl = new Label
            {
                Text = label + ":",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(107, 21, 38),
                Location = new Point(0, y),
                Size = new Size(110, 20)
            };
            Label val = new Label
            {
                Text = string.IsNullOrWhiteSpace(value) ? "—" : value,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(40, 40, 40),
                Location = new Point(115, y),
                Size = new Size(360, 20),
                AutoEllipsis = true
            };
            parent.Controls.Add(lbl);
            parent.Controls.Add(val);
            y += 28;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadGallery();
        }
    }
}
