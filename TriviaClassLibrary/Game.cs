using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaConsoleApp
{
    public class Game
    {
        private string GameTitleArt = @"
 _____      _       _         __    __ _ _   _                    
/__   \_ __(_)_   _(_) __ _  / / /\ \ (_) |_| |__                 
  / /\/ '__| \ \ / / |/ _` | \ \/  \/ / | __| '_ \                
 / /  | |  | |\ V /| | (_| |  \  /\  /| | |_| | | |               
 \/   |_|  |_| \_/ |_|\__,_|   \/  \/ |_|\__|_| |_|               
                                                                  
    ___                            __          _     _            
   /   \__ _ _ __  _ __  _   _    /__\ ___  __| | __| | ___ _ __  
  / /\ / _` | '_ \| '_ \| | | |  / \/// _ \/ _` |/ _` |/ _ \ '_ \ 
 / /_// (_| | | | | | | | |_| | / _  \  __/ (_| | (_| |  __/ | | |
/___,' \__,_|_| |_|_| |_|\__, | \/ \_/\___|\__,_|\__,_|\___|_| |_|
                         |___/                                    
";
        private string GameTitle = "Trivia with Danny Redden\n";
        private string Description = "Have fun playing trivia with our host Danny Redden. See who can get the highest score!\n";
        public Player CurrentPlayer;
        private TriviaItem QuestionOne;
        private TriviaItem QuestionTwo;
        private TriviaItem QuestionThree;
        private TriviaItem QuestionFour;
        private TriviaItem QuestionFive;
        private TriviaItem QuestionSix;
        private TriviaItem QuestionSeven;
        private TriviaItem QuestionEight;
        private TriviaItem QuestionNine;
        private TriviaItem QuestionTen;

        public Game()
        {
            string questionOne = "The National Animal of Scotland is the Unicorn - true or false?";
            QuestionOne = new TriviaItem(questionOne, "true");

            string questionTwo = "An octopus can fit through any hold larger than its beak - true or false?";
            QuestionTwo = new TriviaItem(questionTwo, "true");

            string questionThree = "Bleach never expires - true or false?";
            QuestionThree = new TriviaItem(questionThree, "false");

            string questionFour = "The United Kingdom is almost the same size as France. - true or false?";
            QuestionFour = new TriviaItem(questionFour, "false");

            string questionFive = "The longest river in the world is the Amazon River- true or false?";
            QuestionFive = new TriviaItem(questionFive, "false");

            string questionSix = "Polar bears can only live in the Artic region, not the Antartic - true or false?";
            QuestionSix = new TriviaItem(questionSix, "true");

            string questionSeven = "Walt Disney has the record for most Academy Awards. - true or false?";
            QuestionSeven = new TriviaItem(questionSeven, "true");

            string questionEight = "The moon is wider than Australia. - true or false?";
            QuestionEight = new TriviaItem(questionEight, "false");

            string questionNine = "Seahorses have stomachs, which aid in the digestion of food. - true or false?";
            QuestionNine = new TriviaItem(questionNine, "false");

            string questionTen = "The Caribbean Island of Aruba is part of Portugal. - true or false?";
            QuestionTen = new TriviaItem(questionTen, "false");

        }
        public void AskQuestion(TriviaItem triviaItem)
        {
            // TODO -- this should display the question, get a response, and display the correct answer.
            Console.WriteLine(triviaItem.Question);
            Console.WriteLine("What's your answer? ");
            string playerAnswer = Console.ReadLine();
            Console.WriteLine($"You answered '{playerAnswer}'.");
            Console.WriteLine($"The correct answer was: {triviaItem.Answer}");
            if (CurrentPlayer.Lives == 1 && playerAnswer != triviaItem.Answer)
            {
                Console.WriteLine("You have lost the game!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (playerAnswer != triviaItem.Answer)
            {
                CurrentPlayer.Lives = CurrentPlayer.Lives - 1;
                Console.WriteLine($"You have lost a life!, you now only have {CurrentPlayer.Lives}!");
            }
        }

        public void Play()
        {
            Console.WriteLine(GameTitleArt);
            Console.WriteLine($"Welcome to {GameTitle}");
            Console.WriteLine(Description);

            Console.Write("First, tell us what is your name:  ");
            // below will take in whatever the user inputs and store that input as the variable playerName
            string playerName = Console.ReadLine();
            // below we will have a current player constructed using the name we are passing in. 
            CurrentPlayer = new Player(playerName, 3);
            Console.WriteLine($"{CurrentPlayer.Name} - welcome to {GameTitle}");
            Console.WriteLine($"You will start the game with {CurrentPlayer.Lives} lives");
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            //CLEAR SCREEN?
            Console.Clear();
            Console.WriteLine("\n--------------------------------------");
            AskQuestion(QuestionOne);
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("Press any key for next question!");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("\n--------------------------------------");
            AskQuestion(QuestionTwo);
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("Press any key for next question!");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("\n--------------------------------------");
            AskQuestion(QuestionThree);
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("Press any key for next question!");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("\n--------------------------------------");
            AskQuestion(QuestionFour);
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("Press any key for next question!");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("\n--------------------------------------");
            AskQuestion(QuestionFive);
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("Press any key for next question!");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("\n--------------------------------------");
            AskQuestion(QuestionSix);
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("Press any key for next question!");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("\n--------------------------------------");
            AskQuestion(QuestionSeven);
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("Press any key for next question!");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("\n--------------------------------------");
            AskQuestion(QuestionEight);
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("Press any key for next question!");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("\n--------------------------------------");
            AskQuestion(QuestionNine);
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("Press any key for next question!");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("\n--------------------------------------");
            AskQuestion(QuestionTen);
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("Press any key for next question!");
            Console.ReadKey();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
