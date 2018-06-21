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
    using System;
    using EyeXFramework;
    using GazeAwareForms;

    public partial class Gaze : Form
    {
        int count = 0;
        Timer timer = new Timer();
        public Gaze()
        {
            InitializeComponent();
            Program.EyeXHost.Connect(behaviorMap1);
            behaviorMap1.Add(panel1, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(panel2, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(panel3, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(panel4, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(panel5, new GazeAwareBehavior(OnGaze));

            panel5.Visible = false;
        }

        private void OnGaze(object sender, GazeAwareEventArgs e)
        {
            var panel = sender as Panel;

            if (count > 4)
            {
                button1.Visible = true;
                label1.Text = "Great ! Your Gaze test is successful.";
                timer.Interval = 2000;
                timer.Tick += new EventHandler(closeGazeForm);
                timer.Start();
            }
            else {
                if (panel != null)
                {
                    if (count == 4) {
                        panel5.BackColor = Color.White;
                        panel5.BorderStyle = BorderStyle.None;
                        panel5.Visible = true;
                    }
                    if (panel.BackColor != Color.White)
                    {
                        count++;
                        
                        panel.BorderStyle = (e.HasGaze) ? BorderStyle.FixedSingle : BorderStyle.None;
                        panel.BackColor = (e.HasGaze) ? BackColor = Color.White : BackColor = this.BackColor;
                    }
                }
            }
        }

        private void closeGazeForm(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Gaze_Load(object sender, EventArgs e)
        {

        }
    }
}
