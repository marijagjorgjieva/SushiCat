using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace SushiCat
{
    public class Sushi
    {
        public PictureBox[,] sushi = new PictureBox[20, 20];
        private static SoundPlayer Player = new SoundPlayer(Properties.Resources.coin2);
        private int CollectedSushi = 0;
        private GameScreen formInstance;
        public Sushi(GameScreen formInstance)
        {
            Player.Load();
            this.formInstance = formInstance;
        }

        public void CreateSushi()
        {
            int startX = 0;
            int startY = 0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (formInstance.maze.Matrix[i, j] == 0)
                    {
                       sushi[i,j]=new PictureBox();
                       sushi[i,j].Image = Properties.Resources.sushi;
                       sushi[i, j].Size = new Size(40, 40);
                       sushi[i, j].SizeMode = PictureBoxSizeMode.CenterImage;
                       sushi[i, j].Location = new Point(startX, startY);
                       sushi[i, j].BackColor = Color.Transparent;
                       formInstance.Controls.Add(sushi[i, j]);
                       sushi[i, j].BringToFront();
                    }
                    startX += 40;
                }
                startX = 0;
                startY += 40;
            }
        }


        public void EatFood(int x, int y)
        {
            if (formInstance.maze.Matrix[y, x] == 0)
            { 
                    Player.Play();
                    sushi[y, x].Visible = false;
                    sushi[y, x] = null;
                    formInstance.maze.Matrix[y, x] = 3;
                    CollectedSushi += 1;
                    formInstance.gameInfo.Points = CollectedSushi;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }

        
    }
}
