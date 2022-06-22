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
        private GameOverScreen gameOver;

        private int level = 1;
       
        public GameScreen()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            DoubleBuffered = true;

            SetupGame();
                
        }

        private void SetupGame()
        {
            //initializing components
            gameInfo = new GameInfo(this);
            evilBlob = new EvilBlob(this);
            maze = new Maze(1);
            cat = new Cat(this);
            sushi = new Sushi(this);

          

            //setup game
            maze.SetUpGame(level);
            sushi.CreateSushi();
           
            evilBlob.SetImage();
            cat.SetImage();
        }
        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            maze.Draw(e.Graphics);
        }

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


        private void GameScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void GameOver()
        {
            gameOver=new GameOverScreen();
            gameOver.Show();
        }
    }
}
