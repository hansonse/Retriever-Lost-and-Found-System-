using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace _DRAFT__OOP_2_FINAL_PROJECT
{
    public partial class CameraCapture : Form
    {
        
        private VideoCapture _capture;
        private Thread       _grabThread;
        private volatile bool _running  = false;
        private Mat          _lastFrame = new Mat();
        private readonly object _frameLock = new object();

        public string CapturedImagePath = "";

        
        public CameraCapture()
        {
            InitializeComponent();
        }

        
        private void CameraCapture_Load(object sender, EventArgs e)
        {
            StartCamera();
        }

        private void StartCamera()
        {
            try
            {
                _capture = new VideoCapture(0);   

                if (!_capture.IsOpened())
                {
                    lblCameraStatus.Text = "No camera found on this device.";
                    btnCapture.Enabled   = false;
                    return;
                }

                
                _capture.Set(VideoCaptureProperties.FrameWidth,  picCamera.Width);
                _capture.Set(VideoCaptureProperties.FrameHeight, picCamera.Height);

                lblCameraStatus.Text = "Camera ready. Click \"Capture Photo\" when ready.";

                _running    = true;
                _grabThread = new Thread(GrabLoop) { IsBackground = true };
                _grabThread.Start();
            }
            catch (Exception ex)
            {
                lblCameraStatus.Text = "Camera error: " + ex.Message;
                btnCapture.Enabled   = false;
            }
        }

        
        private void GrabLoop()
        {
            using var frame = new Mat();

            while (_running)
            {
                if (!_capture.Read(frame) || frame.Empty())
                {
                    Thread.Sleep(30);
                    continue;
                }

                
                lock (_frameLock)
                    frame.CopyTo(_lastFrame);

                
                try
                {
                    Bitmap bmp = BitmapConverter.ToBitmap(frame);

                    if (!this.IsDisposed && picCamera.IsHandleCreated)
                    {
                        picCamera.BeginInvoke(new Action(() =>
                        {
                            if (!_running || picCamera.IsDisposed) { bmp.Dispose(); return; }
                            Image old        = picCamera.Image;
                            picCamera.Image  = bmp;
                            old?.Dispose();
                        }));
                    }
                    else
                    {
                        bmp.Dispose();
                    }
                }
                catch { }

                Thread.Sleep(33);   
            }
        }

        
        private void btnCapture_Click(object sender, EventArgs e)
        {
            Mat snapshot;

            lock (_frameLock)
            {
                if (_lastFrame == null || _lastFrame.Empty())
                {
                    lblCameraStatus.Text = "No frame yet — try again.";
                    return;
                }
                snapshot = _lastFrame.Clone();
            }

            try
            {
                StopCamera();

                string tempPath = Path.Combine(
                    Path.GetTempPath(),
                    "retriever_capture_" +
                    DateTime.Now.ToString("yyyyMMddHHmmss") +
                    ".jpg");

                Cv2.ImWrite(tempPath, snapshot);
                CapturedImagePath = tempPath;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                lblCameraStatus.Text = "Capture error: " + ex.Message;
            }
            finally
            {
                snapshot?.Dispose();
            }
        }

        
        private void btnCancelCamera_Click(object sender, EventArgs e)
        {
            StopCamera();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
        private void StopCamera()
        {
            _running = false;

            try { _grabThread?.Join(500); } catch { }

            try { _capture?.Release(); _capture?.Dispose(); } catch { }
            try { _lastFrame?.Dispose(); }                   catch { }

            if (!picCamera.IsDisposed)
            {
                Action clear = () => { Image old = picCamera.Image; picCamera.Image = null; old?.Dispose(); };
                if (picCamera.InvokeRequired) picCamera.BeginInvoke(clear);
                else clear();
            }
        }

        
        private void CameraCapture_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
        }
    }
}
