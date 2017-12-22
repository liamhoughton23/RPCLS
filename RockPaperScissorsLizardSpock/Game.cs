using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        public Player PlayerOne;
        public Player PlayerTwo;
        public string option;

       public Game()
        {
            Console.Write("Welcome to rock paper scissors lizard spock.");
            Console.Write("the game is simple, pick rock paper scissors or spock, and see if you win the round.");
            Console.Write("best 2 out of 3 wins");
            Console.ReadKey();
            Console.WriteLine("Please emter '1' for one player, and enter '2' for two players");
            option = Console.ReadLine();
            OptionPlayers();

        }

        public void OptionPlayers()
        {
            Console.WriteLine("Please emter '1' for one player, and enter '2' for two players");
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    PlayerOne = new User();
                    PlayerTwo = new Computer();
                    break;
                case "2":
                    PlayerOne = new User();
                    PlayerTwo = new User();
                    break;
                default:
                    Console.WriteLine("You typed in something wrong, try again.");
                    OptionPlayers();
                    break;

            }
            //method for playing the game
            //playerone make choice
            //playertwo make choice
            //use RPCLS class to determine who won the round
            public void PlayGame()
        {
            PlayerOne.MakeChoice();
            PlayerTwo.MakeChoice();

        }
            
        }
    }
}
