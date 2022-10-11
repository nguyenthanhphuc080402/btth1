using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTHT1._1
{
    public partial class Form4 : Form
    {
        public Form4(DataTable dt)
        {
            InitializeComponent();
            dataGridView1.DataSource = dt;
            //dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
        }

        private void pal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
