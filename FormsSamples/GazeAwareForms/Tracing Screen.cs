using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazeAwareForms
{
    public partial class Tracing_Screen : Form
    {
        Graphics g;
        bool startPaint = false;
        int? initX = null;
        int? initY = null;
        Pen p;
        int count = 0;
        int lineCount = 1;
        List<string> mouseCoord = new List<string>();
        List<string> eyeCoord = new List<string>();
        bool messageBoxOn = false;
        bool isFocus = true;
        string path = "";

        public Tracing_Screen()
        {
            InitializeComponent();
            p = new Pen(Color.Lime, 3);
            label1.Text = PatientInfo.patientName;
        }

        Bitmap b1;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            initialDrawings(panel1);
        }

        private void initialDrawings(Panel panel1)
        {
            panel1.Invalidate();
            b1 = new Bitmap(panel1.ClientSize.Width, panel1.ClientSize.Height);
            g = Graphics.FromImage(b1);
            g.Clear(Color.White);

            Pen p = new Pen(Color.Black, 8);
            g.DrawLine(p, 50, 50, 511, 50);
            g.DrawLine(p, 50, 178, 511, 178);
            g.DrawLine(p, 50, 306, 511, 306);
            g.DrawEllipse(p, 268, 169, 19, 19);
            g.FillEllipse(Brushes.Black, 268, 169, 19, 19);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = null;
            initY = null;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
                p = new Pen(Color.Lime, 3);
                using (g = Graphics.FromImage(b1))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    if (!isFocus)
                    {
                        p.Color = Color.White;
                    }
                    else
                    {
                        p.Color = Color.Lime;
                    }

                    g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));


                    initX = e.X;
                    initY = e.Y;

                }
                panel1.Invalidate();
            }
        }


        private void changePath()
        {
            string patient = "Patient" + PatientInfo.patientId;
            path = @"Patient\\" + patient;
            MessageBox.Show(path);
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(b1, Point.Empty);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            changePath();
            string fileName = String.Format(@"{0}\DT " + count + ".jpg", path);
            b1.Save(fileName, ImageFormat.Jpeg);
            count++;
        }
    }
}
