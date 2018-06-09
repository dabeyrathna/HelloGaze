
using EyeXFramework;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace GazeAwareForms
{
    public partial class GazeAwareForm : Form
    {
        Graphics g;
        bool startPaint = false;
        int? initX = null;
        int? initY = null;
        Pen p;
        int count = 0;

        
        string path = "";

        public GazeAwareForm()
        {
            InitializeComponent();
            Program.EyeXHost.Connect(behaviorMap1);
           // behaviorMap1.Add(panel1, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(panel2, new GazeAwareBehavior(OnGaze));
            bmp = new Bitmap(panel1.ClientSize.Width, panel1.ClientSize.Height);
            p = new Pen(Color.Green, 3);
        }

        Bitmap bmp;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            g = Graphics.FromImage(bmp);

            initialDrawings(g,panel1);
        }


        private void initialDrawings(Graphics g, Panel panel1) {

            int panelCenterX = panel1.Width / 2;
            int panelCenterY = panel1.Height / 2;
            float radius = 20;

            SolidBrush myBrush = new SolidBrush(Color.Black);

            g.DrawLine(new Pen(Color.Black, 10), panelCenterX - 300, panelCenterY - 200, panelCenterX + 300, panelCenterY - 200);
            g.DrawLine(new Pen(Color.Black, 10), panelCenterX - 300, panelCenterY, panelCenterX + 300, panelCenterY);
            g.DrawLine(new Pen(Color.Black, 10), panelCenterX - 300, panelCenterY + 200, panelCenterX + 300, panelCenterY + 200);
            g.FillEllipse(myBrush, panelCenterX - radius, panelCenterY - radius, radius + radius, radius + radius);

            panel2.Location = new Point(panelCenterX - 50, panelCenterY - 50);
            panel2.Size = new Size(100, 100);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel2.BringToFront();
        }

        private void OnGaze(object sender, GazeAwareEventArgs e)
        {
            var panel = sender as Panel;
            if (panel != null)
            {
                panel.BorderStyle = (e.HasGaze) ? BorderStyle.FixedSingle : BorderStyle.None;

                if (!e.HasGaze)
                {
                    runOnOutOfForcus();
                }
                else {
                    runOnForcus();
                }
            }
        }

        private void runOnForcus() {
            label2.Visible = false;
            label1.Visible = true;
            label1.Text = "Great You are on focus..";
            label1.ForeColor = Color.Green;
        }

        private void runOnOutOfForcus()
        {
            label2.Visible = true;
            label1.Visible = false;
            label2.Text = "Hei.. focus on the drawing area... ";
            label2.ForeColor = Color.Red;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
                using (g = Graphics.FromImage(bmp))
                {                    
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    if (label2.Visible)
                    {
                        p.Color = Color.Yellow;
                    }
                    else {
                        p.Color = Color.Green;
                    }
                   
                    g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                    
                    initX = e.X;
                    initY = e.Y;
                }
                panel1.Invalidate();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = null;
            initY = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, Point.Empty);
        }

        private void changePath()
        {
            Random r = new Random();
            int rInt = r.Next(0, 10000);
            // string patientID = "Patient" + rInt;
            string patientID = "Patient";
            path = @"" + Application.StartupPath + "\\" + patientID;
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changePath();
            string fileName = String.Format(@"{0}\OutFile " + count + ".jpg", path);
            bmp.Save(fileName, ImageFormat.Jpeg);
            count++;
        }
    }
}
