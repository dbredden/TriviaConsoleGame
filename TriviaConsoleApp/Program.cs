using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TriviaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // lose 3 lives. 
            //below we are creating a variable of currentGame using our Game class
            Game currentGame = new Game();
            //this line is going to play our currentGame variable by going to our play method in the Game class and run those lines of code.
            currentGame.Play();
           
        }
    }
}
