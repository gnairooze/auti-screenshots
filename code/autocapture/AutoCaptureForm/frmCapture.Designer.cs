namespace AutoCaptureForm
{
    partial class FrmCapture
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstLog = new System.Windows.Forms.ListBox();
            this.btnStartCapture = new System.Windows.Forms.Button();
            this.btnStopCapture = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.numCaptureInterval = new System.Windows.Forms.NumericUpDown();
            this.lblCaptureInterval = new System.Windows.Forms.Label();
            this.comboScreenTop = new System.Windows.Forms.ComboBox();
            this.comboScreenBottom = new System.Windows.Forms.ComboBox();
            this.comboScreenLeft = new System.Windows.Forms.ComboBox();
            this.comboScreenRight = new System.Windows.Forms.ComboBox();
            this.lblScreens = new System.Windows.Forms.Label();
            this.radioVertical = new System.Windows.Forms.RadioButton();
            this.radioHorizontal = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numCaptureInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 15;
            this.lstLog.Location = new System.Drawing.Point(278, 10);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(412, 319);
            this.lstLog.TabIndex = 1;
            // 
            // btnStartCapture
            // 
            this.btnStartCapture.Location = new System.Drawing.Point(14, 304);
            this.btnStartCapture.Name = "btnStartCapture";
            this.btnStartCapture.Size = new System.Drawing.Size(105, 23);
            this.btnStartCapture.TabIndex = 2;
            this.btnStartCapture.Text = "Start Capture";
            this.btnStartCapture.UseVisualStyleBackColor = true;
            this.btnStartCapture.Click += new System.EventHandler(this.BtnStartCapture_Click);
            // 
            // btnStopCapture
            // 
            this.btnStopCapture.Location = new System.Drawing.Point(157, 304);
            this.btnStopCapture.Name = "btnStopCapture";
            this.btnStopCapture.Size = new System.Drawing.Size(105, 23);
            this.btnStopCapture.TabIndex = 3;
            this.btnStopCapture.Text = "Stop Capture";
            this.btnStopCapture.UseVisualStyleBackColor = true;
            this.btnStopCapture.Click += new System.EventHandler(this.BtnStopCapture_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(14, 13);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(31, 15);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(51, 10);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(211, 23);
            this.txtPath.TabIndex = 5;
            this.txtPath.Text = "c:\\temp\\screenshots\\";
            // 
            // numCaptureInterval
            // 
            this.numCaptureInterval.DecimalPlaces = 1;
            this.numCaptureInterval.Location = new System.Drawing.Point(139, 46);
            this.numCaptureInterval.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numCaptureInterval.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numCaptureInterval.Name = "numCaptureInterval";
            this.numCaptureInterval.Size = new System.Drawing.Size(123, 23);
            this.numCaptureInterval.TabIndex = 6;
            this.numCaptureInterval.ThousandsSeparator = true;
            this.numCaptureInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCaptureInterval.ValueChanged += new System.EventHandler(this.NumCaptureInterval_ValueChanged);
            // 
            // lblCaptureInterval
            // 
            this.lblCaptureInterval.AutoSize = true;
            this.lblCaptureInterval.Location = new System.Drawing.Point(14, 48);
            this.lblCaptureInterval.Name = "lblCaptureInterval";
            this.lblCaptureInterval.Size = new System.Drawing.Size(119, 15);
            this.lblCaptureInterval.TabIndex = 7;
            this.lblCaptureInterval.Text = "Capture Interval (sec)";
            // 
            // comboScreenTop
            // 
            this.comboScreenTop.FormattingEnabled = true;
            this.comboScreenTop.Location = new System.Drawing.Point(12, 149);
            this.comboScreenTop.Name = "comboScreenTop";
            this.comboScreenTop.Size = new System.Drawing.Size(121, 23);
            this.comboScreenTop.TabIndex = 8;
            // 
            // comboScreenBottom
            // 
            this.comboScreenBottom.FormattingEnabled = true;
            this.comboScreenBottom.Location = new System.Drawing.Point(12, 178);
            this.comboScreenBottom.Name = "comboScreenBottom";
            this.comboScreenBottom.Size = new System.Drawing.Size(121, 23);
            this.comboScreenBottom.TabIndex = 9;
            // 
            // comboScreenLeft
            // 
            this.comboScreenLeft.FormattingEnabled = true;
            this.comboScreenLeft.Location = new System.Drawing.Point(14, 243);
            this.comboScreenLeft.Name = "comboScreenLeft";
            this.comboScreenLeft.Size = new System.Drawing.Size(121, 23);
            this.comboScreenLeft.TabIndex = 10;
            // 
            // comboScreenRight
            // 
            this.comboScreenRight.FormattingEnabled = true;
            this.comboScreenRight.Location = new System.Drawing.Point(141, 243);
            this.comboScreenRight.Name = "comboScreenRight";
            this.comboScreenRight.Size = new System.Drawing.Size(121, 23);
            this.comboScreenRight.TabIndex = 11;
            // 
            // lblScreens
            // 
            this.lblScreens.AutoSize = true;
            this.lblScreens.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScreens.Location = new System.Drawing.Point(14, 95);
            this.lblScreens.Name = "lblScreens";
            this.lblScreens.Size = new System.Drawing.Size(51, 15);
            this.lblScreens.TabIndex = 16;
            this.lblScreens.Text = "Screens";
            // 
            // radioVertical
            // 
            this.radioVertical.AutoSize = true;
            this.radioVertical.Location = new System.Drawing.Point(10, 124);
            this.radioVertical.Name = "radioVertical";
            this.radioVertical.Size = new System.Drawing.Size(63, 19);
            this.radioVertical.TabIndex = 17;
            this.radioVertical.Text = "Vertical";
            this.radioVertical.UseVisualStyleBackColor = true;
            // 
            // radioHorizontal
            // 
            this.radioHorizontal.AutoSize = true;
            this.radioHorizontal.Checked = true;
            this.radioHorizontal.Location = new System.Drawing.Point(13, 218);
            this.radioHorizontal.Name = "radioHorizontal";
            this.radioHorizontal.Size = new System.Drawing.Size(80, 19);
            this.radioHorizontal.TabIndex = 18;
            this.radioHorizontal.TabStop = true;
            this.radioHorizontal.Text = "Horizontal";
            this.radioHorizontal.UseVisualStyleBackColor = true;
            // 
            // FrmCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 339);
            this.Controls.Add(this.radioHorizontal);
            this.Controls.Add(this.radioVertical);
            this.Controls.Add(this.lblScreens);
            this.Controls.Add(this.comboScreenRight);
            this.Controls.Add(this.comboScreenLeft);
            this.Controls.Add(this.comboScreenBottom);
            this.Controls.Add(this.comboScreenTop);
            this.Controls.Add(this.lblCaptureInterval);
            this.Controls.Add(this.numCaptureInterval);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnStopCapture);
            this.Controls.Add(this.btnStartCapture);
            this.Controls.Add(this.lstLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCapture";
            this.Text = "Auto-Capture";
            ((System.ComponentModel.ISupportInitialize)(this.numCaptureInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstLog;
        private Button btnStartCapture;
        private Button btnStopCapture;
        private Label lblPath;
        private TextBox txtPath;
        private NumericUpDown numCaptureInterval;
        private Label lblCaptureInterval;
        private ComboBox comboScreenTop;
        private ComboBox comboScreenBottom;
        private ComboBox comboScreenLeft;
        private ComboBox comboScreenRight;
        private Label lblScreens;
        private RadioButton radioVertical;
        private RadioButton radioHorizontal;
    }
}