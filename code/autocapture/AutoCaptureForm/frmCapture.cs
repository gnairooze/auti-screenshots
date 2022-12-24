using System.Drawing.Imaging;
using System.Runtime.InteropServices.ObjectiveC;
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
            this.Text = "Auto-Capture";

            BindScreensControls();
        }

        private void BindScreensControls()
        {
            List<ScreenModel> screens = new ();
            
            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                screens.Add(new ScreenModel() { Id = i, Name = $"Screen {i}" });
            }

            SetComboScreen(comboScreenTop, screens);
            SetComboScreen(comboScreenBottom, screens);
            SetComboScreen(comboScreenLeft, screens);
            SetComboScreen(comboScreenRight, screens);
        }

        private static void SetComboScreen(ComboBox comboScreen, List<ScreenModel> screens)
        {
            comboScreen.Items.Clear();
            for(int i = 0; i < screens.Count; i++)
            {
                comboScreen.Items.Add(screens[i].Name);
            }
        }

        private void CaptureTimer_Tick(object? sender, EventArgs e)
        {
            try
            {
                var captureDate = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff");
                
                Bitmap resultBitmap;

                if (radioHorizontal.Checked)
                {
                    if(comboScreenLeft.SelectedItem == null && comboScreenRight.SelectedItem == null)
                    {
                        AddLog("screen not set");
                        return;
                    }

                    if(comboScreenLeft.SelectedItem != null && comboScreenRight.SelectedItem == null)
                    {
                        int leftIndex = GetScreenIndexFromItem(comboScreenLeft.SelectedItem.ToString());
                        Bitmap left = CaptureScreen(leftIndex);

                        left.Save($"{capturePath}Capture-{captureDate}.jpg", ImageFormat.Jpeg);
                        left.Dispose();

                        AddLog("screen captured");
                        return;
                    }

                    if (comboScreenLeft.SelectedItem == null && comboScreenRight.SelectedItem != null)
                    {
                        int rightIndex = GetScreenIndexFromItem(comboScreenRight.SelectedItem.ToString());
                        Bitmap right = CaptureScreen(rightIndex);

                        right.Save($"{capturePath}Capture-{captureDate}.jpg", ImageFormat.Jpeg);
                        right.Dispose();

                        AddLog("screen captured");
                        return;
                    }

                    if (comboScreenLeft.SelectedItem != null && comboScreenRight.SelectedItem != null)
                    {
                        int leftIndex = GetScreenIndexFromItem(comboScreenLeft.SelectedItem.ToString());
                        Bitmap left = CaptureScreen(leftIndex);

                        int rightIndex = GetScreenIndexFromItem(comboScreenRight.SelectedItem.ToString());
                        Bitmap right = CaptureScreen(rightIndex);

                        resultBitmap = CombineHorizontalBitmaps(left, right);

                        resultBitmap.Save($"{capturePath}Capture-{captureDate}.jpg", ImageFormat.Jpeg);
                        resultBitmap.Dispose();

                        AddLog("screen captured");
                        return;
                    }
                }

                if (radioVertical.Checked)
                {
                    if (comboScreenTop.SelectedItem == null && comboScreenBottom.SelectedItem == null)
                    {
                        AddLog("screen not set");
                        return;
                    }

                    if (comboScreenTop.SelectedItem != null && comboScreenBottom.SelectedItem == null)
                    {
                        int topIndex = GetScreenIndexFromItem(comboScreenTop.SelectedItem.ToString());
                        Bitmap top = CaptureScreen(topIndex);

                        top.Save($"{capturePath}Capture-{captureDate}.jpg", ImageFormat.Jpeg);
                        top.Dispose();

                        AddLog("screen captured");
                        return;
                    }

                    if (comboScreenTop.SelectedItem == null && comboScreenBottom.SelectedItem != null)
                    {
                        int bottomIndex = GetScreenIndexFromItem(comboScreenBottom.SelectedItem.ToString());
                        Bitmap bottom = CaptureScreen(bottomIndex);

                        bottom.Save($"{capturePath}Capture-{captureDate}.jpg", ImageFormat.Jpeg);
                        bottom.Dispose();

                        AddLog("screen captured");
                        return;
                    }

                    if (comboScreenTop.SelectedItem != null && comboScreenBottom.SelectedItem != null)
                    {
                        int topIndex = GetScreenIndexFromItem(comboScreenTop.SelectedItem.ToString());
                        Bitmap top = CaptureScreen(topIndex);
                        int bottomIndex = GetScreenIndexFromItem(comboScreenBottom.SelectedItem.ToString());
                        Bitmap bottom = CaptureScreen(bottomIndex);
                        resultBitmap = CombineVerticalBitmaps(top, bottom);

                        resultBitmap.Save($"{capturePath}Capture-{captureDate}.jpg", ImageFormat.Jpeg);
                        resultBitmap.Dispose();

                        AddLog("screen captured");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                AddLog(ex.Message);
            }
        }

        private static int GetScreenIndexFromItem(string? screenName)
        {
            if (screenName == null)
            {
                return 0;
            }

            bool parseSucceeded = int.TryParse(screenName.Replace("Screen", string.Empty), out int screenIndex);

            return (parseSucceeded)?screenIndex: 0;
        }

        private static Bitmap CombineHorizontalBitmaps(Bitmap left, Bitmap right)
        {
            Bitmap resultBitmap = new(left.Width + right.Width, left.Height, PixelFormat.Format32bppArgb);
            Graphics resultGraphics = Graphics.FromImage(resultBitmap);
            resultGraphics.DrawImage(left, 0, 0);
            resultGraphics.DrawImage(right, left.Width, 0);

            resultGraphics.Dispose();

            return resultBitmap;
        }

        private static Bitmap CombineVerticalBitmaps(Bitmap top, Bitmap bottom)
        {
            Bitmap resultBitmap = new(top.Width, top.Height + bottom.Height, PixelFormat.Format32bppArgb);
            Graphics resultGraphics = Graphics.FromImage(resultBitmap);
            resultGraphics.DrawImage(top, 0, 0);
            resultGraphics.DrawImage(bottom, 0, top.Height);

            resultGraphics.Dispose();

            return resultBitmap;
        }
        
        private static Bitmap CaptureScreen(int screenIdex)
        {
            if (Screen.AllScreens.Length <= screenIdex)
            {
                screenIdex = 0;
            }
            
            var screen = Screen.AllScreens[screenIdex];

            Bitmap captureBitmap = new(screen.Bounds.Width, screen.Bounds.Height, PixelFormat.Format32bppArgb);
            Graphics captureGraphics = Graphics.FromImage(captureBitmap);
            captureGraphics.CopyFromScreen(screen.Bounds.Left, screen.Bounds.Top, 0, 0, screen.Bounds.Size);

            captureGraphics.Dispose();

            return captureBitmap;
        }

        private void BtnStartCapture_Click(object sender, EventArgs e)
        {
            captureTimer.Enabled = true;
            AddLog("capture started");
            this.Text = "Auto-Capture - Started";
        }

        private void BtnStopCapture_Click(object sender, EventArgs e)
        {
            captureTimer.Enabled = false;
            AddLog("capture stopped");
            this.Text = "Auto-Capture";
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