using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;
using System.IO;

namespace BTHT1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static WindowsMediaPlayer player = new WindowsMediaPlayer();
        public static bool sound = true;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Form2 page2 = new Form2();
            page2.Show();
        }

        private void btn_start_MouseHover(object sender, EventArgs e)
        {
        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
        }

        
        private void btn_music_Click(object sender, EventArgs e)
        {
            player.URL = @"D:\HK1 2022-2023\CS511\BTTH\BTHT1.1\BTHT1.1\sound\music.mp3";
            if (sound)
            {
                player.controls.play();
                btn_music.BackgroundImage = Image.FromFile(@"..\\..\\image\Volu.png");
                sound = false;
            }
            else
            {
                player.controls.stop();
                btn_music.BackgroundImage = Image.FromFile(@"..\\..\\image\NotVolu.png");
                sound = true;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
