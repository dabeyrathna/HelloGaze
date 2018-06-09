//-----------------------------------------------------------------------
// Copyright 2014 Tobii Technology AB. All rights reserved.
//-----------------------------------------------------------------------

using EyeXFramework;
using System;
using System.Drawing;
using System.Drawing.Imaging;
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

        public GazeAwareForm()
        {
            InitializeComponent();

            // Add eye-gaze interaction behaviors to the panels on the form.
            // The panels should display a border when the user's gaze are on them.
            // Note that panel4 is nested inside panel2. This means that any time 
            // panel2 has the user's gaze, panel4 will too.
            Program.EyeXHost.Connect(behaviorMap1);
            behaviorMap1.Add(panel1, new GazeAwareBehavior(OnGaze));
            bmp = new Bitmap(panel1.ClientSize.Width, panel1.ClientSize.Height);
            p = new Pen(Color.Green, 3);


            //var stream = Program.EyeXHost.CreateEyePositionDataStream();

            //stream.Next += (s, e) => MessageBox.Show("dsdasd", "sfsdfdsfds");


        }

        Bitmap bmp;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            g = Graphics.FromImage(bmp);
            g.DrawLine(new Pen(Color.Blue, 10), 700, 200, 100, 300);
            
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

                    //p = new Pen(Color.Green, 3);
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

        private void button1_Click(object sender, EventArgs e)
        {
            bmp.Save("D://savedItems//OutFile " + count+".jpg", ImageFormat.Jpeg);
            count++;
        }

    }
}
