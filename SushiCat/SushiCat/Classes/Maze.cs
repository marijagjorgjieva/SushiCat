﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiCat
{
    public class Maze
    {
        private List<Rectangle> Obstacles { get; set; }
        public int[,] Matrix = new int[20, 20];

        public Maze(int level)
        {
            Obstacles = new List<Rectangle>();
            switch (level)
            {
                case 1:
                    Matrix = new int[,] {
                      { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
                      { 1,1,1,0,1,0,1,1,1,1,1,1,1,1,0,1,0,1,1,1 },
                      { 1,1,0,0,0,0,0,1,0,1,1,0,1,0,0,0,0,0,1,1 },
                      { 1,0,0,1,1,1,0,1,0,0,1,0,1,0,1,1,1,0,0,1 },
                      { 1,0,0,1,0,0,0,1,0,0,0,0,1,0,1,0,1,0,0,1 },
                      { 1,1,0,1,0,1,0,0,0,1,1,0,0,0,1,0,1,0,1,1 },
                      { 1,0,0,0,0,1,0,0,0,1,1,0,0,0,0,0,0,0,0,1 },
                      { 1,0,0,0,0,0,0,1,1,1,1,1,1,0,0,1,0,0,0,1 },
                      { 1,1,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,1 },
                      { 0,0,0,1,1,0,1,1,0,1,1,1,1,1,0,1,1,0,0,0 },
                      { 0,0,0,1,1,0,1,1,1,1,1,0,1,1,0,1,1,0,0,0 },
                      { 1,1,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,1 },
                      { 1,0,0,0,0,0,0,1,1,1,1,1,1,0,0,1,0,0,0,1 },
                      { 1,0,0,0,0,1,0,0,0,1,1,0,0,0,0,0,0,0,0,1 },
                      { 1,1,0,1,0,1,0,0,0,1,1,0,0,0,1,0,1,0,1,1 },
                      { 1,0,0,1,0,0,0,1,0,0,0,0,1,0,1,0,1,0,0,1 },
                      { 1,0,0,1,1,1,0,1,0,0,1,0,1,0,1,1,1,0,0,1 },
                      { 1,1,0,0,0,0,0,1,0,1,1,0,1,0,0,0,0,0,1,1 },
                      { 1,1,1,0,1,0,1,1,1,1,1,1,1,1,0,1,0,1,1,1 },
                      { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
                    };
                    break;
            }

        }
        //todo method set up game
        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.MediumPurple);
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
        }

        //public bool clashes()

    }
}