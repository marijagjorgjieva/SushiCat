using SushiCat.Classes;
using SushiCat.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SushiCat
{
    public partial class GameMenu : Form
    {
        public Player player;
        private SoundPlayer sound = new SoundPlayer(Properties.Resources.Start);
        private GameScreen gameScreen;
        private Customize customize;
        private HelpScreen helpScreen;
        public GameMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            sound.PlayLooping();
            player = new Player();
            UpdateLabel();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            createGame();            
        }
        public void createGame()
        {
            sound.Stop();
            gameScreen = new GameScreen(this);
            gameScreen.Show();
            this.Hide();
            gameScreen.SetupGame();
        }
        public void UpdateLabel()
        {
            label.Text = String.Format("Player: {0}\nHighscore: {1}\nPlayed games: {2}\nWinned games: {3}",player.playerName,player.highscore,player.playedGames,player.winnedGames);
        }

        internal void ShowAgain()
        {
            this.Show();
            sound.PlayLooping();
        }

        private void btnCustomize(object sender, EventArgs e)
        {
            customize = new Customize(this);
            customize.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void DisableMenu()
        {
            btnExit.Enabled = false;
            btnPlay.Enabled = false;
            btnPlayer.Enabled = false;
        }
        public void EnableMenu()
        {
            btnExit.Enabled = true;
            btnPlay.Enabled = true;
            btnPlayer.Enabled = true;
        }

        private void lblHelp_MouseEnter(object sender, EventArgs e)
        {
            lblHelp.BackColor = Color.LightBlue;
        }

        private void lblHelp_MouseLeave(object sender, EventArgs e)
        {
            lblHelp.BackColor = Color.LightPink;
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            helpScreen = new HelpScreen(this);
            helpScreen.Show();
        }
    }
}
