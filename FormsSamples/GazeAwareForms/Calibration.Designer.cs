namespace GazeAwareForms
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startExp = new System.Windows.Forms.Button();
            this.calibrationProgress = new System.Windows.Forms.ProgressBar();
            this.gestureCalibration = new System.Windows.Forms.Button();
            this.gazeCalibration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Hi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "© HelloGaze 2018";
            // 
            // startExp
            // 
            this.startExp.Enabled = false;
            this.startExp.Font = new System.Drawing.Font("Calibri", 10F);
            this.startExp.Location = new System.Drawing.Point(311, 321);
            this.startExp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startExp.Name = "startExp";
            this.startExp.Size = new System.Drawing.Size(195, 32);
            this.startExp.TabIndex = 17;
            this.startExp.Text = "Start Experiment";
            this.startExp.UseVisualStyleBackColor = true;
            this.startExp.Click += new System.EventHandler(this.startExp_Click);
            // 
            // calibrationProgress
            // 
            this.calibrationProgress.Location = new System.Drawing.Point(256, 243);
            this.calibrationProgress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calibrationProgress.Name = "calibrationProgress";
            this.calibrationProgress.Size = new System.Drawing.Size(285, 31);
            this.calibrationProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.calibrationProgress.TabIndex = 16;
            // 
            // gestureCalibration
            // 
            this.gestureCalibration.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestureCalibration.Location = new System.Drawing.Point(408, 162);
            this.gestureCalibration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gestureCalibration.Name = "gestureCalibration";
            this.gestureCalibration.Size = new System.Drawing.Size(251, 31);
            this.gestureCalibration.TabIndex = 15;
            this.gestureCalibration.Text = "Start Gesture Calibration";
            this.gestureCalibration.UseVisualStyleBackColor = true;
            this.gestureCalibration.Click += new System.EventHandler(this.gestureCalibration_Click);
            // 
            // gazeCalibration
            // 
            this.gazeCalibration.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gazeCalibration.Location = new System.Drawing.Point(145, 162);
            this.gazeCalibration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gazeCalibration.Name = "gazeCalibration";
            this.gazeCalibration.Size = new System.Drawing.Size(237, 31);
            this.gazeCalibration.TabIndex = 14;
            this.gazeCalibration.Text = "Start Gaze Calibration";
            this.gazeCalibration.UseVisualStyleBackColor = true;
            this.gazeCalibration.Click += new System.EventHandler(this.gazeCalibration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Before you begin, let us calibrate your touchscreen for Gaze and Gesture.";
            // 
            // Calibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startExp);
            this.Controls.Add(this.calibrationProgress);
            this.Controls.Add(this.gestureCalibration);
            this.Controls.Add(this.gazeCalibration);
            this.Controls.Add(this.label1);
            this.Name = "Calibration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelloGaze Calibration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startExp;
        private System.Windows.Forms.ProgressBar calibrationProgress;
        private System.Windows.Forms.Button gestureCalibration;
        private System.Windows.Forms.Button gazeCalibration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}