using SushiCat.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiCat.Classes
{
    public class Player
    {
        public String PlayerName { get; set; }
        public int highscore { get; set; }

        public Player()
        {
            PlayerName = (string)Settings.Default["PlayerName"];
            highscore = (int)Settings.Default["MaxScore"];
        }
        
        public void updateHighScore(int score)
        {
            if(isHighScore(score))
                highscore = score;
            Settings.Default["MaxScore"]=highscore;
            Settings.Default.Save();

        }

        public bool isHighScore(int score)
        {
            if (highscore < score)
                return true;
            else return false;
        }
    }
}
