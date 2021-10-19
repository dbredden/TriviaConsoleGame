using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TriviaConsoleApp.Game;

namespace TriviaConsoleApp
{
    public class TriviaItem
    {
        public string Question;
        public string PlayerAnswer;
        public string Answer;
        public int currentLives;

        public TriviaItem(string triviaQuestion, string triviaAnswer)
        {
            Question = triviaQuestion;
            Answer = triviaAnswer;
        }
    }
}
