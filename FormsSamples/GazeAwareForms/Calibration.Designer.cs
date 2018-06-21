namespace HelloGaze
{
    partial class Calibration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calibration));
            this.label1 = new System.Windows.Forms.Label();
            this.gazeCalibration = new System.Windows.Forms.Button();
            this.gestureCalibration = new System.Windows.Forms.Button();
            this.startExp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Before you begin, let us calibrate your touchscreen for Gaze and Gesture.";
            // 
            // gazeCalibration
            // 
            this.gazeCalibration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.gazeCalibration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.gazeCalibration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gazeCalibration.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gazeCalibration.Location = new System.Drawing.Point(181, 191);
            this.gazeCalibration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gazeCalibration.Name = "gazeCalibration";
            this.gazeCalibration.Size = new System.Drawing.Size(237, 31);
            this.gazeCalibration.TabIndex = 1;
            this.gazeCalibration.Text = "Start Gaze Calibration";
            this.gazeCalibration.UseVisualStyleBackColor = false;
            this.gazeCalibration.Click += new System.EventHandler(this.gazeCalibration_Click);
            // 
            // gestureCalibration
            // 
            this.gestureCalibration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.gestureCalibration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.gestureCalibration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gestureCalibration.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestureCalibration.Location = new System.Drawing.Point(444, 191);
            this.gestureCalibration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gestureCalibration.Name = "gestureCalibration";
            this.gestureCalibration.Size = new System.Drawing.Size(251, 31);
            this.gestureCalibration.TabIndex = 2;
            this.gestureCalibration.Text = "Start Gesture Calibration";
            this.gestureCalibration.UseVisualStyleBackColor = false;
            this.gestureCalibration.Click += new System.EventHandler(this.gestureCalibration_Click);
            // 
            // startExp
            // 
            this.startExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.startExp.Enabled = false;
            this.startExp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.startExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startExp.Font = new System.Drawing.Font("Calibri", 10F);
            this.startExp.Location = new System.Drawing.Point(343, 437);
            this.startExp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startExp.Name = "startExp";
            this.startExp.Size = new System.Drawing.Size(195, 32);
            this.startExp.TabIndex = 4;
            this.startExp.Text = "Start Experiment";
            this.startExp.UseVisualStyleBackColor = false;
            this.startExp.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "© HelloGaze 2018";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // circularProgressBar
            // 
          //  this.circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar.AnimationSpeed = 500;
            this.circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar.InnerColor = System.Drawing.Color.PaleTurquoise;
            this.circularProgressBar.InnerMargin = 2;
            this.circularProgressBar.InnerWidth = -1;
            this.circularProgressBar.Location = new System.Drawing.Point(359, 252);
            this.circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar.Name = "circularProgressBar";
            this.circularProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar.OuterMargin = -25;
            this.circularProgressBar.OuterWidth = 26;
            this.circularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.circularProgressBar.ProgressWidth = 25;
            this.circularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar.Size = new System.Drawing.Size(159, 156);
            this.circularProgressBar.StartAngle = 270;
            this.circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar.SubscriptText = "";
            this.circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar.SuperscriptText = "";
            this.circularProgressBar.TabIndex = 12;
            this.circularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // Calibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(883, 553);
            this.Controls.Add(this.circularProgressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startExp);
            this.Controls.Add(this.gestureCalibration);
            this.Controls.Add(this.gazeCalibration);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Calibration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelloGaze Calibration";
            this.Load += new System.EventHandler(this.Calibration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gazeCalibration;
        private System.Windows.Forms.Button gestureCalibration;
        private System.Windows.Forms.Button startExp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private CircularProgressBar.CircularProgressBar circularProgressBar;

        public object WinFormAnimation { get; private set; }
    }
}