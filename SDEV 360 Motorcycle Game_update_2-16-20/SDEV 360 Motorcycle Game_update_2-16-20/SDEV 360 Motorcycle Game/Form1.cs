using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Neil SDEV 360 week 4 Motorcycle game

namespace SDEV_360_Motorcycle_Game
{
    public partial class Form1 : Form
    {
        int speed = 5;
        int score = 0;

        public Form1()
        {
            InitializeComponent();

            picBackGround.Location = new Point(0,80);

            picBoulder1.Parent = picBackGround;
            picBoulder2.Parent = picBackGround;
            picBoulder3.Parent = picBackGround;
            picBoulder4.Parent = picBackGround;
            picBoulder5.Parent = picBackGround;
            picBoulder6.Parent = picBackGround;
            picBoulder7.Parent = picBackGround;
            picBoulder8.Parent = picBackGround;
            picBoulder9.Parent = picBackGround;
            picBoulder10.Parent = picBackGround;
            picBoulder11.Parent = picBackGround;
            picBoulder12.Parent = picBackGround;

            picBoulder1.Location = new Point(200,300);
            picBoulder2.Location = new Point(500,275);
            picBoulder3.Location = new Point(800,300);
            picBoulder4.Location = new Point(1100,275);
            picBoulder5.Location = new Point(1400, 300);
            picBoulder6.Location = new Point(1700, 275);

            picBoulder7.Location = new Point(2000, 300);
            picBoulder8.Location = new Point(2300, 275);
            picBoulder9.Location = new Point(2600, 300);
            picBoulder10.Location = new Point(2900, 275);
            picBoulder11.Location = new Point(3200, 300);
            picBoulder12.Location = new Point(3500, 275);

            picBike.Location = new Point(30,185);
            picBike.Parent = picBackGround;

            lblGameOver.Visible = false;
            lblYouWin.Visible = false;
            

        }
        //////////////////////////this method scrolls the background picturebox//////////////////////////
        private void MoveBackground(int speed)
        {
            if (picBackGround.Location.X >= -1800 )
            {
                picBackGround.Location = new Point(picBackGround.Location.X - speed, picBackGround.Location.Y);
                
                picBike.Location = new Point(picBike.Location.X + speed, picBike.Location.Y);
                picBike.Refresh();
            }
            else
            {
                picBackGround.Location = new Point(0, picBackGround.Location.Y);

                picBike.Location = new Point(30, picBike.Location.Y);
                picBike.Refresh();
            }
           
        }

        private void timerSpeed_Tick(object sender, EventArgs e)
        {
            speed++;
        }

            //////////////////////////background image timer//////////////////////////
            private void timerBackGround_Tick(object sender, EventArgs e)
        {
            MoveBackground(speed);
            score += speed;
            txtScore.Text = score.ToString();
           
            if (Collision.Crashed(picBoulder1, picBike) || Collision.Crashed(picBoulder2, picBike) || Collision.Crashed(picBoulder3, picBike) 
                || Collision.Crashed(picBoulder4, picBike) || Collision.Crashed(picBoulder5, picBike) || Collision.Crashed(picBoulder6, picBike)
                || Collision.Crashed(picBoulder7, picBike) || Collision.Crashed(picBoulder8, picBike) || Collision.Crashed(picBoulder9, picBike)
                || Collision.Crashed(picBoulder10, picBike) || Collision.Crashed(picBoulder11, picBike) || Collision.Crashed(picBoulder12, picBike))
            {
                buttonStop.PerformClick();
                lblGameOver.Visible = true;
            }
        }

        protected bool r = true;
      
        private void buttonGo_Click(object sender, EventArgs e)  // This button starts the acceleration timer and sets the engine interval to 50 (fast)
        {
            btnDown.Enabled = true;
            btnUp.Enabled = true;
            timerAnimate.Interval = 50;
            timerBackGround.Enabled = true;
            timerSpeed.Interval = 10000;
            timerSpeed.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)// this button stops the acceleration timer and changes the engine interval to an idol (100, slow)
        {
            timerBackGround.Enabled = false;
            btnDown.Enabled = false;
            btnUp.Enabled = false;
            timerAnimate.Interval = 100;
        }

        private void timerAnimate_Tick(object sender, EventArgs e)  //This timer animates the motorcycle's engine vibrations
        {

            if (r==false) 
            {
                picBike.Image = Properties.Resources.sprite_bike_02;  //the images are loaded as resources
                r = true;
            }
            else
            {
                picBike.Image = Properties.Resources.sprite_bike_01;
                r = false;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (picBike.Location.Y < 210) 
            {
                picBike.Location = new Point(picBike.Location.X, picBike.Location.Y + 25);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (picBike.Location.Y > 185)
            {
                picBike.Location = new Point(picBike.Location.X, picBike.Location.Y - 25);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
          
            //capture space bar key
            if (keyData == Keys.Space)
            {
                if(picBike.Location.Y == 185)
                {
                    btnDown.PerformClick();
                    return true;
                }
                else if(picBike.Location.Y == 210)
                {
                    btnUp.PerformClick();
                    return true;
                }
            }
            //capture left arrow key
            if (keyData == Keys.Left)
            {
                buttonStop.PerformClick();
                return true;
            }
            //capture right arrow key
            if (keyData == Keys.Right)
            {
                buttonGo.PerformClick();
                return true;
            }
            //capture Enter key
            if (keyData == Keys.Enter)
            {
                btnReset.PerformClick();
                return true;
            }


            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            picBackGround.Location = new Point(0, 80);
            picBike.Location = new Point(30, 185);
            lblGameOver.Visible = false;

            speed = 5;
            score = 0;
            txtScore.Text = score.ToString();
        }
    }
}
