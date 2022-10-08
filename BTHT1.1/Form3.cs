using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BTHT1._1
{
    public partial class Form3 : Form
    {
        DataTable dt = new DataTable();
        public int index = 0;
        public int CorrectAnswers = 0;
        public int points = 0;
        public int rest = 10;

        DataTable result = new DataTable();


        public Form3(int theme)
        {
            InitializeComponent();
            dt.Columns.Add("STT", typeof(string));
            dt.Columns.Add("path", typeof(string));
            dt.Columns.Add("Vocab", typeof(string));
            dt.Columns.Add("mean", typeof(string));
            if (theme == 1)
            {
                dt.Rows.Add("1", @"Friut\1.png", "Watermelon", "Dưa hấu");
                dt.Rows.Add("2", @"Friut\2.png", "Grape", "Nho");
                dt.Rows.Add("3", @"Friut\3.png", "Dragon fruit", "Thanh long");
                dt.Rows.Add("4", @"Friut\4.png", "Mango", "Xoài");
                dt.Rows.Add("5", @"Friut\5.png", "Avocado", "Bơ");
                dt.Rows.Add("6", @"Friut\6.png", "Pomegranate", "Lựu");
                dt.Rows.Add("7", @"Friut\7.png", "Pineapple", "Khóm");
                dt.Rows.Add("8", @"Friut\8.png", "Blueberry", "Việt quất");
                dt.Rows.Add("9", @"Friut\9.png", "Lemons", "Chanh");
                dt.Rows.Add("10", @"Friut\10.png", "Strawberry", "Dâu tây");
            }else if(theme == 2)
            {
                dt.Rows.Add("1", @"food\1.png", "Bread", "Bánh mì");
                dt.Rows.Add("2", @"food\2.png", "Sausage", "Xúc xích");
                dt.Rows.Add("3", @"food\3.png", "Pasta", "Mì ý");
                dt.Rows.Add("4", @"food\4.png", "Egg", "Trứng");
                dt.Rows.Add("5", @"food\5.png", "Cookies", "Bánh quy");
                dt.Rows.Add("6", @"food\6.png", "Dumplings", "Bánh bao");
                dt.Rows.Add("7", @"food\7.png", "Cream", "Kem");
                dt.Rows.Add("8", @"food\8.png", "Cream cake", "Bánh kem");
                dt.Rows.Add("9", @"food\9.png", "Noodles", "Mì");
                dt.Rows.Add("10", @"food\10.png", "Yogurt", "Sữa chua");
            }
            else
            {
                dt.Rows.Add("1", @"animals\1.png", "Tiger", "Hổ");
                dt.Rows.Add("2", @"animals\2.png", "Deer", "Nai");
                dt.Rows.Add("3", @"animals\3.png", "Penguins", "Chim cánh cụt");
                dt.Rows.Add("4", @"animals\4.png", "Eagle", "Đại bàng");
                dt.Rows.Add("5", @"animals\5.png", "Fish", "Cá");
                dt.Rows.Add("6", @"animals\6.png", "Panther", "Báo");
                dt.Rows.Add("7", @"animals\7.png", "Parrot", "Vẹt");
                dt.Rows.Add("8", @"animals\8.png", "Elepant", "Voi");
                dt.Rows.Add("9", @"animals\9.png", "Lion", "Sư tử");
                dt.Rows.Add("10", @"animals\10.png", "Crocodile", "Cá xấu");
            }

            result.Columns.Add("Core", typeof(string));
        }

        public void RemoveText()
        {
            if (txt_input.Text == "Type your answer here...")
            {

                txt_input.Text = "";
            }
        }

        public void AddText()
        {
            if (String.IsNullOrWhiteSpace(txt_input.Text))
            {
                txt_input.Text = "Type your answer here...";
            }
        }

        public void CorrectAnswer()
        {
            //txt_input.Enabled = false;
            
            lbl_Feedback.Text = "Great job!You correctly.";
            CorrectAnswers++;
            lbl_Feedback.Visible = true;
            lbl_Feedback.ForeColor = Color.Green;
            points += 10;
            lblPoints.Text = points+"/100";
        }
        public void IncorrectAnswer()
        {
            //txt_input.Enabled = false;
            lbl_Feedback.ForeColor = Color.Red;
            lbl_Feedback.Text = "Sorry, your answer was incorrect.";
            lbl_Feedback.Visible = true;
        }


        private void btn_check_Click(object sender, EventArgs e)
        {
            if (index < 10)
            {
                string path = Convert.ToString(dt.Rows[index]["path"]);
                string volab = Convert.ToString(dt.Rows[index-1]["Vocab"]);
                //MessageBox.Show(Convert.ToString(dt.Rows[index]["path"]));
                if (txt_input.Text.Trim() == "" || txt_input.Text.Trim() == "Type your answer here...")
                {
                    lbl_Feedback.Visible = true;
                    lbl_Feedback.ForeColor = Color.Red;
                    //lbl_Feedback.Text = "Please type an answer first!";
                }
                MessageBox.Show("Từ chính xác: "+volab);
                if (volab.Trim().ToLower() == txt_input.Text.Trim().ToLower())
                {
                    CorrectAnswer();
                }
                else
                {
                    IncorrectAnswer();

                }
                index++;
                //MessageBox.Show(Directory.GetCurrentDirectory());
                picture.BackgroundImage = Image.FromFile(@"..\\..\\image\" + path);
                rest--;
                lblAttempts.Text = (Convert.ToString(rest));
            }else if(index == 10)
            {
                picture.Visible = false;
                txt_input.Visible = false;
                btn_check.Visible = false;
                lbl_Feedback.Visible = false;
                lbl_core.Text = Convert.ToString(points / 10 + "/10");
                pal_left.Visible = false;
                pal_right.Visible = false;
                pal_result.Visible = true;
            }
            txt_input.Text = "";
            txt_input.Focus();
        }

        private void pictureBox2_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string path = Convert.ToString(dt.Rows[index]["path"]);
            picture.BackgroundImage = Image.FromFile(@"..\\..\\image\" + path);
            index++;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_input_Enter(object sender, EventArgs e)
        {
            RemoveText();
        }

        private void txt_input_Leave(object sender, EventArgs e)
        {
            AddText();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btn_music_Click(object sender, EventArgs e)
        {
            Form1.player.controls.stop();
            if (Form1.sound)
            {
                Form1.player.controls.play();
                btn_music.BackgroundImage = Image.FromFile(@"..\\..\\image\Volu.png");
                Form1.sound = false;
            }
            else
            {
                Form1.player.controls.stop();
                btn_music.BackgroundImage = Image.FromFile(@"..\\..\\image\NotVolu.png");
                Form1.sound = true;
            }
        }
    }
}
