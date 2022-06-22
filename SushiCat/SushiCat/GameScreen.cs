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
        private Timer timer = new Timer();
        //ova ne treba ovde ama fine!
        public Player player;
        //kje se cuva vo sledna player class
        private int level = 1;
        Label gameInfo = new Label();
        public GameScreen()
        {

            InitializeComponent();
             evilBlob = new EvilBlob(this);
             maze = new Maze(1);
             cat = new Cat(this);
             sushi = new Sushi(this);
            player = new Player();
            //disable resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            //------------setup game (vo dr func da odiseto vova)
            maze.SetUpGame(level);
            sushi.CreateSushi();
            cat.SetImage();
            evilBlob.SetImage();
           
            //timer
            timer.Interval = 150;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timert);

            DoubleBuffered = true;
           

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
            
            gameInfo.Text = String.Format("Player:{0}   Points:{1}", player.Name, player.Points);
            gameInfo.Location = new Point(7 * 40, 40);
            gameInfo.Font = new Font("Arial", 12, FontStyle.Bold);
            gameInfo.TextAlign = ContentAlignment.MiddleCenter;
            gameInfo.AutoSize = false;
            gameInfo.Width = 40 * 6;
            this.Controls.Add(gameInfo);
            gameInfo.BackColor = ColorTranslator.FromHtml("#F9B9BA");
            gameInfo.BorderStyle = BorderStyle.Fixed3D;
            gameInfo.BringToFront();



        }

        private void timert(object sender, EventArgs e)
        {
            gameInfo.Text = String.Format("Player:{0} Points:{1}", player.Name, player.Points);
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //todo method refresh game
            maze.Draw(e.Graphics);
            


        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            
                base.OnKeyDown(e);
                switch (e.KeyCode)
                {
                    case Keys.Up:  cat.changeDirection(1); break;
                    case Keys.Right:  cat.changeDirection(2); break;
                    case Keys.Down:  cat.changeDirection(3); break;
                    case Keys.Left:  cat.changeDirection(4); break;

                }
           
            gameInfo.Text = String.Format("Player:{0} Points:{1}", player.Name, player.Points);


        }


        private void GameScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
