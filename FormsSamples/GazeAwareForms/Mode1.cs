
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
using Tobii.EyeX.Framework;
using Tobii.Interaction;

namespace GazeAwareForms
{
    public partial class Mode1 : Form
    {
        Graphics g;
        PatientInfo p1;
        int mode;
        
        int? initX = null;
        int? initY = null;
        Pen p;
        int count, countIntermediate = 0;
        int lineCount = 1;
        List<string> mouseCoord = new List<string>();
        List<string> eyeCoord = new List<string>();
        List<string> mirrorCoords = new List<string>();

        bool tracingMessageBoxOn = false;
        bool mirrorMassageBoxOn = false;
        bool isFocus = true;
        bool isMirrorTracingDone = true;
        bool startPaint = false;

        string path = "";
        Bitmap bmp;

        int startingPointX;
        int startingPointY;
        int endingPointX;
        int endingPointY;

        bool visibleArea = false;

        private readonly Host host;
        private readonly EyePositionStream eyePositionStream;

        public Mode1()
        {
            InitializeComponent();
            mode = 1;
            Program.EyeXHost.Connect(behaviorMap1);
           // behaviorMap1.Add(panel1, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(panel2, new EyeXFramework.GazeAwareBehavior(OnGaze) { DelayMilliseconds = 100 });
            p = new Pen(Color.Green, 3);

            ///////////////////////////////////////

            host = new Host();
            eyePositionStream = host.Streams.CreateEyePositionStream();//  CreateEyePositionDataStream()


            ///////////////////////////////////////


        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e); 
            initialDrawings(panel1);
            lblMode.Text = "Mode " + mode;

            if (mode == 2) {
                eyeCoordsCollection();
            }
            
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

            panel2.Location = new Point(0, 0);
            panel2.Size = new System.Drawing.Size(0, 0);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel2.BringToFront();
        }

        private void LineDrawingMode1(Panel panel1) {
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

            panel2.Location = new Point(panelCenterX - 100, panelCenterY - 100);
            panel2.Size = new System.Drawing.Size(200, 200);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel2.BringToFront();
        }

