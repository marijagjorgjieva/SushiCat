﻿using System;
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
        public String Name { get; set; } = "No name!";
        public int Points = 0;
        private GameScreen formInstance;
        Label gameInfo;
        public int lives = -1;
        private List<PictureBox> livesImages;
        private static SoundPlayer  sound = new SoundPlayer(Properties.Resources.bumpp);
        private static SoundPlayer gameOver = new SoundPlayer(Properties.Resources.game_over);
        public GameInfo(GameScreen screen)
        {
            gameInfo = new Label();
            this.formInstance = screen;
            MakeLabel();
            MakeLogo();
            MakeLives();
        }

        private void MakeLives()
        {
            livesImages= new List<PictureBox>();
            livesImages.Add(new PictureBox());
            livesImages.Add(new PictureBox());
            livesImages.Add(new PictureBox());
            int xPos = 800-30*3;
            for(int i = 0;i < 3;i++)
            {
                livesImages[i].Image = Properties.Resources.fullHeart;
                livesImages[i].Location = new Point(xPos,2);
                livesImages[i].Size = new Size(30, 30);
                formInstance.Controls.Add(livesImages[i]);
                livesImages[i].SizeMode = PictureBoxSizeMode.StretchImage;
                livesImages[i].BackgroundImage = Properties.Resources.image;
                livesImages[i].BringToFront();
                xPos += 30;
            }
        }
        private void MakeLogo()
        {
            //----------vo dr klasa
            //logo  da odi vo dr klasa
            PictureBox logo = new PictureBox();
            logo.Image = Properties.Resources.logo;
            logo.Location = new Point(240, 360);
            logo.Size = new Size(320, 80);
            formInstance.Controls.Add(logo);
            logo.SizeMode = PictureBoxSizeMode.CenterImage;
            logo.BackgroundImage = Properties.Resources.image;
            logo.BringToFront();
            

        }
        private void MakeLabel()
        {
            gameInfo.Text = String.Format("Player:{0}   Points:{1}", Name, Points);
            gameInfo.Location = new Point(0, 2);
            gameInfo.Font = new Font("Arial", 12, FontStyle.Bold);
            gameInfo.TextAlign = ContentAlignment.MiddleCenter;
            gameInfo.AutoSize = false;
            gameInfo.Width = 40 * 6;
            gameInfo.Height = 28;
            formInstance.Controls.Add(gameInfo);
            gameInfo.BackColor = ColorTranslator.FromHtml("#F9B9BA");
            gameInfo.BorderStyle = BorderStyle.Fixed3D;
            gameInfo.BringToFront();
        }
        public void UpdateLabel()
        {
            gameInfo.Text = String.Format("Player:{0}   Points:{1}", formInstance.gameInfo.Name, formInstance.gameInfo.Points);
            //ako e maks!
        }

        public void RemoveLives()
        {
            
            if (lives == 2)
            {
                livesImages[lives].Image = Properties.Resources.blankHeart;
                gameOver.Play();
                formInstance.GameOver();
               
            }
            else
            {
                sound.Play();
                livesImages[lives].Image = Properties.Resources.blankHeart;
            }
            
        }
    }
}
