using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterFowlHuntingGame
{
    public partial class WaterFowlHuntingGame : Form
    {
        public WaterFowlHuntingGame()
        {
            InitializeComponent();
            Bitmap bmp = new Bitmap(Properties.Resources.gun);
            Cursor crsr = new Cursor(bmp.GetHicon()); this.Cursor = crsr;
            lbl_over.Visible = false; 
        }
        int kill;
        int missed; 

        void Sound()
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\null_Ptr\Desktop\C sharp\WaterFowlHuntingGame\WaterFowlHuntingGame\Resources\shoot6.wav");
            sound.Play();
        }

        void Game_Result()
        {
            if(lbl_missed.Text=="Missed : 4")
            {
                //This code is to display game over,if 
                // the missed shot is equal to 4. 
                lbl_over.Visible = true;
                timer1.Stop(); 
            }
            //This code is to display Level Up,if the killed shot is 
            //equal to 50 
            if(lbl_Kill.Text=="Killed: 50")
            {
                lbl_over.Text = "Level up...";
                lbl_over.Visible = true;
                timer1.Stop(); 

            }

        }
        void Birds()
        {
            if (picBird1.Left < 0)
            {
                picBird1.Left = 650;
                picBird1.Image = Properties.Resources.bird1;
            }
            if (picBird2.Left < 0)
            {
                picBird2.Left = 650;
                picBird2.Image = Properties.Resources.bird2;
            }
            if (picBird3.Left < 0)
            {
                picBird3.Left = 650;
                picBird3.Image = Properties.Resources.bird3;
            }
            picBird1.Left -= 5; picBird2.Left -= 5; picBird3.Left -= 5;
        }
       
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Birds();
            Game_Result();
        }
     
        private void WaterFowlHuntingGame_MouseClick(object sender, MouseEventArgs e)
        {
            Sound();
            missed++;
            lbl_missed.Text = "Missed : " + missed;

        }

        private void picBird1_Click(object sender, EventArgs e)
        {
            kill++;
            lbl_Kill.Text = "Bird Killed: " + kill;
            picBird1.Image = Properties.Resources.ex;
            Sound();
        }

        private void picBird2_Click(object sender, EventArgs e)
        {

            kill++;
            lbl_Kill.Text = "Bird Killed: " + kill;
            picBird2.Image = Properties.Resources.ex;
            Sound();
        }

        private void picBird3_Click(object sender, EventArgs e)
        {

            kill++;
            lbl_Kill.Text = "Bird Killed: " + kill;
            picBird3.Image = Properties.Resources.ex;
            Sound();
        }

        private void lbl_Kill_Click(object sender, EventArgs e)
        {

        }
    }
}

 