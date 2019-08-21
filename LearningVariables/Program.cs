using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVariables
{
    class Program
    {
        static void Main()
        {
            //the value
            string greeting = "Hello, user!";
            int playerScore = 0;
            string displayScore = "Your score currently is " + playerScore + ". ";
            //to start the output
            Console.WriteLine(greeting);
            Console.WriteLine(displayScore);
            Console.ReadKey();
        }
    }
}
