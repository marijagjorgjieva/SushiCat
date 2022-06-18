﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SushiCat
{

    public partial class GameScreen : Form
    {

        
        public static Maze maze = new Maze(1);
        public static Cat cat = new Cat();
        public static Sushi sushi = new Sushi();
        private Timer timer = new Timer();
        private bool canClick = true;
        //ova ne treba ovde ama fine!
        public static Player player = new Player();
        //kje se cuva vo sledna player class
        private int level = 1;
        Label gameInfo = new Label();
        public GameScreen()
        {

            InitializeComponent();
            
            //disable resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            //------------setup game (vo dr func da odiseto vova)
            maze.SetUpGame(level);
            sushi.CreateSushi(this);
            cat.SetImage(this);

            //timer
            timer.Interval = 220;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timert);

            DoubleBuffered = true;
           

            //-------adding--media
            wmp.URL = @"gg.mp3";
            wmp.settings.playCount = 9999; 
            wmp.Ctlcontrols.play();
            wmp.Visible = false;

            //----------vo dr klasa
            //logo  da odi vo dr klasa
            PictureBox logo = new PictureBox();
            logo.Image = Properties.Resources.logo;
            logo.Location = new Point(240, 360);
            logo.Size = new Size(320, 80);
            this.Controls.Add(logo);
            logo.SizeMode = PictureBoxSizeMode.CenterImage;
            logo.BackgroundImage = Properties.Resources.image;
            logo.BringToFront();
            //label da odi vo dr klasa
            
            gameInfo.Text = String.Format("Player:{0} Points:{1}", player.Name, player.Points);
            gameInfo.Location = new Point(6 * 40, 60);
            gameInfo.Font = new Font("November", 12, FontStyle.Regular);
            gameInfo.TextAlign = ContentAlignment.MiddleCenter;
            gameInfo.AutoSize = false;
            gameInfo.Width = 40 * 8;
            this.Controls.Add(gameInfo);
            gameInfo.BackColor = Color.Transparent;
            gameInfo.BringToFront();



        }

        private void timert(object sender, EventArgs e)
        {
            gameInfo.Text = String.Format("Player:{0} Points:{1}", player.Name, player.Points);
            canClick = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //todo method refresh game
            maze.Draw(e.Graphics);
            


        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (canClick)
            {
                base.OnKeyDown(e);
                switch (e.KeyCode)
                {
                    case Keys.Up: cat.nextDirection = 1; cat.MoveCat(1); break;
                    case Keys.Right: cat.nextDirection = 2; cat.MoveCat(2); break;
                    case Keys.Down: cat.nextDirection = 3; cat.MoveCat(3); break;
                    case Keys.Left: cat.nextDirection = 4; cat.MoveCat(4); break;

                }
                canClick = false;
            }
            gameInfo.Text = String.Format("Player:{0} Points:{1}", player.Name, player.Points);


        }


        private void GameScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
