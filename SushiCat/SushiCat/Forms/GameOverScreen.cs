using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SushiCat
{
    public partial class GameOverScreen : Form
    {
        private GameScreen form;
        private GameMenu menu;
        private static SoundPlayer sound = new SoundPlayer(Properties.Resources.GameOver);
        public GameOverScreen(GameScreen form, GameMenu menu)
        {
            InitializeComponent();
            sound.Play();
            this.FormBorderStyle = FormBorderStyle.None;
            this.menu = menu;
            this.form = form;
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            int points = form.gameInfo.Points;
            lblScore.Text = String.Format("Score: {0}", points.ToString());
            if (form.menu.player.isHighScore(points))
            {
                form.menu.player.updateHighScore(points);
                if (form.newCat!=0)
                {
                    lblNewH.Text = "New Highscore!\nNew cat unlocked!";
                }
                else
                {
                    lblNewH.Text = "New Highscore!";
                }
            }
            else
            {
                if (form.newCat != 0)
                {
                    lblNewH.Text = "Good job!\nNew cat unlocked!";
                }
                else
                { 
                    lblNewH.Text = "Good job!";
                }
            }
            form.menu.UpdateLabel();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menu.ShowAgain();
            form.Close();
            this.Close();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            menu.ShowAgain();
            form.Close();
            this.Close();
            menu.createGame();
        }
    }
}
