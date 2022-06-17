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
        private SoundPlayer Player = new SoundPlayer(Properties.Resources.startMusic1);
        private GameScreen gameScreen;
        public GameMenu()
        {
            InitializeComponent();
            //disable resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Player.PlayLooping();  
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Player.Stop();
            gameScreen = new GameScreen();
            gameScreen.Show();
            this.Hide();
        }
    }
}
