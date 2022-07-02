using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SushiCat.Forms
{
    public partial class HelpScreen : Form
    {
        private GameMenu menu;
        public HelpScreen(GameMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
            menu.DisableMenu();
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.LightBlue;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.LightPink;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.EnableMenu();
        }
    }
}
