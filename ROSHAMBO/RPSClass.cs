using System;
using System.Collections.Generic;
using System.Text;


namespace ROSHAMBO
{
    public class RPSClass
    {
        public string PaperWins(string userInput, string paperInput)
        {
            return paperInput;
        }
        public string ScissorsWin(string scissorsInput, string paperInput)
        {
            return scissorsInput;
        }

        public string RockWins(string scissorsInput, string rockInput)
        {
            return rockInput;
        }

        public string Ties(string userInput1, string userInput)
        {
            return "You tied! Try again.";
        }

        public string EnterOnlyString(string userInput, string userInput1)
        {
          
            if ((userInput == "1") || (userInput == "2") || (userInput == "3"));
            if (string.IsNullOrWhiteSpace(userInput1))
            {
                throw new ArgumentException($"'{nameof(userInput1)}' cannot be null or whitespace", nameof(userInput1));
            }
            else if(string.IsNullOrWhiteSpace(userInput1))
            {
                throw new ArgumentException($"'{nameof(userInput1)}' cannot be null or whitespace", nameof(userInput1));
            }
            else
            {
                return "You have to enter either rock, paper or scissors";
            }          
        }
    }
}
