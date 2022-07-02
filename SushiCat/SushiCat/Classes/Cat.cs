using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SushiCat
{
    public class Cat
    {
        private PictureBox CatImage = new PictureBox();
        public Timer timer = new Timer();
        public int xCoordinate { set; get; } = 0;
        public int yCoordinate { set; get; } = 0;
        public int currentDirection { set; get; } = 0;
        private GameScreen gameScreen;
        public Cat(GameScreen gameScreen)
        {
            timer.Interval = 100;
            timer.Enabled = true;
            timer.Tick += new EventHandler(TimerTick);
            this.gameScreen = gameScreen;
        }

        public void SetImage()
        {
            CatImage.Image = gameScreen.menu.player.right;
            currentDirection = 0;
            xCoordinate = 360/40;
            yCoordinate = 280/40;
            CatImage.Location = new Point(360, 280);
            CatImage.Size = new Size(40, 40);
            gameScreen.Controls.Add(CatImage);
            CatImage.Name = "CatImage";
            CatImage.SizeMode = PictureBoxSizeMode.StretchImage;
            CatImage.BackColor = Color.Transparent;
        }
       
        public void ChangeDirection(int direction)
        {
            currentDirection = direction;
        }
        private void MoveCat(int direction)
        {
  
            if (CheckDirection(direction))
            {
                currentDirection = direction;
                ChangeImage();
                switch (direction)
                {
                    
                    case 1: CatImage.Top -= 40; yCoordinate--; break;
                    case 2: CatImage.Left += 40; xCoordinate++; break;
                    case 3: CatImage.Top += 40; yCoordinate++; break;
                    case 4: CatImage.Left -= 40; xCoordinate--; break;
                    
                }
                gameScreen.sushi.EatFood(xCoordinate, yCoordinate);
                gameScreen.gameInfo.UpdateLabel();
            }     
        }

        private void TimerTick(object sender, EventArgs e)
        {
            MoveCat(currentDirection);
            gameScreen.CheckForCollision();
        }
        
        private bool CheckDirection(int direction)
        {
            int x = xCoordinate;
            int y = yCoordinate;
            switch (direction)
            {
                case 1: y--; break;
                case 2: x++; break;
                case 3: y++; break;
                case 4: x--; break;
            }

            if(x<0 || y < 0 || x>19 || y>19)
                return false;

            if (gameScreen.maze.Matrix[y, x] != 1)
                return true;
            else
                return false;

        }
        private void ChangeImage()
        {
            switch (currentDirection)
            {
                case 1: CatImage.Image = gameScreen.menu.player.up; break;
                case 2: CatImage.Image = gameScreen.menu.player.right; break;
                case 3: CatImage.Image = gameScreen.menu.player.down; break;
                case 4: CatImage.Image = gameScreen.menu.player.left; break;
            }
        }
       
    }
   
   
}