        private void LineDrawingMode2(Panel panel1)
        {

            // g.Clear(Color.Transparent);//you can choose another color for your background here.
            panel1.Invalidate();

            bmp = new Bitmap(panel1.ClientSize.Width, panel1.ClientSize.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            int panelCenterX = panel1.Width / 2;
            int panelCenterY = panel1.Height / 2;

            SolidBrush myBrush = new SolidBrush(Color.Black);            

            if (lineCount == 1)
            {
                startingPointX = panelCenterX - 300;
                startingPointY = panelCenterY - 200;
                endingPointX = panelCenterX + 300;
                endingPointY = panelCenterY - 200;

                g.DrawLine(new Pen(Color.Black, 10), startingPointX, startingPointY, endingPointX, endingPointY);
                panel2.Location = new Point(startingPointX-200, startingPointY-150);
                panel2.Size = new System.Drawing.Size(startingPointX + 500, 300);
            }
            else if (lineCount == 2)
            {
                startingPointX = panelCenterX - 300;
                startingPointY = panelCenterY;
                endingPointX = panelCenterX + 300;
                endingPointY = panelCenterY;

                g.DrawLine(new Pen(Color.Black, 10), startingPointX, startingPointY, endingPointX, endingPointY);
                panel2.Location = new Point(startingPointX - 200, startingPointY - 150);
                panel2.Size = new System.Drawing.Size(startingPointX + 500, 300);
            }
            else if (lineCount == 3)
            {
                startingPointX = panelCenterX - 300;
                startingPointY = panelCenterY + 200;
                endingPointX = panelCenterX + 300;
                endingPointY = panelCenterY + 200;

                g.DrawLine(new Pen(Color.Black, 10), startingPointX, startingPointY, endingPointX, endingPointY);
                panel2.Location = new Point(startingPointX - 200, startingPointY - 150);
                panel2.Size = new System.Drawing.Size(startingPointX + 500, 300);
            }

            //g.FillEllipse(myBrush, panelCenterX - radius, panelCenterY - radius, radius + radius, radius + radius);

           // panel2.Location = new Point(panelCenterX - 50, panelCenterY - 50);
           // panel2.Size = new System.Drawing.Size(100, 100);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel2.Visible = visibleArea;
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
            isFocus = true;         // when ever patient is come back to focus update the global status of focus
        }

        private void runOnOutOfForcus()
        {
            isFocus = false;         // globally indicate that patient was out of focus

            if (!mirrorMassageBoxOn && !isMirrorTracingDone && mode == 2)
            {
                displayMirrorMessageBox();
            }
            else if (!tracingMessageBoxOn && isMirrorTracingDone) {
                displayTracingMessageBox();
            }
        }

        private void displayTracingMessageBox() {
            tracingMessageBoxOn = true;  // globally indicate that message box popup

            startPaint = false;  // if message box appear while drawing, this will stop drawing
            initX = null;
            initY = null;

            DialogResult dialogResult = MessageBox.Show("Are you done tracing ?\n \n1) Press Yes to trace the next line\n2) Press No to re Trace the line\n\n or \n\n Press Cancel to stop this message", "You are out of focus !!!", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                tracingMessageBoxOn = false;
                if (lineCount < 3)
                {
                    if (mode == 1)
                    {
                        lineCount++;
                        saveFinalResult();
                        LineDrawingMode1(panel1);
                    }
                    else if (mode == 2) {
                        drawMirror(panel1, false);
                        if (isMirrorTracingDone)
                        {
                            lineCount++;
                            saveFinalResult();
                            if (mode == 2)
                            {
                                LineDrawingMode2(panel1);
                            }
                            isMirrorTracingDone = false;
                        }
                    }
                }
                else
                {
                    drawMirror(panel1, false);
                    tracingMessageBoxOn = true;
                    if (isMirrorTracingDone || mode == 1)
                    {
                        saveFinalResult();
                        initialDrawings(panel1);                        
                        MessageBox.Show("You completed the mode " + mode + " tracing", "You are done");
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                tracingMessageBoxOn = false;
                // todo save the current content
                if (mode == 1)
                {
                    LineDrawingMode1(panel1);
                }
                else if (mode == 2)
                {
                    LineDrawingMode2(panel1);
                }

                p = new Pen(Color.Green, 3);
                saveIntermediateResultis();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                tracingMessageBoxOn = true;
            }
        }

        private void displayMirrorMessageBox() {
            mirrorMassageBoxOn = true;  // globally indicate that message box popup

            startPaint = false;  // if message box appear while drawing, this will stop drawing
            initX = null;
            initY = null;

            DialogResult dialogResult = MessageBox.Show("Are you done tracing mirror line?\n \n1) Press Yes to proceed\n2) Press No to re Trace the mirror line\n\n or \n\n Press Cancel to stop this message", "You are out of focus !!!", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                mirrorMassageBoxOn = false;
                mirrorCoords.Clear();               

                bool reDrawMirror = checkOverlappingOfTracingAndRL();  // todo

                if (!reDrawMirror)
                {
                    MessageBox.Show("re draw called");
                    drawMirror(panel1, false);
                }
                else
                {
                    isMirrorTracingDone = true;
                    mouseCoord.Clear();                    

                   // MessageBox.Show("mirror completed count is "+lineCount);

                    if (lineCount < 3)
                    {
                        lineCount++;
                        tracingMessageBoxOn = false;
                        LineDrawingMode2(panel1);
                    }
                    else {
                        saveFinalResult();
                        initialDrawings(panel1);
                        tracingMessageBoxOn = true;
                        MessageBox.Show("You completed the mode " + mode + " tracing", "You are done");
                    }
                }                
            }
            else if (dialogResult == DialogResult.No)
            {
                mirrorMassageBoxOn = false;
                drawMirror(panel1, true);
                //saveIntermediateResultis();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                tracingMessageBoxOn = true;
                mirrorMassageBoxOn = true;
            }
        }

        private void drawMirror(Panel panel1, bool reDraw)
        {
            isMirrorTracingDone = false;
            // g.Clear(Color.Transparent);//you can choose another color for your background here.
            panel1.Invalidate();

            bmp = new Bitmap(panel1.ClientSize.Width, panel1.ClientSize.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            string[] tempCoordinateUpdate;
            if (!reDraw) {
                mirrorCoords.Clear();
                for (int i = 0; i < mouseCoord.Count; i++)
                {
                    tempCoordinateUpdate = mouseCoord[i].Split(',');
                    tempCoordinateUpdate[2] = (startingPointY - (Convert.ToInt32(tempCoordinateUpdate[2]) - startingPointY)).ToString();
                    mirrorCoords.Add(tempCoordinateUpdate[0]+ "," + tempCoordinateUpdate[1] + "," + tempCoordinateUpdate[2]);
                }
            }

            if (mirrorCoords.Count > 3)
            {
                int x = Convert.ToInt32(mirrorCoords[0].Split(',')[1]);
                int y = Convert.ToInt32(mirrorCoords[0].Split(',')[2]);
                int nextX;
                int nextY;

                for (int i = 1; i < mirrorCoords.Count; i++)
                {
                    p = new Pen(Color.Red, 3);
                    using (g = Graphics.FromImage(bmp))
                    {
                        nextX = Convert.ToInt32(mirrorCoords[i].Split(',')[1]);
                        nextY = Convert.ToInt32(mirrorCoords[i].Split(',')[2]);
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        g.DrawLine(p, new Point(x, y), new Point(nextX, nextY));
                        x = nextX;
                        y = nextY;
                    }
                    panel1.Invalidate();
                }
                //g.FillEllipse(myBrush, panelCenterX - radius, panelCenterY - radius, radius + radius, radius + radius);

                // panel2.Location = new Point(panelCenterX - 50, panelCenterY - 50);
                // panel2.Size = new System.Drawing.Size(100, 100);
                panel2.BorderStyle = BorderStyle.FixedSingle;
                panel2.BackColor = Color.FromArgb(0, 0, 0, 0);
                panel2.Visible = visibleArea;
                panel2.BringToFront();
            }
        }

        private bool checkOverlappingOfTracingAndRL()
        {
            int maxDistance = Math.Abs(startingPointY - Convert.ToInt32(mouseCoord[0].Split(',')[2])); 
            int minDistance = Math.Abs(startingPointY - Convert.ToInt32(mouseCoord[0].Split(',')[2])); 
            int tempDist = 0; 
            for (int i = 1; i < mouseCoord.Count; i++) {
                tempDist = Math.Abs(startingPointY - Convert.ToInt32(mouseCoord[i].Split(',')[2]));

                if (tempDist > maxDistance) {
                    maxDistance = tempDist;
                }
                if (tempDist < minDistance) {
                    minDistance = tempDist;
                }

                if (minDistance < 1 || maxDistance < 10) {              // todo what should be the threashold
                    //return false;
                }
            }
            return true;
        }

        private void saveFinalResult()
        {
            string fileName = "Patient\\Final trace " + PatientInfo.patientId +".txt";

            if (mouseCoord.Count > 1)
            {
                using (TextWriter tw = new StreamWriter(fileName, append: true))
                {
                    for(int i = 0; i < mouseCoord.Count; i++)
                        tw.WriteLine(mouseCoord[i]);

                    tw.WriteLine("----");
                }
                mouseCoord.Clear();

                if (mode == 2) {
                    fileName = "Patient\\Final eye " + PatientInfo.patientId + ".txt";

                    using (TextWriter tw = new StreamWriter(fileName, append: true))
                    {
                        for (int i = 0; i < eyeCoord.Count; i++)
                            tw.WriteLine(eyeCoord[i]);

                        tw.WriteLine("----");
                    }
                    eyeCoord.Clear();
                }
            }
        }

        private void saveIntermediateResultis()
        {
            string fileName = "Patient\\Intermediate trace "+ PatientInfo.patientId + "Mode 1 Line "+ lineCount +".txt";

            if (mouseCoord.Count > 1)
            {
                using (TextWriter tw = new StreamWriter(fileName, append: true))
                {
                    for (int i = 0; i < mouseCoord.Count; i++)
                        tw.WriteLine(mouseCoord[i]);

                    tw.WriteLine("----");
                }
                mouseCoord.Clear();

                //if (mode == 2)
                //{
                //    fileName = "Intermediate eye " + p1.id + "Mode 1 Line " + lineCount + ".txt";

                //    using (TextWriter tw = new StreamWriter(fileName, append: true))
                //    {
                //        foreach (String s in eyeCoord)
                //            tw.WriteLine(s);

                //        tw.WriteLine("----");
                //    }
                //    eyeCoord.Clear();
                //}
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
                        //if (mode == 1) // collect only tracing coordinates when it is mode 1
                        //{
                            string timeSapanInMillisec = Convert.ToInt64(DateTime.Now.Subtract(new DateTime(1970, 1, 9, 0, 0, 00)).TotalMilliseconds).ToString();
                            mouseCoord.Add(timeSapanInMillisec + "," + e.X + "," + e.Y);
                        //}
                        if (mode == 2) // collect eye coordinates only if it is mode 2
                        {
                            //using (var lightlyFilteredGazeDataStream = Program.EyeXHost.CreateGazePointDataStream(GazePointDataMode.LightlyFiltered))
                            //{
                            //    lightlyFilteredGazeDataStream.Next += (s, eEye) =>
                            //    {
                            //        string timeSapanInMillisec = Convert.ToInt64(DateTime.Now.Subtract(new DateTime(1970, 1, 9, 0, 0, 00)).TotalMilliseconds).ToString();
                            //        eyeCoord.Add(timeSapanInMillisec + "," + eEye.X + "," + eEye.Y);
                            //        textBox1.Invoke((MethodInvoker)(() => textBox1.Text += ("\n" + timeSapanInMillisec + "," + e.X + "," + e.Y)));
                            //        mouseCoord.Add(timeSapanInMillisec + "," + e.X + "," + e.Y);
                            //    };
                            //}

                            eyePositionStream.Next += (o, fixation) =>
                            {
                                // On the Next event, data comes as FixationData objects, wrapped in a StreamData<T> object.
                                var fixationPointX = fixation.Data.LeftEye.X;
                                var fixationPointY = fixation.Data.LeftEye.Y;
                                var fixationPointZ = fixation.Data.LeftEye.Z;
                                eyeCoord.Add(timeSapanInMillisec + "," + fixationPointX + "," + fixationPointY);
                               // mouseCoord.Add(timeSapanInMillisec + "," + e.X + "," + e.Y);
                            };
                        }
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

        private void eyeCoordsCollection()
        {
            if (mode == 2) // collect eye coordinates only if it is mode 2
            {
                //using (var lightlyFilteredGazeDataStream = Program.EyeXHost.CreateGazePointDataStream(GazePointDataMode.LightlyFiltered))
                //{
                //    lightlyFilteredGazeDataStream.Next += (s, e) =>
                //    {
                //        string timeSapanInMillisec = Convert.ToInt64(DateTime.Now.Subtract(new DateTime(1970, 1, 9, 0, 0, 00)).TotalMilliseconds).ToString();
                //        eyeCoord.Add(timeSapanInMillisec + "," + e.X + "," + e.Y);
                //    };
                //}               

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tracingMessageBoxOn = false;
            lineCount = 1;

            if (mode == 1) {
                LineDrawingMode1(panel1);
            }
            else if (mode == 2) {
                LineDrawingMode2(panel1);
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, Point.Empty);
        }

        private void changePath()
        {
            Random r = new Random();                        // todo : dynamic path selection
            int rInt = r.Next(0, 10000);
            // string patientID = "Patient" + rInt;
            string patientID = "Patient";
            path = @"" + Application.StartupPath + "\\" + patientID;
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tracingMessageBoxOn = false;
            if (lineCount < 3)
            {                
                lineCount++;
                saveFinalResult();
                LineDrawingMode1(panel1);
            }
            else
            {
                saveFinalResult();
                initialDrawings(panel1);
                tracingMessageBoxOn = true;
                MessageBox.Show("You completed the mode "+mode+" tracing", "You are done");                
            }
        }

        private void btnChangeMode_Click(object sender, EventArgs e)
        {
            if (mode == 1) {
                mode = 2;
                eyeCoordsCollection(); // when mode 2 activated eye coordinates collection starts
            }
            else {
                mode = 1;
            }
            lblMode.Text = "Mode " + mode;
        }

        private void saveIntermediateTracing() {
            changePath();
            string fileName = String.Format(@"{0}\Intermediate OutFile " + count + ".jpg", path);
            bmp.Save(fileName, ImageFormat.Jpeg);
            countIntermediate++;
        }

        private void btnVisionArea_Click(object sender, EventArgs e)
        {
            visibleArea = visibleArea ? false : true;
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
