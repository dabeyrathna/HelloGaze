using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeXFramework;
using EyeXFramework.Forms;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using GazeAwareForms;

namespace HelloGaze
{
    public partial class Gestures : Form
    {
        Graphics g;
        bool startPaint = false;
        int? initX = null;
        int? initY = null;
        Pen p;
        int count = 0;
        int btncounter = 0;
        //int lineCount = 1;
        List<string> mouseCoord = new List<string>();
        List<string> eyeCoord = new List<string>();
        //bool messageBoxOn = false;
        bool isFocus = true;
        string path = "";

        

        public Gestures()
        {
            InitializeComponent();
            p = new Pen(Color.Blue, 3);
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty |
                BindingFlags.Instance | BindingFlags.NonPublic, null, panel1, new object[] { true });
        }

        Bitmap bmp;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            initialDrawings(panel1);
        }

        private void initialDrawings(Panel panel1)
        {
            panel1.Invalidate();
            bmp = new Bitmap(panel1.ClientSize.Width, panel1.ClientSize.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            // Create pen.
            Pen bluePen = new Pen(Color.Blue, 3);

            //Randomly generate point 1
            Random r = new Random();
            int x = 20;
            int y = r.Next(110, 360);
            g.DrawEllipse(bluePen, x, y, 20, 20);
            g.FillEllipse(Brushes.Blue, x, y, 20, 20);

            //Randomly generate point 2
            int a = 360;
            int b = r.Next(110, 360);
            g.DrawEllipse(bluePen, a, b, 20, 20);
            g.FillEllipse(Brushes.Blue, a, b, 20, 20);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = null;
            initY = null;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
                p = new Pen(Color.Black, 3);
                using (g = Graphics.FromImage(bmp))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    if (!isFocus)
                    {
                        p.Color = Color.White;
                    }
                    else
                    {
                        p.Color = Color.Black;
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
            //Use patient ID to store images in folder
            string patient = "Patient" + PatientInfo.patientId;
            path = @"" + "HelloGaze DB" + "\\" + patient;
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, Point.Empty);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            changePath();
            string fileName = String.Format(@"{0}\\Gesture_Cal " + count + ".jpg", path);
            bmp.Save(fileName, ImageFormat.Jpeg);
            count++;
            btncounter++;

            if (btncounter < 3)
            {
                initialDrawings(panel1);
            }

            if (btncounter == 2)
            {
                this.Save.Text = "Done";
                this.label1.Text = "Join the two points and click Done.";
            }

            if (btncounter >= 3)
            {
                this.Hide();
                Calibration.Current.ShowDialog();
            }
        }
    }
}
