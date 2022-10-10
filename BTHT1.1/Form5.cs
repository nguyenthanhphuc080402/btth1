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
    public partial class Form5 : Form
    {
        public static DataTable dtFruit = new DataTable();
        public static DataTable dtFood = new DataTable();
        public static DataTable dtAnimals = new DataTable();

        public Form5()
        {
            InitializeComponent();
            try
            {

                dtFruit.Columns.Add("STT", typeof(string));
                dtFruit.Columns.Add("Vocab", typeof(string));
                dtFruit.Columns.Add("mean", typeof(string));

                dtFood.Columns.Add("STT", typeof(string));
                dtFood.Columns.Add("Vocab", typeof(string));
                dtFood.Columns.Add("mean", typeof(string));

                dtAnimals.Columns.Add("STT", typeof(string));
                dtAnimals.Columns.Add("Vocab", typeof(string));
                dtAnimals.Columns.Add("mean", typeof(string));

                dtFruit.Rows.Add("1", "Watermelon", "Dưa hấu");
                dtFruit.Rows.Add("2", "Grape", "Nho");
                dtFruit.Rows.Add("3", "Dragon fruit", "Thanh long");
                dtFruit.Rows.Add("4", "Mango", "Xoài");
                dtFruit.Rows.Add("5", "Avocado", "Bơ");
                dtFruit.Rows.Add("6", "Pomegranate", "Lựu");
                dtFruit.Rows.Add("7", "Pineapple", "Khóm");
                dtFruit.Rows.Add("8", "Blueberry", "Việt quất");
                dtFruit.Rows.Add("9", "Lemons", "Chanh");
                dtFruit.Rows.Add("10", "Strawberry", "Dâu tây");

                dtFood.Rows.Add("1", "Bread", "Bánh mì");
                dtFood.Rows.Add("2", "Sausage", "Xúc xích");
                dtFood.Rows.Add("3", "Pasta", "Mì ý");
                dtFood.Rows.Add("4", "Egg", "Trứng");
                dtFood.Rows.Add("5", "Cookies", "Bánh quy");
                dtFood.Rows.Add("6", "Dumplings", "Bánh bao");
                dtFood.Rows.Add("7", "Cream", "Kem");
                dtFood.Rows.Add("8", "Cream cake", "Bánh kem");
                dtFood.Rows.Add("9", "Noodles", "Mì");
                dtFood.Rows.Add("10", "Yogurt", "Sữa chua");

                dtAnimals.Rows.Add("1", "Tiger", "Hổ");
                dtAnimals.Rows.Add("2", "Deer", "Nai");
                dtAnimals.Rows.Add("3", "Penguins", "Chim cánh cụt");
                dtAnimals.Rows.Add("4", "Eagle", "Đại bàng");
                dtAnimals.Rows.Add("5", "Fish", "Cá");
                dtAnimals.Rows.Add("6", "Panther", "Báo");
                dtAnimals.Rows.Add("7", "Parrot", "Vẹt");
                dtAnimals.Rows.Add("8", "Elepant", "Voi");
                dtAnimals.Rows.Add("9", "Lion", "Sư tử");
                dtAnimals.Rows.Add("10", "Crocodile", "Cá xấu");

            }
            catch {}            

            dataGridView1.DataSource = dtFruit;
            dataGridView2.DataSource = dtFood;
            dataGridView3.DataSource = dtAnimals;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_pre_Click(object sender, EventArgs e)
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
