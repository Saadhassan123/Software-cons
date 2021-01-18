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
    public partial class view : Form
    {
        public view()
        {
            InitializeComponent();
        }

        private void view_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet6.Daraz_Items' table. You can move, or remove it, as needed.
            this.Daraz_ItemsTableAdapter.Fill(this.DataSet6.Daraz_Items);
            // TODO: This line of code loads data into the 'DataSet1.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.DataSet1.customer);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
