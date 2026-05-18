using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using WinColor = System.Drawing.Color;
using WinSize  = System.Drawing.Size;

namespace _DRAFT__OOP_2_FINAL_PROJECT
{
    public class ClaimSlipForm : Form
    {
        private readonly ClaimRequest _req;

        private Panel  pnlSlip;
        private Label  lblFormTitle, lblSubtitle, lblStatus;
        private Panel  pnlDivider;
        private Label  lblRequestID, lblDateFiled;
        private Label  lblItemSection, lblItemID, lblItemName, lblCategory, lblLocation, lblDateFound;
        private Label  lblRequesterSection, lblFullName, lblStudentID, lblUsername;
        private Label  lblRemarksSection, lblRemarks;
        private Button btnPrint, btnClose;

        public static void ShowSlip(ClaimRequest req, IWin32Window owner)
        {
            if (req == null) throw new ArgumentNullException(nameof(req));
            using (var f = new ClaimSlipForm(req))
                f.ShowDialog(owner);
        }

        public ClaimSlipForm(ClaimRequest req)
        {
            _req = req ?? throw new ArgumentNullException(nameof(req));
            
            QuestPDF.Settings.License = LicenseType.Community;
            BuildUI();
            PopulateFields();
        }

        private void BuildUI()
        {
            Text = "Claim Slip";
            Size = new WinSize(560, 680);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = WinColor.FromArgb(245, 240, 228);
            Font = new Font("Letters for Learners", 12F);

            pnlSlip = new Panel
            {
                Location = new Point(20, 16), Size = new WinSize(500, 570),
                BackColor = WinColor.White, BorderStyle = BorderStyle.FixedSingle
            };
            Controls.Add(pnlSlip);

            int x = 20, y = 18, lineH = 26;

            lblFormTitle = MakeLabel("CLAIM SLIP", new Font("Pixelated Display", 18F),
                WinColor.FromArgb(26, 58, 92), new Point(x, y), new WinSize(460, 34));
            pnlSlip.Controls.Add(lblFormTitle); y += 36;

            lblSubtitle = MakeLabel("Lost & Found Management System",
                new Font("Letters for Learners", 10F, FontStyle.Italic),
                WinColor.Gray, new Point(x, y), new WinSize(460, 18));
            pnlSlip.Controls.Add(lblSubtitle); y += 22;

            pnlDivider = new Panel { Location = new Point(x, y), Size = new WinSize(460, 2), BackColor = WinColor.FromArgb(180, 160, 130) };
            pnlSlip.Controls.Add(pnlDivider); y += 10;

            lblRequestID = MakeField("Request ID:", "", x, y); pnlSlip.Controls.Add(lblRequestID); y += lineH;
            lblStatus    = MakeField("Status:",     "", x, y); pnlSlip.Controls.Add(lblStatus);    y += lineH;
            lblDateFiled = MakeField("Date Filed:", "", x, y); pnlSlip.Controls.Add(lblDateFiled); y += lineH + 6;
            AddDivider(pnlSlip, x, y, 460); y += 10;

            lblItemSection = MakeSectionHeader("ITEM DETAILS", x, y); pnlSlip.Controls.Add(lblItemSection); y += lineH;
            lblItemID    = MakeField("Item ID:",    "", x, y); pnlSlip.Controls.Add(lblItemID);    y += lineH;
            lblItemName  = MakeField("Item Name:",  "", x, y); pnlSlip.Controls.Add(lblItemName);  y += lineH;
            lblCategory  = MakeField("Category:",   "", x, y); pnlSlip.Controls.Add(lblCategory);  y += lineH;
            lblLocation  = MakeField("Found At:",   "", x, y); pnlSlip.Controls.Add(lblLocation);  y += lineH;
            lblDateFound = MakeField("Date Found:", "", x, y); pnlSlip.Controls.Add(lblDateFound); y += lineH + 6;
            AddDivider(pnlSlip, x, y, 460); y += 10;

            lblRequesterSection = MakeSectionHeader("REQUESTER DETAILS", x, y); pnlSlip.Controls.Add(lblRequesterSection); y += lineH;
            lblFullName  = MakeField("Full Name:",  "", x, y); pnlSlip.Controls.Add(lblFullName);  y += lineH;
            lblStudentID = MakeField("Student ID:", "", x, y); pnlSlip.Controls.Add(lblStudentID); y += lineH;
            lblUsername  = MakeField("Username:",   "", x, y); pnlSlip.Controls.Add(lblUsername);  y += lineH + 6;
            AddDivider(pnlSlip, x, y, 460); y += 10;

            lblRemarksSection = MakeSectionHeader("REMARKS", x, y); pnlSlip.Controls.Add(lblRemarksSection); y += lineH;
            lblRemarks = new Label
            {
                Location = new Point(x, y), Size = new WinSize(460, 50),
                Font = new Font("Letters for Learners", 12F),
                ForeColor = WinColor.FromArgb(60, 50, 40), Text = "(none)"
            };
            pnlSlip.Controls.Add(lblRemarks);

            btnPrint = new Button
            {
                Text = "Save as PDF", Font = new Font("Letters for Learners", 14F, FontStyle.Bold),
                Location = new Point(20, 600), Size = new WinSize(140, 36),
                BackColor = WinColor.FromArgb(26, 58, 92), ForeColor = WinColor.White, FlatStyle = FlatStyle.Flat
            };
            btnPrint.Click += BtnPrint_Click;
            Controls.Add(btnPrint);

            btnClose = new Button
            {
                Text = "Close", Font = new Font("Letters for Learners", 14F, FontStyle.Bold),
                Location = new Point(420, 600), Size = new WinSize(100, 36), FlatStyle = FlatStyle.Flat
            };
            btnClose.Click += (s, e) => Close();
            Controls.Add(btnClose);
        }

