using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SushiCat
{
    public class EvilBlob
    {
        public PictureBox BlobImage = new PictureBox();
        private Timer timer = new Timer();
        public int xCoordinate = 0;
        public int yCoordinate = 0;
        public int currentDirection = 0;
        private GameScreen formInstance;

        public EvilBlob(GameScreen formInstance)
        {
            timer.Interval = 270;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timert);
            this.formInstance = formInstance;
        }

        public void SetImage()
        {
            //place cat image on board
            BlobImage.Image = Properties.Resources.evilBlob;
            currentDirection = 1;
            xCoordinate = 360 / 40;
            yCoordinate = 480 / 40;
            BlobImage.Location = new Point(360, 480);
            BlobImage.Size = new Size(40, 40);
            formInstance.Controls.Add(BlobImage);
            BlobImage.Name = "BlobImage";
            BlobImage.SizeMode = PictureBoxSizeMode.StretchImage;
            BlobImage.BackColor = Color.Transparent;
            BlobImage.BringToFront();
        }
       
       
        public void MoveBlob(int direction)
        {

            if (checkDir(direction))
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
        private void timert(object sender, EventArgs e)
        {
            UpdateDirection();
            MoveBlob(currentDirection);
        }
        public void UpdateDirection()
        {
            int x = xCoordinate;
            int y = yCoordinate;
            double distance1, distance2, distance3, distance4 = 0;
            if (checkDir(1))
            {
                distance1 = euclid(x, y-1, formInstance.cat.xCoordinate, formInstance.cat.yCoordinate);
            }
            else
            {
                distance1 = 300000;
            }
            if (checkDir(2))
            {
                distance2 = euclid(x+1, y , formInstance.cat.xCoordinate, formInstance.cat.yCoordinate);
            }
            else
            {
                distance2 = 300000;
            }
            if (checkDir(3))
            {
                distance3 = euclid(x, y+1, formInstance.cat.xCoordinate, formInstance.cat.yCoordinate);
            }
            else
            {
                distance3 = 300000;
            }
            if (checkDir(4))
            {
                distance4 = euclid(x-1, y, formInstance.cat.xCoordinate, formInstance.cat.yCoordinate);
            }
            else
            {
                distance4 = 300000;
            }
            currentDirection = compare(distance1, distance2, distance3, distance4);
        }

        private int compare(double a, double b, double c, double d)
        {
            if (a <= b)
            {
                if (c <= d)
                {
                    if (c <= a)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    if (d <= a)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }

            else
            {
                if (c <= d)
                {
                    if (c <= b)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
                else
                {
                    if (d <= b)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        public double euclid (int x,int y,int x1,int y1)
        {
            double a = x - x1;
            double b = y- y1;
            a = Math.Pow(a, 2);
            b = Math.Pow(b, 2);
            double full = a + b;
            return Math.Sqrt(full);
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

            if (x < 0 || y < 0 || x > 19 || y > 19)
                return false;

            if (formInstance.maze.Matrix[y, x] !=1)
                return true;
            else
                return false;

        }
       
    }


}
