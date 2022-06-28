using SushiCat.Classes;
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
    public partial class GameMenu : Form
    {
        public Player player;
        private SoundPlayer sound = new SoundPlayer(Properties.Resources.startMusic1);
        private GameScreen gameScreen;
        private Customize customize;
        public GameMenu()
        {
            InitializeComponent();
            //disable resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
            player.ChangeImages();
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
    }
}
