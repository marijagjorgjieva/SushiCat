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
        public int highscore { get; set; } = 0;

        public Player(string playerName)
        {
            PlayerName = playerName;
        }
        
        public void updateHighScore(int score)
        {
            if(isHighScore(score))
                highscore = score;
        }

        public bool isHighScore(int score)
        {
            if (highscore < score)
                return true;
            else return false;
        }
    }
}
