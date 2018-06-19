using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazeAwareForms
{
    public partial class Calibration : Form
    {
        public static Calibration Current;

        public Calibration()
        {
            InitializeComponent();
            label4.Text = PatientInfo.patientName;
            Current = this;

            startExp.Enabled = true;
        }

        private void gestureCalibration_Click(object sender, EventArgs e)
        {
            timer1.Start();
            this.calibrationProgress.Increment(50);
            timer1.Stop();
            startExp.Enabled = true;
      
            Gestures gestureForm = new Gestures();
            this.Hide();
            gestureForm.Show();
        }

        private void gazeCalibration_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //MessageBox.Show("Perform Gesture Calibration!");
            this.calibrationProgress.Increment(50);
            timer1.Stop();
            startExp.Enabled = true;

            Gaze gazeForm = new Gaze();
            //this.Hide();
            gazeForm.Show();
            //System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Tobii\\Tobii EyeX Interaction\\Tobii.EyeX.Tray.exe");
        }

        private void resetCalib_Click(object sender, EventArgs e)
        {
            startExp.Enabled = true;
            //timer1.Start();
            this.calibrationProgress.Value = 0;
        }

        private void startExp_Click(object sender, EventArgs e)
        {
            Mode1 mode1Form = new Mode1();
            this.Hide();
            mode1Form.Show();
        }
    }
}
