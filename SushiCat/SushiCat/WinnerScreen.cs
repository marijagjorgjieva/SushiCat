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
        public WinnerScreen(GameScreen form)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.form = form;
            int points = form.gameInfo.Points;
            lblScore.Text = String.Format("Score: {0}", points.ToString());
            form.menu.player.updateHighScore(points);
            form.menu.UpdateLabel();
            //zacuvaj progres
        }
    }
}
