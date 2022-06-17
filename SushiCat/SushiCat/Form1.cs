using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SushiCat
{

    public partial class Form1 : Form
    {
        public static Maze maze = new Maze(1);
        public static Cat cat = new Cat();
        //kje se cuva vo sledna player class
        private int level = 1;
        public Form1()
        {

            InitializeComponent();
            //to do maze . create maze
            cat.SetImage(this);
            maze.SetUpGame(level);
            Invalidate();
            DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //todo method refresh game
            maze.Draw(e.Graphics);
        }
        //----------------added bs
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            switch (e.KeyCode)
            {
                case Keys.Up: cat.nextDirection = 1; cat.MoveCat(1); break;
                case Keys.Right: cat.nextDirection = 2; cat.MoveCat(2); break;
                case Keys.Down: cat.nextDirection = 3; cat.MoveCat(3); break;
                case Keys.Left: cat.nextDirection = 4; cat.MoveCat(4); break;

            }
            Invalidate();
        }
    }
}
