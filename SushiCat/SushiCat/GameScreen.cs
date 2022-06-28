﻿using SushiCat.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace SushiCat
{

    public partial class GameScreen : Form
    { 
        //game elements
        public EvilBlob evilBlob;
        public Maze maze;
        public Cat cat;
        public Sushi sushi;
        public GameInfo gameInfo;
        public GameMenu menu;

        //used for drawing the maze
        private Graphics g;
        private Timer timer = new Timer();
        private bool loadedMaze = false;

        //win and game over forms
        private GameOverScreen gameOver;
        private WinnerScreen gameWin;
        public int newCat;
        public GameScreen(GameMenu menu)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.menu = menu;
            DoubleBuffered = true;
            newCat = menu.player.updatePlayed();

            //these are used for maze loading
            g = this.CreateGraphics();//od sega
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += new EventHandler(timerT);    
            
        }

        //used for maze loading
        private void timerT(object sender, EventArgs e)
        {
            if (!loadedMaze)
            {
                maze.SetUpMaze();
                loadedMaze = true;
            }
        }

        //setting up game elements
        public void SetupGame()
        {
            // creating game objects
            gameInfo = new GameInfo(this);
            evilBlob = new EvilBlob(this);
            maze = new Maze(g);
            cat = new Cat(this);
            sushi = new Sushi(this);
            
            //creating game elements
            sushi.CreateSushi();
            evilBlob.SetImage();
            cat.SetImage();
        }

        // key down event for cat control
        protected override void OnKeyDown(KeyEventArgs e)
        { 
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.Up:  cat.ChangeDirection(1); break;
                case Keys.Right:  cat.ChangeDirection(2); break;
                case Keys.Down:  cat.ChangeDirection(3); break;
                case Keys.Left:  cat.ChangeDirection(4); break;
            }
        }

        //game over form load
        public void GameOver()
        {
            gameOver =new GameOverScreen(this,menu);
            gameOver.Show();  
        }

        //win game form load
        public void WinGame()
        {
            if(newCat==0)
                newCat = menu.player.updateWinned();
            gameWin = new WinnerScreen(this,menu);
            gameWin.Show();
            StopGame();
        }

        private void GoBackClick(object sender, EventArgs e)
        {
            
            gameOver=new GameOverScreen(this,menu);
            gameOver.Show();
            StopGame();
           
        }
        public void StopGame()
        {
            goBack.Enabled = false;
            this.evilBlob.timer.Enabled = false;
            this.evilBlob.hometimer.Enabled = false;
            this.evilBlob.waittimer.Enabled = false;
            this.cat.timer.Enabled = false;
        }

    }
}
