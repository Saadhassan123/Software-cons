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
using System.Text.RegularExpressions;

namespace DarzaProject
{
    public partial class Form2 : Form
    {

        public string username;
        public string email1;
        public string contact1;
        public string password1;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


            username = textBox1.Text.ToString();
            email1 = textBox2.Text.ToString();
            contact1 = textBox3.Text.ToString();
            password1 = textBox4.Text.ToString();

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0D2I6DO;User ID=sa;Password=thiagosilva");
            con.Open();
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into customer values ('" + username + "' ,'" + email1 + "','" + contact1 + "','" + password1 + "')";
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Signed up successfully", "SIGN UP", MessageBoxButtons.OK,MessageBoxIcon.Information);
            con.Close();
            this.Hide();
            
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {

            Regex rg_username = new Regex(@"[A-Za-z0-9._]{7,20}");
            if (!rg_username.IsMatch(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Invalid Username");
            }
            else
                errorProvider1.Clear();

        }

        private void textBox2_Validated(object sender, EventArgs e)
        {

            Regex rg_email = new Regex(@"[A-Za-z0-9._]{5,20}[@]{1,1}[a-z]{3,7}[.]{1,1}[a-z]{3,3}");
            if (!rg_email.IsMatch(textBox2.Text))
            {
                errorProvider2.SetError(textBox2, "Invalid Email");
            }
            else
                errorProvider2.Clear();

        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            Regex rg_contact = new Regex(@"[0]{1,1}[2-3]{1,1}[0-9]{9,9}");
            if (!rg_contact.IsMatch(textBox3.Text))
            {
                errorProvider3.SetError(textBox3, "Invalid Contact");
            }
            else
                errorProvider3.Clear();
        }

        private void textBox4_Validated(object sender, EventArgs e)
        {
            Regex rg_pass = new Regex(@"[A-Za-z0-9@._]{7,20}");
            if (!rg_pass.IsMatch(textBox4.Text))
            {
                errorProvider4.SetError(textBox4, "Invalid Password");
            }
            else
                errorProvider4.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
