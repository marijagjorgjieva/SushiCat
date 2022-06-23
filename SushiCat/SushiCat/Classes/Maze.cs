using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SushiCat
{
    public class Maze
    {
        private static Image myImage = Properties.Resources.image;
        private static TextureBrush brush = new TextureBrush(myImage);
        private Graphics g;
        private List<Rectangle> Obstacles { get; set; }
        public int[,] Matrix = new int[20, 20];
       
        public Maze(Graphics g)
        {
            Matrix = new int[,] {
                { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
                { 1,1,1,0,1,0,1,1,1,1,0,0,1,1,0,1,0,1,1,1 },
                { 1,1,0,0,0,0,0,1,0,1,1,0,1,0,0,0,0,0,1,1 },
                { 1,0,0,1,1,1,0,1,0,0,1,0,1,0,1,1,1,0,0,1 },
                { 1,0,0,1,0,0,0,1,0,0,0,0,1,0,1,0,1,0,0,1 },
                { 1,1,0,1,0,1,0,0,0,1,1,0,0,0,1,0,1,0,1,1 },
                { 1,0,0,0,0,1,0,0,1,1,1,1,0,0,0,0,0,0,0,1 },
                { 1,0,0,0,0,0,0,1,1,3,0,1,1,0,0,1,0,0,0,1 },
                { 1,1,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,1 },
                { 1,0,0,1,1,0,1,1,1,1,1,1,1,1,0,1,1,0,0,1 },
                { 1,0,0,1,1,0,1,1,1,1,1,1,1,1,0,1,1,0,0,1 },
                { 1,1,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,1 },
                { 1,0,0,0,0,0,0,1,1,0,0,1,1,0,0,1,0,0,0,1 },
                { 1,0,0,0,0,1,0,0,1,1,1,1,0,0,0,0,0,0,0,1 },
                { 1,1,0,1,0,1,0,0,0,1,1,0,0,0,1,0,1,0,1,1 },
                { 1,0,0,1,0,0,0,1,0,0,0,0,1,0,1,0,1,0,0,1 },
                { 1,0,0,1,1,1,0,1,0,0,1,0,1,0,1,1,1,0,0,1 },
                { 1,1,0,0,0,0,0,1,0,1,1,0,1,0,0,0,0,0,1,1 },
                { 1,1,1,0,1,0,1,1,1,1,0,0,1,1,0,1,0,1,1,1 },
                { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
            };
            Obstacles = new List<Rectangle>();
            this.g = g;
        }
        
        public void SetUpMaze()
        {
            brush.WrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
            int startX = 0;
            int startY = 0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (Matrix[i, j] == 1)
                    {
                        Rectangle rectangle = new Rectangle(startX, startY, 40, 40);
                        Obstacles.Add(rectangle);
                    }
                    startX += 40;
                }
                startX = 0;
                startY += 40;
            }
            g.FillRectangles(brush, Obstacles.ToArray());

          ////  brush.Dispose();
        }

       

    }
}
