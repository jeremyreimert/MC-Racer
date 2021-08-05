using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDEV_360_Motorcycle_Game
{
    public static class Collision
    {
        public static bool Crashed(PictureBoxEx obstacle, PictureBoxEx rider)
        {
            
          
            int obstacleLeft = obstacle.Location.X + 15;
            int obstacleRight = obstacle.Location.X + obstacle.Width - 15;


          
            int riderRight = rider.Location.X + rider.Width - 20;
            int riderLeft = rider.Location.X;

            if (riderRight > obstacleLeft && riderLeft < obstacleRight && rider.Location.Y == obstacle.Location.Y - 90)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
