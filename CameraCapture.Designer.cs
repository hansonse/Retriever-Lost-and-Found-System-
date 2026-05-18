namespace _DRAFT__OOP_2_FINAL_PROJECT
{
    partial class CameraCapture
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
            picCamera       = new System.Windows.Forms.PictureBox();
            btnCapture      = new System.Windows.Forms.Button();
            btnCancelCamera = new System.Windows.Forms.Button();
            lblCameraStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)picCamera).BeginInit();
            SuspendLayout();

            // picCamera
            picCamera.BackColor = System.Drawing.Color.Black;
            picCamera.Location  = new System.Drawing.Point(12, 14);
            picCamera.Name      = "picCamera";
            picCamera.Size      = new System.Drawing.Size(600, 400);
            picCamera.SizeMode  = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picCamera.TabIndex  = 0;
            picCamera.TabStop   = false;

            // btnCapture
            btnCapture.Location = new System.Drawing.Point(133, 437);
            btnCapture.Name     = "btnCapture";
            btnCapture.Size     = new System.Drawing.Size(115, 23);
            btnCapture.TabIndex = 1;
            btnCapture.Text     = "Capture Photo";
            btnCapture.UseVisualStyleBackColor = true;
            btnCapture.Click   += btnCapture_Click;

            // btnCancelCamera
            btnCancelCamera.Location = new System.Drawing.Point(382, 437);
            btnCancelCamera.Name     = "btnCancelCamera";
            btnCancelCamera.Size     = new System.Drawing.Size(75, 23);
            btnCancelCamera.TabIndex = 2;
            btnCancelCamera.Text     = "Cancel";
            btnCancelCamera.UseVisualStyleBackColor = true;
            btnCancelCamera.Click   += btnCancelCamera_Click;

            // lblCameraStatus
            lblCameraStatus.AutoSize = true;
            lblCameraStatus.Location = new System.Drawing.Point(12, 417);
            lblCameraStatus.Name     = "lblCameraStatus";
            lblCameraStatus.Size     = new System.Drawing.Size(99, 15);
            lblCameraStatus.TabIndex = 3;
            lblCameraStatus.Text     = "Starting camera...";

            // CameraCapture (Form)
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize          = new System.Drawing.Size(624, 481);
            Controls.Add(lblCameraStatus);
            Controls.Add(btnCancelCamera);
            Controls.Add(btnCapture);
            Controls.Add(picCamera);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox     = false;
            MinimizeBox     = false;
            Name            = "CameraCapture";
            StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent;
            Text            = "Camera Capture";
            Load           += CameraCapture_Load;
            FormClosing    += CameraCapture_FormClosing;
            ((System.ComponentModel.ISupportInitialize)picCamera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.Button     btnCapture;
        private System.Windows.Forms.Button     btnCancelCamera;
        private System.Windows.Forms.Label      lblCameraStatus;
    }
}
