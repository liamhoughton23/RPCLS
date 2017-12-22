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
        public string a;
        public RPCLS formula;
        public int value;


        public User()
        {
            GetName();
            MakeChoice();
        }

        public string GetName()
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            return name;
        }


        public override int MakeChoice()
        {
            Console.WriteLine("Pick 'rock', 'paper', 'scissors', 'lizard', or 'spock'");
            a = Console.ReadLine();
            switch (a)
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
