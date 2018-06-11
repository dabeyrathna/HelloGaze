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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnMode1_Click(object sender, EventArgs e)
        {
            Form mode1 = new Mode1();
            mode1.Show();
        }

        private void btnMode2_Click(object sender, EventArgs e)
        {
            Form mode2 = new Mode2(); 
            mode2.Show(); 
        }
    }
}
