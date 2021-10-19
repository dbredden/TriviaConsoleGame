using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaConsoleApp
{
    public class Player
    {
        public string Name { get; set; }
        public int Lives { get; set; }
        public Player(string playerName, int lives)
        {
            Name = playerName;
            Lives = lives;
        }
    }
}
