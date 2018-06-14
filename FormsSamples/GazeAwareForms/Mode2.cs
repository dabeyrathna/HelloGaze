using EyeXFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tobii.Interaction;
using Tobii.Interaction.Framework;

namespace GazeAwareForms
{
    public partial class Mode2 : Form
    {
        List<string> list1 = new List<string>();
        List<string> list2 = new List<string>();       

        private readonly Host host;
        private readonly Tobii.Interaction.FixationDataStream fixationDataStream;
        private readonly EyePositionStream eyePositionStream;
        private static FormsEyeXHost _eyeXHost = new FormsEyeXHost();

        public Mode2()
        {
            InitializeComponent();

            host = new Host();
            fixationDataStream = host.Streams.CreateFixationDataStream();

            eyePositionStream = host.Streams.CreateEyePositionStream();//  CreateEyePositionDataStream()

            collectCoordinates();
            collectCoords();
            mouseMove();

        }

        private void collectCoordinates()
        {
            fixationDataStream.Next += (o, fixation) =>
            {
                // On the Next event, data comes as FixationData objects, wrapped in a StreamData<T> object.
                var fixationPointX = fixation.Data.X;
                var fixationPointY = fixation.Data.Y;


                textBox1.Invoke((MethodInvoker)(() => textBox1.Text += ("\n" + fixationPointX.ToString()+ "    " + fixationPointY.ToString())));
                //label2.Invoke((MethodInvoker)(() => label2.Text = fixationPointY.ToString()));

                list1.Add("X is = " + fixation.Data.X + "   y is = " + fixation.Data.Y);
            };
        }

        private void collectCoords()
        {
            eyePositionStream.Next += (o, fixation) =>
            {
                // On the Next event, data comes as FixationData objects, wrapped in a StreamData<T> object.
                var fixationPointX = fixation.Data.LeftEye.X;
                var fixationPointY = fixation.Data.LeftEye.Y;
                var fixationPointZ = fixation.Data.LeftEye.Z;

                textBox2.Invoke((MethodInvoker)(() => textBox2.Text += ("\n" + fixationPointX.ToString() + "    " + fixationPointY.ToString())));
                list2.Add("X is = " + fixationPointX + "   y is = " + fixationPointY + "   z is = " + fixationPointZ);
            };
        }

        private void mouseMove() {
            // textBox3.Invoke((MethodInvoker)(() => textBox3.Text += ("\n" + textBox3.PointToClient(Control.MousePosition))));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }
    }
}
