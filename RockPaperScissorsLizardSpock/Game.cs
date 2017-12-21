using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        public User PlayerOne;
        public User PlayerTwo;
        public AI AI;
        public string option;

       public Game()
        {
            Console.Write("Welcome to rock paper scissors lizard spock.");
            Console.Write("the game is simple, pick rock paper scissors or spock, and see if you win the round.");
            Console.Write("best 2 out of 3 wins");
            Console.ReadKey();
            Console.WriteLine("Please emter '1' for one player, and enter '2' for two players");
            option = Console.ReadLine();


        }

        public void OptionPlayers()
        {
            if (option = "1")
            {
                PlayerOne = new User();
                AI = new AI();
            }
            else if (option = "2")
            {
                PlayerOne = new User();
                PlayerTwo = new User();
            }
            else
            {
                Console.WriteLine("hey you typed something in wrong");
                OptionPlayers();
            }
        }
    }
}
