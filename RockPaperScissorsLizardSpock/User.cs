using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class User : Player
    {
        public string name;


        public User()
        {
            GetName();
        }

        public string GetName()
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            return name;
        }


        public override int MakeChoice()
        {
            string userChoice;
            Console.WriteLine("Pick 'rock', 'paper', 'scissors', 'lizard', or 'spock'");
            userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "rock":
                    value = 0;
                   
                    break;
                case "paper":
                    value = 1;
                   
                    break;
                case "scissors":
                    value = 2;
                  
                    break;
                case "lizard":
                    value = 3;
                   
                    break;
                case "spock":
                    value = 4;
            
                    break;
                default:
                    Console.WriteLine("Oops, typed in something wrong, try again.");
                    return MakeChoice();
                   

            }
            return value;
        }
    }
}
