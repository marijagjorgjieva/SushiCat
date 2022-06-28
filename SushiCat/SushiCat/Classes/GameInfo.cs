using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SushiCat
{
    public class GameInfo
    {
       
        public int Points { set; get; } = 0;
        private GameScreen formInstance;
        Label gameInfo;
        public int lives { set; get; } = -1;
        private List<PictureBox> livesImages;
        private static SoundPlayer sound = new SoundPlayer(Properties.Resources.GhostEncounter);
        public GameInfo(GameScreen screen)
        {
            gameInfo = new Label();
            this.formInstance = screen;
            MakeLabel();
            MakeLogo();
            MakeLives();        
        }

        //create the hearts images
        private void MakeLives()
        {
            livesImages = new List<PictureBox>();
            livesImages.Add(new PictureBox());
            livesImages.Add(new PictureBox());
            livesImages.Add(new PictureBox());
            int xPos = 800 - 30 * 3;
            for (int i = 0; i < 3; i++)
            {
                livesImages[i].Image = Properties.Resources.FullHeart;
                livesImages[i].Location = new Point(xPos, 2);
                livesImages[i].Size = new Size(30, 30);
                formInstance.Controls.Add(livesImages[i]);
                livesImages[i].SizeMode = PictureBoxSizeMode.StretchImage;
                livesImages[i].BackgroundImage = Properties.Resources.BrickTile;
                livesImages[i].BringToFront();
                xPos += 30;
            }
        }

        //placing the logo in the center of the maze
        private void MakeLogo()
        {
            PictureBox logo = new PictureBox();
            logo.Image = Properties.Resources.Logo;
            logo.Location = new Point(240, 360);
            logo.Size = new Size(320, 80);
            formInstance.Controls.Add(logo);
            logo.SizeMode = PictureBoxSizeMode.CenterImage;
            logo.BackgroundImage = Properties.Resources.BrickTile;
            logo.BringToFront();
        }

        //creating game info label
        private void MakeLabel()
        {
            gameInfo.Text = String.Format("Player:{0}   Points:{1}", formInstance.menu.player.playerName, Points);
            gameInfo.Location = new Point(0, 2);
            gameInfo.Font = new Font("Bahnschrift", 12, FontStyle.Bold);
            gameInfo.TextAlign = ContentAlignment.MiddleCenter;
            gameInfo.AutoSize = false;
            gameInfo.Width = 40 * 6;
            gameInfo.Height = 28;
            formInstance.Controls.Add(gameInfo);
            gameInfo.BackColor = ColorTranslator.FromHtml("#F9B9BA");
            gameInfo.ForeColor = Color.White;
            gameInfo.BorderStyle = BorderStyle.Fixed3D;
            gameInfo.BringToFront();
        }

        //updating label with the new info
        public void UpdateLabel()
        {
            gameInfo.Text = String.Format("Player: {0}   Points: {1}", formInstance.menu.player.playerName, formInstance.gameInfo.Points);
        }

        //check if any lives left, replace full heart with blank for a life lost
        public void LivesCheck()
        {
            
            if (lives == 2)
            {
                formInstance.GameOver();
            }
            else
            {
                sound.Play();
            }
            livesImages[lives].Image = Properties.Resources.BlankHeart;

        }
    }
}
