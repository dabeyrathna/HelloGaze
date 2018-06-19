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
    public partial class HelloGaze_Login : Form
    {
        Color foreColor;

        public HelloGaze_Login()
        {
            InitializeComponent();
            foreColor = txtPatientId.ForeColor;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string patientId = txtPatientId.Text;
            string medicalExoertName = txtMedicalExpertName.Text;
            string patientName = txtPatientName.Text;
            string dOfVisit = dateofVisit.Value.ToShortDateString();

            PatientInfo.patientId = patientId;
            PatientInfo.patientName = patientName;
            PatientInfo.medicalExoertName = medicalExoertName;
            PatientInfo.dateofVisit = dOfVisit;

            Calibration calibrationForm = new Calibration();
            this.Hide();
            calibrationForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
          
    }
}
