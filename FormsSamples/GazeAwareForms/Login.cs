using HelloGaze;
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
        public HelloGaze_Login()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelloGaze_Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Welcome;
        }

        private void MedicalExpertName_Enter(object sender, EventArgs e)
        {
            if (MedicalExpertName.Text == "Medical Expert Name")
            {
                MedicalExpertName.Text = "";
                MedicalExpertName.ForeColor = Color.Black;
            }
        }

        private void MedicalExpertName_Leave(object sender, EventArgs e)
        {
            if (MedicalExpertName.Text == "")
            {
                MedicalExpertName.Text = "Medical Expert Name";
                MedicalExpertName.ForeColor = Color.Silver;
            }
        }

        private void PatientName_Enter(object sender, EventArgs e)
        {
            if (PatientName.Text == "Patient Name")
            {
                PatientName.Text = "";
                PatientName.ForeColor = Color.Black;
            }
        }

        private void PatientName_Leave(object sender, EventArgs e)
        {
            if (PatientName.Text == "")
            {
                PatientName.Text = "Patient Name";
                PatientName.ForeColor = Color.Silver;
            }
        }

        private void PatientID_Enter(object sender, EventArgs e)
        {
            if (PatientID.Text == "Patient ID")
            {
                PatientID.Text = "";
                PatientID.ForeColor = Color.Black;
            }
        }

        private void PatientID_Leave(object sender, EventArgs e)
        {
            if (PatientID.Text == "")
            {
                PatientID.Text = "Patient ID";
                PatientID.ForeColor = Color.Silver;
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string patientId = PatientID.Text;
            string medicalExoertName = MedicalExpertName.Text;
            string patientName = PatientName.Text;
            string dOfVisit = dateofVisit.Value.ToShortDateString();

            PatientInfo.patientId = patientId;
            PatientInfo.patientName = patientName;
            PatientInfo.medicalExoertName = medicalExoertName;
            PatientInfo.dateofVisit = dOfVisit;

            if (PatientID.Text.Equals("") || PatientID.Text.Equals("Patient ID"))
            {
                MessageBox.Show("Please fill required information !", "Missing Information !"); 
            }
            else
            {
                Calibration calibrationForm = new Calibration();
                this.Hide();
                calibrationForm.Show();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
