using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roocrash
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            guna2CircleProgressBar1.Value = 0;
            guna2CircleProgressBar1.Minimum = 0;
            guna2CircleProgressBar1.Maximum = 100;

        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                InjectButton.Enabled = false;
                Thread.Sleep(5);
                guna2CircleProgressBar1.Value = i;
                guna2CircleProgressBar1.Update();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
