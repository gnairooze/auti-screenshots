using System.Drawing.Imaging;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace AutoCaptureForm
{
    public partial class FrmCapture : Form
    {
        static readonly Timer captureTimer = new();
        private readonly string capturePath = string.Empty;

        public FrmCapture()
        {
            InitializeComponent();

            captureTimer.Tick += CaptureTimer_Tick;
            captureTimer.Interval = 5000; //5 seconds
            capturePath = txtPath.Text;
        }

        private void CaptureTimer_Tick(object? sender, EventArgs e)
        {
            try
            {
                var captureDate = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff");

                for (int i = 0; i < Screen.AllScreens.Length; i++)
                {
                    var screen = Screen.AllScreens[i];

                    Bitmap captureBitmap = new(screen.Bounds.Width, screen.Bounds.Height, PixelFormat.Format32bppArgb);
                    Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                    captureGraphics.CopyFromScreen(screen.Bounds.Left, screen.Bounds.Top, 0, 0, screen.Bounds.Size);

                    captureBitmap.Save($"{capturePath}Capture-{captureDate}-{i}.jpg", ImageFormat.Jpeg);

                    captureBitmap.Dispose();
                    captureGraphics.Dispose();
                }

                AddLog("screen captured");
            }
            catch (Exception ex)
            {
                AddLog(ex.Message);
            }
        }

        private void BtnStartCapture_Click(object sender, EventArgs e)
        {
            captureTimer.Enabled = true;
            AddLog("capture started");
        }

        private void BtnStopCapture_Click(object sender, EventArgs e)
        {
            captureTimer.Enabled = false;
            AddLog("capture stopped");
        }

        private void NumCaptureInterval_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                captureTimer.Interval = (int)numCaptureInterval.Value * 1000;
            }
            catch
            {
                AddLog("interval out of range.");
                AddLog($"it should be between {numCaptureInterval.Minimum} and {numCaptureInterval.Maximum}");
                
                numCaptureInterval.Value = captureTimer.Interval / 1000;
            }
        }


        private void AddLog(string msg)
        {
            lstLog.Items.Insert(0, $"{DateTime.Now:yyyy-MM-dd HH-mm-ss-fff} | {msg}");
        }
    }
}