using SushiCat.Properties;
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
    public partial class Customize : Form
    {
        private GameMenu menu;
        public int selected { set; get; }
        private bool grayUnlocked;
        private bool pinkUnlocked;
        private bool yellowUnlocked;
        public Customize(GameMenu menu)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.menu = menu;
            selected = (int)Settings.Default["CatIndex"];
            grayUnlocked = (bool)Settings.Default["GrayUnlocked"];
            pinkUnlocked = (bool)Settings.Default["PinkUnlocked"];
            yellowUnlocked = (bool)Settings.Default["YellowUnlocked"];
            UpdateColors();
            UpdateLabel(selected);
        }

        private void UpdateLabel(int index)
        {
            if (index == 1)
            {
                catInfo.Text = "Unlocked\nDefault Blacks Cat";
                catInfo.ForeColor = Color.Green;
            }
            if (index == 2)
            {
                if (grayUnlocked)
                {
                    catInfo.Text = "Unlocked\nGray Cat\nYou had your first win!";
                    catInfo.ForeColor = Color.Green;
                }
                else
                {
                    catInfo.Text = "Locked\nGray Cat\nHave your first win!";
                    catInfo.ForeColor = Color.Red;
                }
            }
            if (index == 3)
            {
                if (pinkUnlocked)
                {
                    catInfo.Text = "Unlocked\nPink Cat\nYou have played 10 times!";
                    catInfo.ForeColor = Color.Green;
                }
                else
                {
                    catInfo.Text = "Locked\nPink Cat\nPlay Sushi Cat 10 times!";
                    catInfo.ForeColor = Color.Red;
                }
            }
            if (index == 4)
            {
                if (yellowUnlocked)
                {
                    catInfo.Text = "Unlocked\nYellow Cat\nYou have won 5 times!";
                    catInfo.ForeColor = Color.Green;
                }
                else
                {
                    catInfo.Text = "Locked\nYellow Cat\nWin 5 times!";
                    catInfo.ForeColor = Color.Red;
                }
            }
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            if(tbChangeName.Text!=null && tbChangeName.Text.Length>0)
            {
                this.menu.player.playerName=tbChangeName.Text;
                Settings.Default["PlayerName"] = tbChangeName.Text;
                Settings.Default.Save();
                menu.UpdateLabel();
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.LightBlue;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.LightPink;
        }

        private void black_MouseEnter(object sender, EventArgs e)
        {
            black.BackColor = Color.LightSalmon;
        }

        private void black_MouseLeave(object sender, EventArgs e)
        {
            if(selected == 1 )
            {
                black.BackColor=Color.GreenYellow;
            }
            else
            {
                black.BackColor = Color.White;
            }
        }

        private void gray_MouseEnter(object sender, EventArgs e)
        {
            gray.BackColor = Color.LightSalmon;
        }

        private void gray_MouseLeave(object sender, EventArgs e)
        {
            if (selected == 2)
            {
                gray.BackColor = Color.GreenYellow;
            }
            else if (grayUnlocked)
            {
                gray.BackColor = Color.White;
            }
            else
            {
                gray.BackColor = Color.Black;
            }
        }

        private void pink_MouseEnter(object sender, EventArgs e)
        {
            pink.BackColor = Color.LightSalmon;
        }

        private void pink_MouseLeave(object sender, EventArgs e)
        {
            if (selected == 3)
            {
                pink.BackColor = Color.GreenYellow;
            }
            else if (pinkUnlocked)
            {
                pink.BackColor = Color.White;
            }
            else
            {
                pink.BackColor = Color.Black;
            }
        }

        private void yellow_MouseEnter(object sender, EventArgs e)
        {
            yellow.BackColor = Color.LightSalmon;
        }

        private void yellow_MouseLeave(object sender, EventArgs e)
        {
            if (selected == 4)
            {
                yellow.BackColor = Color.GreenYellow;
            }
            else if (yellowUnlocked)
            {
                yellow.BackColor = Color.White;
            }
            else
            {
                yellow.BackColor = Color.Black;
            }
        }
        private void black_Click(object sender, EventArgs e)
        {
            selected = 1;
            UpdateColors();
            UpdateLabel(1);
            
        }
        private void gray_Click(object sender, EventArgs e)
        {
            if(grayUnlocked)
                selected = 2;
            UpdateColors();
            UpdateLabel(2);
        }

        private void pink_Click(object sender, EventArgs e)
        {
            if(pinkUnlocked)
                selected = 3;
            UpdateColors();
            UpdateLabel(3);

        }

        private void yellow_Click(object sender, EventArgs e)
        {
            if (yellowUnlocked)
                selected = 4;
            UpdateColors();
            UpdateLabel(4);
        }

        private void btnChangeCat_Click(object sender, EventArgs e)
        {
            Settings.Default["CatIndex"] = selected;
            Settings.Default.Save();
        }
        private void UpdateColors()
        {
            black.BackColor = Color.White;
            if (grayUnlocked)
            {
                gray.BackColor = Color.White;
            }
            else
            {
                gray.BackColor = Color.Black;
            }
            if (pinkUnlocked)
            {
                pink.BackColor = Color.White;
            }
            else
            {
                pink.BackColor = Color.Black;
            }
            if (yellowUnlocked)
            {
                yellow.BackColor = Color.White;
            }
            else
            {
                yellow.BackColor = Color.Black;
            }
            switch (selected)
            {

                case 1: black.BackColor = Color.GreenYellow; break;
                case 2: gray.BackColor = Color.GreenYellow; break;
                case 3: pink.BackColor = Color.GreenYellow; break;
                case 4: yellow.BackColor = Color.GreenYellow; break;

            }
        }

        private void Customize_Click(object sender, EventArgs e)
        {
            UpdateLabel(selected);
        }
    }
}
