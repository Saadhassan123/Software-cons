using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            mail();
        }

       
        public void mail()
        {
            Form1 f1 = new Form1();
            label1.Text = Form1.em;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            view v = new view();
            v.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_grades_gen view_grades = new View_grades_gen();
            view_grades.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
