﻿using System;
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
    public partial class GameOverScreen : Form
    {
        private GameScreen form;
        public GameOverScreen(GameScreen form)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.form = form;
            int points = form.gameInfo.Points;
            lblScore.Text = String.Format("Score: {0}", points.ToString());
            if (form.menu.player.isHighScore(points))
            {
                lblNewH.Text = "New Highscore!";
                form.menu.player.updateHighScore(points);
            }
            else
            {
                lblNewH.Text = "Good job!";
            }
            form.menu.UpdateLabel();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            form.menu.Show();//otvori nova forma N ili odnovo cela app 
            form.Hide();
            this.Close();
        }
    }
}
