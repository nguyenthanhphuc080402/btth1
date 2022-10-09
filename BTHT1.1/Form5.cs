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
                dtFruit.Columns.Add("path", typeof(string));
                dtFruit.Columns.Add("Vocab", typeof(string));
                dtFruit.Columns.Add("mean", typeof(string));

                dtFood.Columns.Add("STT", typeof(string));
                dtFood.Columns.Add("path", typeof(string));
                dtFood.Columns.Add("Vocab", typeof(string));
                dtFood.Columns.Add("mean", typeof(string));

                dtAnimals.Columns.Add("STT", typeof(string));
                dtAnimals.Columns.Add("path", typeof(string));
                dtAnimals.Columns.Add("Vocab", typeof(string));
                dtAnimals.Columns.Add("mean", typeof(string));

                dtFruit.Rows.Add("1", @"Friut\1.png", "Watermelon", "Dưa hấu");
                dtFruit.Rows.Add("2", @"Friut\2.png", "Grape", "Nho");
                dtFruit.Rows.Add("3", @"Friut\3.png", "Dragon fruit", "Thanh long");
                dtFruit.Rows.Add("4", @"Friut\4.png", "Mango", "Xoài");
                dtFruit.Rows.Add("5", @"Friut\5.png", "Avocado", "Bơ");
                dtFruit.Rows.Add("6", @"Friut\6.png", "Pomegranate", "Lựu");
                dtFruit.Rows.Add("7", @"Friut\7.png", "Pineapple", "Khóm");
                dtFruit.Rows.Add("8", @"Friut\8.png", "Blueberry", "Việt quất");
                dtFruit.Rows.Add("9", @"Friut\9.png", "Lemons", "Chanh");
                dtFruit.Rows.Add("10", @"Friut\10.png", "Strawberry", "Dâu tây");

                dtFood.Rows.Add("1", @"food\1.png", "Bread", "Bánh mì");
                dtFood.Rows.Add("2", @"food\2.png", "Sausage", "Xúc xích");
                dtFood.Rows.Add("3", @"food\3.png", "Pasta", "Mì ý");
                dtFood.Rows.Add("4", @"food\4.png", "Egg", "Trứng");
                dtFood.Rows.Add("5", @"food\5.png", "Cookies", "Bánh quy");
                dtFood.Rows.Add("6", @"food\6.png", "Dumplings", "Bánh bao");
                dtFood.Rows.Add("7", @"food\7.png", "Cream", "Kem");
                dtFood.Rows.Add("8", @"food\8.png", "Cream cake", "Bánh kem");
                dtFood.Rows.Add("9", @"food\9.png", "Noodles", "Mì");
                dtFood.Rows.Add("10", @"food\10.png", "Yogurt", "Sữa chua");

                dtAnimals.Rows.Add("1", @"animals\1.png", "Tiger", "Hổ");
                dtAnimals.Rows.Add("2", @"animals\2.png", "Deer", "Nai");
                dtAnimals.Rows.Add("3", @"animals\3.png", "Penguins", "Chim cánh cụt");
                dtAnimals.Rows.Add("4", @"animals\4.png", "Eagle", "Đại bàng");
                dtAnimals.Rows.Add("5", @"animals\5.png", "Fish", "Cá");
                dtAnimals.Rows.Add("6", @"animals\6.png", "Panther", "Báo");
                dtAnimals.Rows.Add("7", @"animals\7.png", "Parrot", "Vẹt");
                dtAnimals.Rows.Add("8", @"animals\8.png", "Elepant", "Voi");
                dtAnimals.Rows.Add("9", @"animals\9.png", "Lion", "Sư tử");
                dtAnimals.Rows.Add("10", @"animals\10.png", "Crocodile", "Cá xấu");

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