        private void PopulateFields()
        {
            SetField(lblRequestID, "Request ID:", _req.RequestID);
            SetField(lblStatus,    "Status:",     _req.Status);
            SetField(lblDateFiled, "Date Filed:", _req.DateFiled.ToString("MMMM d, yyyy  h:mm tt"));
            SetField(lblItemID,    "Item ID:",    _req.ItemID);
            SetField(lblItemName,  "Item Name:",  _req.ItemName);
            SetField(lblCategory,  "Category:",   _req.Category);
            SetField(lblLocation,  "Found At:",   _req.Location);
            SetField(lblDateFound, "Date Found:",
                _req.DateFound == DateTime.MinValue ? "—" : _req.DateFound.ToString("MMMM d, yyyy"));
            SetField(lblFullName,  "Full Name:",  _req.FullName);
            SetField(lblStudentID, "Student ID:", _req.StudentID);
            SetField(lblUsername,  "Username:",   _req.Username);

            lblRemarks.Text = string.IsNullOrWhiteSpace(_req.Remarks) ? "(none)" : _req.Remarks;

            lblStatus.ForeColor = _req.Status == "Approved" ? WinColor.DarkGreen
                                : _req.Status == "Rejected" ? WinColor.Firebrick
                                : WinColor.DarkGoldenrod;
        }

        
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = $"ClaimSlip_{_req.RequestID}.pdf";
                string filePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), fileName);
                GeneratePdf(filePath);
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to generate PDF:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GeneratePdf(string filePath)
        {
            var navy = "#1A3A5C";
            var gold = "#B48C3C";
            var gray = "#888888";

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(40);
                    page.DefaultTextStyle(x => x.FontSize(12).FontFamily("Arial"));

                    page.Content().Column(col =>
                    {
                        
                        col.Item().AlignCenter().Text("CLAIM SLIP")
                            .FontSize(26).Bold().FontColor(navy);
                        col.Item().AlignCenter().Text("Lost & Found Management System")
                            .FontSize(12).FontColor(gray).Italic();
                        col.Item().PaddingVertical(6).LineHorizontal(1).LineColor(gold);

                        
                        col.Item().PaddingBottom(4).Row(r =>
                        {
                            r.RelativeItem().Text(t => { t.Span("Request ID:  ").Bold(); t.Span(_req.RequestID); });
                        });
                        col.Item().PaddingBottom(4).Row(r =>
                        {
                            r.RelativeItem().Text(t => { t.Span("Status:  ").Bold(); t.Span(_req.Status).FontColor(
                                _req.Status == "Approved" ? "#1a7a1a" :
                                _req.Status == "Rejected" ? "#b22222" : "#b8860b"); });
                        });
                        col.Item().PaddingBottom(4).Row(r =>
                        {
                            r.RelativeItem().Text(t => { t.Span("Date Filed:  ").Bold(); t.Span(_req.DateFiled.ToString("MMMM d, yyyy  h:mm tt")); });
                        });
                        col.Item().PaddingVertical(6).LineHorizontal(1).LineColor(gold);

                        
                        col.Item().PaddingBottom(4).Text("ITEM DETAILS").Bold().FontSize(11).FontColor(navy);
                        PdfRow(col, "Item ID:",    _req.ItemID);
                        PdfRow(col, "Item Name:",  _req.ItemName);
                        PdfRow(col, "Category:",   _req.Category);
                        PdfRow(col, "Found At:",   _req.Location);
                        PdfRow(col, "Date Found:", _req.DateFound == DateTime.MinValue ? "—" : _req.DateFound.ToString("MMMM d, yyyy"));
                        col.Item().PaddingVertical(6).LineHorizontal(1).LineColor(gold);

                        
                        col.Item().PaddingBottom(4).Text("REQUESTER DETAILS").Bold().FontSize(11).FontColor(navy);
                        PdfRow(col, "Full Name:",  _req.FullName);
                        PdfRow(col, "Student ID:", _req.StudentID);
                        PdfRow(col, "Username:",   _req.Username);
                        col.Item().PaddingVertical(6).LineHorizontal(1).LineColor(gold);

                        
                        col.Item().PaddingVertical(6).LineHorizontal(1).LineColor(gold);
                        col.Item().PaddingBottom(4).Text("USER MESSAGE").Bold().FontSize(11).FontColor(navy);
                        col.Item().PaddingLeft(10).Text(
                            string.IsNullOrWhiteSpace(_req.Remarks) ? "(none)" : _req.Remarks);

                        
                        col.Item().PaddingVertical(6).LineHorizontal(1).LineColor(gold);
                        col.Item().PaddingBottom(4).Text("STATUS / ADMIN REMARKS").Bold().FontSize(11).FontColor(navy);
                        col.Item().PaddingLeft(10).Text(
                            _req.Status == "Pending"
                                ? "(awaiting admin review)"
                                : $"{_req.Status}" + (string.IsNullOrWhiteSpace(_req.Remarks) ? "" : $" — {_req.Remarks}"));

                        
                        col.Item().PaddingTop(20).AlignRight()
                            .Text($"Generated on {DateTime.Now:MMMM d, yyyy  h:mm tt}")
                            .FontSize(12).FontColor(gray);
                    });
                });
            }).GeneratePdf(filePath);
        }

        private static void PdfRow(ColumnDescriptor col, string label, string value)
        {
            col.Item().PaddingBottom(3).Row(r =>
            {
                r.ConstantItem(110).Text(label).Bold();
                r.RelativeItem().Text(value);
            });
        }

        
        private static Label MakeLabel(string text, Font font, WinColor fore, Point loc, WinSize size)
            => new Label { Text = text, Font = font, ForeColor = fore, Location = loc, Size = size };

        private static Label MakeField(string label, string value, int x, int y)
            => new Label
            {
                Text = $"{label}  {value}",
                Font = new Font("Letters for Learners", 14F),
                ForeColor = WinColor.FromArgb(40, 38, 35),
                Location = new Point(x, y),
                Size = new WinSize(460, 22),
                Tag = label
            };

        private static void SetField(Label lbl, string labelPrefix, string value)
            => lbl.Text = $"{labelPrefix}  {value}";

        private static Label MakeSectionHeader(string text, int x, int y)
            => new Label
            {
                Text = text,
                Font = new Font("Letters for Learners", 14F, FontStyle.Bold | FontStyle.Underline),
                ForeColor = WinColor.FromArgb(26, 58, 92),
                Location = new Point(x, y),
                Size = new WinSize(460, 22)
            };

        private static void AddDivider(Panel parent, int x, int y, int width)
            => parent.Controls.Add(new Panel
            {
                Location = new Point(x, y),
                Size = new WinSize(width, 1),
                BackColor = WinColor.FromArgb(200, 185, 160)
            });
    }
}
