using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace SushiCat
{
    public class Sushi
    {
        private GameScreen gameScreen;
        private PictureBox[,] sushi = new PictureBox[20, 20];
        private static SoundPlayer Player = new SoundPlayer(Properties.Resources.Coin);
        private int CollectedSushi = 0;
        private int maxSushiCounter = 0;
        public Sushi(GameScreen gameScreen)
        {
            Player.Load();
            this.gameScreen = gameScreen;
        }

        public void CreateSushi()
        {
            int startX = 0;
            int startY = 0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (gameScreen.maze.Matrix[i, j] == 0)
                    {
                       sushi[i,j]=new PictureBox();
                       sushi[i,j].Image = Properties.Resources.Sushi;
                       sushi[i, j].Size = new Size(40, 40);
                       sushi[i, j].SizeMode = PictureBoxSizeMode.CenterImage;
                       sushi[i, j].Location = new Point(startX, startY);
                       sushi[i, j].BackColor = Color.Transparent;
                       gameScreen.Controls.Add(sushi[i, j]);
                       sushi[i, j].BringToFront();
                       maxSushiCounter++;
                    }
                    startX += 40;
                }
                startX = 0;
                startY += 40;
            }
        }


        public void EatFood(int x, int y)
        {
            if (gameScreen.maze.Matrix[y, x] == 0)
            { 
                    Player.Play();
                    sushi[y, x].Visible = false;
                    sushi[y, x] = null;
                    gameScreen.maze.Matrix[y, x] = 3;
                    CollectedSushi += 1;
                    gameScreen.gameInfo.Points = CollectedSushi;
            }
         
            if(CollectedSushi==maxSushiCounter)
            {
                gameScreen.WinGame();
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        
    }
}
