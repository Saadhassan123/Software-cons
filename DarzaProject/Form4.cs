﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarzaProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            mail();
        }
        public void mail()
        {
            Form1 f1 = new Form1();
            
        }
       

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_mid obj_mids = new add_mid();
            obj_mids.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 add_finals = new Form6();
            add_finals.Show();

        }
    }
}
