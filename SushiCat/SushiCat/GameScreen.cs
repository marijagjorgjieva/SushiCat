using System;
using System.Drawing;
using System.Windows.Forms;


namespace SushiCat
{

    public partial class GameScreen : Form
    { 
        public EvilBlob evilBlob;
        public Maze maze;
        public Cat cat;
        public Sushi sushi;
        public GameInfo gameInfo;
        //od sega
        private Graphics g;
        private bool loadedMaze = false;
        private GameOverScreen gameOver;

        public GameScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            DoubleBuffered = true;
            g = this.CreateGraphics();//od sega
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
            maze.SetUpMaze();
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
       
        // form closed event
        private void GameScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //game over event
        public void GameOver()
        {
            gameOver=new GameOverScreen();
            gameOver.Show();
        }

        //loading of maze sega dodadeno
        private void GameScreen_MouseHover(object sender, EventArgs e)
        {
            if (!loadedMaze)
            {
                maze.SetUpMaze();
                loadedMaze = true;
            }
        }

      /*  private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //maze.SetUpMaze();
            *//* if (!loadedMaze)
             {
                 maze.SetUpMaze();
                 loadedMaze = true;
             }*//*
            maze.SetUpMaze();
        }*/
    }
}
