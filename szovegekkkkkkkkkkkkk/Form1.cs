﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szovegekkkkkkkkkkkkk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Kattints a képernyőre akárhova!";
        }
        private void label1_MouseClicke(object sender, MouseEventArgs e) {

            int a = (int)e.X / (label1.Width / 3);
            int b = (int)e.Y / (label1.Height / 3);

        }



    }
}
