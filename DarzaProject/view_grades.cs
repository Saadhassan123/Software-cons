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
    public partial class view_grades : Form
    {
        public view_grades()
        {
            InitializeComponent();
        }

        private void view_grades_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet7.mids' table. You can move, or remove it, as needed.
            this.midsTableAdapter.Fill(this.DataSet7.mids);

            this.reportViewer1.RefreshReport();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_grades_gen view_grades = new View_grades_gen();
            view_grades.Show();
        }
    }
}
