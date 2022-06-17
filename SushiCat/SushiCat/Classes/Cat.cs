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
        public PictureBox CatImage = new PictureBox();
        private Timer timer = new Timer();
        public int xCoordinate = 0;
        public int yCoordinate = 0;
        public int currentDirection = 0;
        public int nextDirection = 0;

        public Cat()
        {
            timer.Interval = 100;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //moveCat(currentDirection);
        }
        public void SetImage(Form formInstance)
        {
            //place cat image on board
            CatImage.Image = Properties.Resources.R;
            currentDirection = 0;
            nextDirection = 0;
            xCoordinate = 320/40;
            yCoordinate = 360/40;
            CatImage.Location = new Point(320, 360);
            CatImage.Size = new Size(40, 40);
            formInstance.Controls.Add(CatImage);
            CatImage.Name = "CatImage";
            CatImage.SizeMode = PictureBoxSizeMode.StretchImage;
            CatImage.BackColor = Color.Transparent;
        }
        //----------added bs
        public void MoveCat(int direction)
        {
            // Move Cat

            if (checkDir(direction))
            {
                switch (direction)
                {
                    case 1: CatImage.Top -= 40; yCoordinate--; break;
                    case 2: CatImage.Left += 40; xCoordinate++; break;
                    case 3: CatImage.Top += 40; yCoordinate++; break;
                    case 4: CatImage.Left -= 40; xCoordinate--; break;
                }
            }
                currentDirection = direction;
                
                
        }

        private bool checkDir(int direction)
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

            if (Form1.maze.Matrix[y, x] == 0)
                return true;
            else
                return false;

        }
    }
   
}

