using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formmozg
{
    public partial class Form1 : Form
    {
        private const int Move_Size = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {


        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Top -= Move_Size;
            if (Top < 0)
            {
                Top = 0;
            }
            else if (Top > Screen.PrimaryScreen.WorkingArea.Height - Height) {
                Top = Screen.PrimaryScreen.WorkingArea.Height - Height;
            
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void kozep_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Top = 0;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
