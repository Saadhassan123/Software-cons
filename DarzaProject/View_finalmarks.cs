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
    public partial class View_finalmarks : Form
    {
        public View_finalmarks()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_grades_gen view_grades2 = new View_grades_gen();
            view_grades2.Show();
        }

        private void View_finalmarks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet8.final_marks' table. You can move, or remove it, as needed.
            this.final_marksTableAdapter.Fill(this.DataSet8.final_marks);

            this.reportViewer1.RefreshReport();
        }
    }
}
