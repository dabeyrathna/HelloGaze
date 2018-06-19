using EyeXFramework;
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
    public partial class Gaze : Form
    {
        public Gaze()
        {
            InitializeComponent();
            Program.EyeXHost.Connect(behaviorMap1);
            behaviorMap1.Add(panel1, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(panel2, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(panel3, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(panel4, new GazeAwareBehavior(OnGaze));
        }

        private void OnGaze(object sender, GazeAwareEventArgs e)
        {
            var panel = sender as Panel;
            if (panel != null)
            {
                panel.BorderStyle = (e.HasGaze) ? BorderStyle.FixedSingle : BorderStyle.None;
                panel.BackColor = (e.HasGaze) ? BackColor = Color.White : BackColor = this.BackColor;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
