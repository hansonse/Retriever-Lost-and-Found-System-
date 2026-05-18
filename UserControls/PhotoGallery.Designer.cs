namespace _DRAFT__OOP_2_FINAL_PROJECT.UserControls
{
    partial class PhotoGallery
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ── Top bar ────────────────────────────────────────────────
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();

            // ── Scrollable flow panel ──────────────────────────────────
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();

            this.panelTop.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(107, 21, 38);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 55;

            // lblTitle
            this.lblTitle.Text = "🖼  Found Items — Photo Gallery";
            this.lblTitle.Font = new System.Drawing.Font("Letters for Learners", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTitle.AutoSize = true;

            // btnRefresh
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.Font = new System.Drawing.Font("Letters for Learners", 11F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(80, 14, 28);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.Location = new System.Drawing.Point(880, 12);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // flowPanel
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.BackColor = System.Drawing.Color.FromArgb(217, 175, 134);
            this.flowPanel.Padding = new System.Windows.Forms.Padding(10);

            // PhotoGallery
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.panelTop);
            this.Size = new System.Drawing.Size(1000, 650);

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
    }
}