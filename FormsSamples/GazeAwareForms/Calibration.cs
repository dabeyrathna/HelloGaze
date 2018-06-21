using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeXFramework;

namespace HelloGaze
{
    using EyeXFramework;
    using GazeAwareForms;

    public partial class Calibration : Form
    {
        public static Calibration Current;
        
        public Calibration()
        {
            InitializeComponent();
            Current = this;
            circularProgressBar.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mode1 objForm1 = new Mode1(1);
            this.Hide();
            objForm1.Show();
        }

        private void gazeCalibration_Click(object sender, EventArgs e)
        {
            gazeCalibration.Enabled = false;
            this.circularProgressBar.Increment(50);
            Gaze objForm2 = new Gaze();
            objForm2.Show();
         }

        private void gestureCalibration_Click(object sender, EventArgs e)
        {
            gestureCalibration.Enabled = false;
            startExp.Enabled = true;
            startExp.BackColor = Color.Turquoise;
            startExp.FlatAppearance.BorderColor = Color.Turquoise;
            Gestures objForm1 = new Gestures(); 
            circularProgressBar.Increment(50);
            this.Hide();
            objForm1.Show();
        }

        private void resetCalib_Click(object sender, EventArgs e)
        {
            startExp.Enabled = false;         
        }

        private void Calibration_Load(object sender, EventArgs e)
        {
            label2.Text = "Hi " + PatientInfo.patientName + "!";
            this.ActiveControl = label2;
        }
    }
}
