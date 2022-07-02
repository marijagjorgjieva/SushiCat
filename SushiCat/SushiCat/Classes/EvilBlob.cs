using System;
using System.Drawing;
using System.Windows.Forms;

namespace SushiCat
{
    public class EvilBlob
    {
        public PictureBox BlobImage = new PictureBox();
        public Timer timer = new Timer();
        public Timer hometimer = new Timer();
        public Timer waittimer=new Timer();
        public int xCoordinate = 0;
        public int yCoordinate = 0;
        public int currentDirection = 0;
        private GameScreen gameScreen;

        public EvilBlob(GameScreen gameScreen)
        {
            timer.Interval = 350;
            timer.Enabled = true;
            timer.Tick += new EventHandler(MoveBlob);

            hometimer.Interval = 1;
            hometimer.Enabled = false;
            hometimer.Tick += new EventHandler(GoHome);

            waittimer.Interval = 3000;
            waittimer.Enabled = false;
            waittimer.Tick += new EventHandler(Wait);
            this.gameScreen = gameScreen;
            
        }

        private void Wait(object sender, EventArgs e)
        {          
            timer.Enabled = true;
            waittimer.Enabled= false;
        }
      
        private void GoHome(object sender, EventArgs e)
        {
            int newX = BlobImage.Location.X;
            int newY = BlobImage.Location.Y;

            if (newX > 360) { newX -= 5;}
            else if (newX < 360) newX += 5;

            if (newY > 480) { newY -= 5;}
            else if (newY < 480) newY += 5;

            BlobImage.Location=new Point(newX, newY);
            if (BlobImage.Location.Y == 480 && BlobImage.Location.X == 360)
            {
                xCoordinate = 360/40;
                yCoordinate = 480/40;
                hometimer.Enabled = false;
                waittimer.Enabled = true;
                gameScreen.cat.timer.Enabled = true;
                gameScreen.maze.SetUpMaze();

            }
        }

        public void SetImage()
        { 
            BlobImage.Image = Properties.Resources.EvilBlob;
            currentDirection = 1;
            xCoordinate = 360 / 40;
            yCoordinate = 480 / 40;
            BlobImage.Location = new Point(360, 480);
            BlobImage.Size = new Size(40, 40);
            gameScreen.Controls.Add(BlobImage);
            BlobImage.Name = "BlobImage";
            BlobImage.SizeMode = PictureBoxSizeMode.StretchImage;
            BlobImage.BackColor = Color.Transparent;
            BlobImage.BringToFront();
        }
       
       
        public void MoveBlobInDirection(int direction)
        { 
            if (CheckDirection(direction))
            {
                currentDirection = direction;
                switch (direction)
                { 
                    case 1: BlobImage.Top -= 40; yCoordinate--; break;
                    case 2: BlobImage.Left += 40; xCoordinate++; break;
                    case 3: BlobImage.Top += 40; yCoordinate++; break;
                    case 4: BlobImage.Left -= 40; xCoordinate--; break;
                }
            }
        }
        private void MoveBlob(object sender, EventArgs e)
        {
            UpdateDirection();
            MoveBlobInDirection(currentDirection);
            gameScreen.CheckForCollision();
        }

        private double GetDistance(int direction)
        {
            switch (direction)
            {
                case 1:
                    if (CheckDirection(1)){
                        return Euclid(xCoordinate, yCoordinate - 1, gameScreen.cat.xCoordinate, gameScreen.cat.yCoordinate);
                    }
                    break;
                case 2:
                    if (CheckDirection(2))
                    {
                        return Euclid(xCoordinate + 1, yCoordinate, gameScreen.cat.xCoordinate, gameScreen.cat.yCoordinate);
                    }
                    break;
                case 3:
                    if (CheckDirection(3))
                    {
                        return Euclid(xCoordinate, yCoordinate + 1, gameScreen.cat.xCoordinate, gameScreen.cat.yCoordinate);
                    }
                    break;
                case 4:
                    if (CheckDirection(4))
                    {
                        return Euclid(xCoordinate - 1, yCoordinate, gameScreen.cat.xCoordinate, gameScreen.cat.yCoordinate);
                    }
                    break;
            }
            return int.MaxValue;
        }

        public void UpdateDirection()
        {
            double distance1 = GetDistance(1);
            double distance2 = GetDistance(2);
            double distance3 = GetDistance(3);
            double distance4 = GetDistance(4);
            currentDirection = Compare(distance1, distance2, distance3, distance4);
        }

        private double Min(double x,double y)
        {
            if (x < y) return x;
            else return y;
        }
        private int Compare(double a, double b, double c, double d)
        {
            double smallest = Min(a, Min(b, Min(c, d)));
            if (smallest == a) return 1;
            if (smallest == b) return 2;
            if (smallest == c) return 3;
            if (smallest == d) return 4;
            return 0;
        }

        public double Euclid (int x,int y,int x1,int y1)
        {
            return Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2));
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
            if (x < 0 || y < 0 || x > 19 || y > 19)
                return false;
            if (gameScreen.maze.Matrix[y, x] !=1)
                return true;
            else
                return false;
        }   

    }


}
