using System;
using System.Collections.Generic;
using System.Text;


namespace ROSHAMBO
{
    public class RPSClass
    {
        public string PaperWins(string rockInput, string paperInput)
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
    }
}
