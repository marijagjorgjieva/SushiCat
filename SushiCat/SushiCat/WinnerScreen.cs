using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SushiCat
{
    public partial class WinnerScreen : Form
    {
        private GameScreen form;
        private GameMenu menu;
        public WinnerScreen(GameScreen form,GameMenu menu)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
          
            this.menu = menu;
            this.form = form;
            int points = form.gameInfo.Points;
            lblScore.Text = String.Format("Score: {0}", points.ToString());
            form.menu.player.updateHighScore(points);
            form.menu.UpdateLabel();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            menu.ShowAgain();
            form.Close();
            this.Close();
        }
    }
}
