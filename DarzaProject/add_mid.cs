using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarzaProject
{
    public partial class add_mid : Form
    {
        public add_mid()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string std_id = textBox8.Text;
            string std_name = textBox1.Text;
            int maths = Convert.ToInt16(textBox2.Text);
            int eng = Convert.ToInt16(textBox3.Text);
            int urdu = Convert.ToInt16(textBox4.Text);
            int sci = Convert.ToInt16(textBox5.Text);
            int isl = Convert.ToInt16(textBox6.Text);
            string grade = textBox7.Text;
            float obt = maths + eng + urdu + sci + isl;
            float total = obt / 500;
            float percent = total * 100;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0D2I6DO;User ID=sa;Password=thiagosilva");
            con.Open();
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into  mids values ('" + std_id + "','" + std_name + "' ,'" + grade + "','" + maths + "','" + eng + "','" + urdu + "','" + sci + "','" + isl + "','" + percent + "')";
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Grades added successfully", "Grades", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();

            this.Hide();
            view_grades obj_grades = new view_grades();
            obj_grades.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
