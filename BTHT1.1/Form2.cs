using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTHT1._1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3("Fruit");
            frm.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void btn_food_Click(object sender, EventArgs e)
        {
            //MessageBox.Show();
            Form3 frm = new Form3("Food");
            frm.Show();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3("Animals");
            frm.Show();
        }
    }
}
