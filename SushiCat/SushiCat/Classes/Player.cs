using SushiCat.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiCat.Classes
{ 
    public class Player
    {
        
        public String playerName { get; set; }
        public int highscore { get; set; }
        public Image right { get; set; }
        public Image left { get; set; }
        public Image up { get; set; }
        public Image down { get; set; }
        public int playedGames {get; set;}
        public int winnedGames { get; set; }
        public Player()
        {
            playerName = (string)Settings.Default["PlayerName"];
            highscore = (int)Settings.Default["MaxScore"];
            playedGames = (int)Settings.Default["PlayedGames"];
            winnedGames = (int)Settings.Default["WinnedGames"];
            ChangeImages();
        }

        public void ChangeImages()
        {
            int index= (int)Settings.Default["CatIndex"];
            switch (index)
            {

                case 1:
                    right = Properties.Resources.Right;
                    left=Properties.Resources.Left;
                    up=Properties.Resources.Up; 
                    down=Properties.Resources.Down;
                    break;
                case 2:
                    right = Properties.Resources.GrayRight;
                    left = Properties.Resources.GrayLeft;
                    up = Properties.Resources.GrayUp;
                    down = Properties.Resources.GrayDown; 
                    break;
                case 3:
                    right = Properties.Resources.PinkRight;
                    left = Properties.Resources.PinkLeft;
                    up = Properties.Resources.PinkUp;
                    down = Properties.Resources.PinkDown;
                    break;
                case 4:
                    right = Properties.Resources.YellowRight;
                    left = Properties.Resources.YellowLeft;
                    up = Properties.Resources.YellowUp;
                    down = Properties.Resources.YellowDown;
                    break;

            }
        }

        public void UpdateHighscore(int score)
        {
            if(IsHighscore(score))
                highscore = score;
            Settings.Default["MaxScore"]=highscore;
            Settings.Default.Save();

        }

        public bool IsHighscore(int score)
        {
            if (highscore < score)
                return true;
            else return false;
        }
        public int UpdatePlayed()
        {
            bool pink = (bool)Settings.Default["PinkUnlocked"];
            playedGames++;
            Settings.Default["PlayedGames"] = playedGames;
            Settings.Default.Save();
            if (!pink && playedGames == 10)
            {
                Settings.Default["PinkUnlocked"] = true;
                Settings.Default.Save();
                return 1;
            }
           return 0;
        }
        public int UpdateWinned()
        {
            bool gray =(bool) Settings.Default["GrayUnlocked"];
            bool yellow = (bool)Settings.Default["YellowUnlocked"];
            winnedGames++;
            Settings.Default["WinnedGames"] = winnedGames;
            Settings.Default.Save();
            if (!gray&&winnedGames==1)
            {
                Settings.Default["GrayUnlocked"] = true;
                Settings.Default.Save();
                return 1;
            }
            if (!yellow && winnedGames == 5)
            {
                Settings.Default["YellowUnlocked"] = true;
                Settings.Default.Save();
                return 1;
            }
            return 0;
            
        }
    }
}
