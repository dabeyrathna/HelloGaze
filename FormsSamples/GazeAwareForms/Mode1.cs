
using EyeXFramework;
using EyeXFramework.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazeAwareForms
{
    public partial class Mode1 : Form
    {
        Graphics g;
        Patient p1;

        bool startPaint = false;
        int? initX = null;
        int? initY = null;
        Pen p;
        int count, countIntermediate = 0;
        int lineCount = 1;
        List<string> mouseCoord = new List<string>();
        List<string> eyeCoord = new List<string>();
        bool messageBoxOn = false;
        bool isFocus = true;
        string path = "";

        public Mode1()
        {
            InitializeComponent();

            p1 = new Patient("P123123","Adithi");

            Program.EyeXHost.Connect(behaviorMap1);
           // behaviorMap1.Add(panel1, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(panel2, new GazeAwareBehavior(OnGaze) { DelayMilliseconds = 100 });
            p = new Pen(Color.Green, 3);
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

            int panelCenterX = panel1.Width / 2;
            int panelCenterY = panel1.Height / 2;
            float radius = 20;

            SolidBrush myBrush = new SolidBrush(Color.Black);

            g.DrawLine(new Pen(Color.Black, 10), panelCenterX - 300, panelCenterY - 200, panelCenterX + 300, panelCenterY - 200);
            g.DrawLine(new Pen(Color.Black, 10), panelCenterX - 300, panelCenterY, panelCenterX + 300, panelCenterY);
            g.DrawLine(new Pen(Color.Black, 10), panelCenterX - 300, panelCenterY + 200, panelCenterX + 300, panelCenterY + 200);
            g.FillEllipse(myBrush, panelCenterX - radius, panelCenterY - radius, radius + radius, radius + radius);

           // panel2.Location = new Point(panelCenterX - 50, panelCenterY - 50);
           // panel2.Size = new System.Drawing.Size(100, 100);
           // panel2.BorderStyle = BorderStyle.FixedSingle;
           // panel2.BackColor = Color.FromArgb(0, 0, 0, 0);
           // panel2.BringToFront();
        }

        private void LineDrawing(Panel panel1) {

           // g.Clear(Color.Transparent);//you can choose another color for your background here.
            panel1.Invalidate();

            bmp = new Bitmap(panel1.ClientSize.Width, panel1.ClientSize.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            int panelCenterX = panel1.Width / 2;
            int panelCenterY = panel1.Height / 2;
            float radius = 20;

            SolidBrush myBrush = new SolidBrush(Color.Black);

            if (lineCount == 1) {
                g.DrawLine(new Pen(Color.Black, 10), panelCenterX - 300, panelCenterY - 200, panelCenterX + 300, panelCenterY - 200);
            }
            else if (lineCount == 2) {
                g.DrawLine(new Pen(Color.Black, 10), panelCenterX - 300, panelCenterY, panelCenterX + 300, panelCenterY);
            }
            else if (lineCount == 3) {
                g.DrawLine(new Pen(Color.Black, 10), panelCenterX - 300, panelCenterY + 200, panelCenterX + 300, panelCenterY + 200);
            }
                     
            g.FillEllipse(myBrush, panelCenterX - radius, panelCenterY - radius, radius + radius, radius + radius);

            panel2.Location = new Point(panelCenterX - 50, panelCenterY - 50);
            panel2.Size = new System.Drawing.Size(100, 100);
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
            isFocus = true;
        }

        private void runOnOutOfForcus()
        {
            isFocus = false;

            if (!messageBoxOn) {

                messageBoxOn = true;

                if (Control.MouseButtons.HasFlag(MouseButtons.Left)) {
                    initX = null;
                    initY = null;
                }

                DialogResult dialogResult = MessageBox.Show("Are you done tracing ?\n \n1) Press Yes to trace the next line\n2) Press No to re Trace the line\n\n or \n\n Press Cancel to stop this message", "You are out of focus !!!", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    messageBoxOn = false;
                    if (lineCount < 3)
                    {
                        lineCount++;
                        saveFinalResult();
                        LineDrawing(panel1);
                    }
                    else {
                        MessageBox.Show("You completed the mode 1 tracing","You are done");
                        saveFinalResult();
                        initialDrawings(panel1);
                        messageBoxOn = true;
                    }

                    
                }
                else if (dialogResult == DialogResult.No)
                {
                    messageBoxOn = false;
                    // todo save the current content
                    LineDrawing(panel1);

                    p = new Pen(Color.Green, 3);
                    saveIntermediateResultis();
                }
                else if (dialogResult == DialogResult.Cancel) {
                    messageBoxOn = true;
                }             
            }      
        }

        private void saveFinalResult()
        {
            string fileName = "Final trace " + p1.id +".txt";

            if (mouseCoord.Count > 1)
            {
                using (TextWriter tw = new StreamWriter(fileName, append: true))
                {
                    foreach (String s in mouseCoord)
                        tw.WriteLine(s);

                    tw.WriteLine("----");
                }
                mouseCoord.Clear();
            }
        }

        private void saveIntermediateResultis()
        {
            string fileName = "Intermediate trace "+ p1.id + "Mode 1 Line "+ lineCount +".txt";

            if (mouseCoord.Count > 1)
            {
                using (TextWriter tw = new StreamWriter(fileName, append: true))
                {
                    foreach (String s in mouseCoord)
                        tw.WriteLine(s);

                    tw.WriteLine("----");
                }
                mouseCoord.Clear();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
                p = new Pen(Color.Green, 3);
                using (g = Graphics.FromImage(bmp))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    if (!isFocus)
                    {
                        p.Color = Color.White;                        
                    }
                    else {
                        p.Color = Color.Green;
                    }
                   
                    g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));

                        initX = e.X;
                        initY = e.Y;

                    if (isFocus)
                    {
                        string timeSapanInMillisec = Convert.ToInt64(DateTime.Now.Subtract(new DateTime(1970, 1, 9, 0, 0, 00)).TotalMilliseconds).ToString();
                        mouseCoord.Add(timeSapanInMillisec + ","+e.X+","+e.Y);
                    }  
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            messageBoxOn = false;
            LineDrawing(panel1);
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

        private void saveIntermediateTracing() {
            changePath();
            string fileName = String.Format(@"{0}\Intermediate OutFile " + count + ".jpg", path);
            bmp.Save(fileName, ImageFormat.Jpeg);
            countIntermediate++;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            messageBoxOn = false;
            if (lineCount < 3)
            {                
                lineCount++;
                saveFinalResult();
                LineDrawing(panel1);
            }
            else
            {
                MessageBox.Show("You completed the mode 1 tracing", "You are done");
                saveFinalResult();
                initialDrawings(panel1);
                messageBoxOn = true;
            }
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
