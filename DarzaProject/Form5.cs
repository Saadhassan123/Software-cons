using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarzaProject
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            mail();
        }

        public void mail()
        {
            Form1 f1 = new Form1();
            label1.Text = Form1.em;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void list()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0D2I6DO;User ID=sa;Password=thiagosilva");
            con.Open();
            string query1 = "Select Cat_Name from Daraz_cat";
            SqlCommand cmd = new SqlCommand(query1, con);
            try
            {
                SqlDataReader myReader2 = cmd.ExecuteReader();

               
            }

            catch (Exception ex)
            {
                MessageBox.Show("There was an error while loading categories" + ex, "List error", MessageBoxButtons.OK);
            }

            con.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            OpenFileDialog opf = new OpenFileDialog();
            
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                
                pictureBox3.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string f_name = textBox2.Text;
            string it_name = textBox1.Text;
            DateTime dob = dateTimePicker2.Value;
            string it_price = textBox3.Text;
            string std_class = textBox4.Text;
            Image itemimage1 = pictureBox3.Image;


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0D2I6DO;User ID=sa;Password=thiagosilva");
            con.Open();
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into Daraz_Items values ('" + it_name + "' ,'" + it_price + "','" + std_class + "','" + itemimage1 + "','" +f_name + "','" + dob + "')";
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Item inserted successfully", "Items", MessageBoxButtons.OK,MessageBoxIcon.Information);
            con.Close();

            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {

            Regex rg_item = new Regex(@"[A-Z a-z]{3,20}}");
            if (!rg_item.IsMatch(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Invalid Itemname");
            }
            else
                errorProvider1.Clear();
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {

            Regex rg_item = new Regex(@"[0-9]{1,10}");
            if (!rg_item.IsMatch(textBox2.Text))
            {
                errorProvider2.SetError(textBox2, "Invalid Quantity");
            }
            else
                errorProvider2.Clear();
        }

        private void textBox3_Validated(object sender, EventArgs e)
        {

            Regex rg_item = new Regex(@"[0-9]{1,10}");
            if (!rg_item.IsMatch(textBox3.Text))
            {
                errorProvider3.SetError(textBox3, "Invalid Price");
            }
            else
                errorProvider3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            view v1 = new view();
            v1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_grades_gen view_grades = new View_grades_gen();
            view_grades.Show();
        }
    }
}
