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
    public partial class Form1 : Form
    {
        private Maze maze;
        public Form1()
        {
            InitializeComponent();
            maze = new Maze(1);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            maze.Draw(e.Graphics);
        }
    }
}
