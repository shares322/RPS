
using System;

namespace ROSHAMBO
{
    class Program
    {
        static void Main(string[] args)
        {
            RPSClass rpsclass = new RPSClass();
            Console.WriteLine("Please enter one of the following: 1. rock, 2. paper, 3. scissors");
            var userInput = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter a second choice: 1. rock, 2. paper, 3. scissors");
            var userInput1 = Console.ReadLine().ToLower();

        }
    }
}
