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


        public string GetName()
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            return name;
        }
    }
}
