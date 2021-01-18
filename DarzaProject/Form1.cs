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
    public partial class Form1 : Form
    {
        public string email2;
        public string password2;
        public string username;
        public string email1;
        public string contact1;
        public string password1;
        public static string em;
        public string pass;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-0D2I6DO;User ID=sa;Password=thiagosilva");
            con1.Open();

            string query1 = "select * from customer";
            SqlCommand cmd = new SqlCommand(query1, con1);
            try
            {
                SqlDataReader myReader = cmd.ExecuteReader();
                em = textBox1.Text.ToString();
                pass = textBox2.Text.ToString();

                while (myReader.Read())
                {
                    email2 = myReader["email"].ToString();
                    password2 = myReader["password"].ToString();

                }
                if (em == "Daraz.admin@hotmail.com" & pass == "admin123")
                {
                    this.Hide();
                    Form3 obj_admin = new Form3();
                    obj_admin.Show();
                    MessageBox.Show("Successfully Logged in to Admin panel", "Login",MessageBoxButtons.OK,MessageBoxIcon.Information);


                }

                else if (em == email2 & pass == password2)
                {
                    this.Hide();
                    Form4 obj_cust = new Form4();
                    obj_cust.Show();
                    MessageBox.Show("Successfully Logged in", "Login", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Login failed", "Login failed", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Password " + ex.Message.ToString(), "Credential", MessageBoxButtons.OKCancel);
            }
            con1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 obj_signup = new Form2();
            obj_signup.Show();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            Regex rg_email = new Regex(@"[A-Za-z0-9._]{5,20}[@]{1,1}[a-z]{3,7}[.]{1,1}[a-z]{3,3}");
            if (!rg_email.IsMatch(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Invalid Email");
            }
            else
                errorProvider1.Clear();
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {

            Regex rg_pass = new Regex(@"[A-Za-z0-9@._]{7,20}");
            if (!rg_pass.IsMatch(textBox2.Text))
            {
                errorProvider2.SetError(textBox2, "Invalid Password");
            }
            else
                errorProvider2.Clear();
        }
    }
}
