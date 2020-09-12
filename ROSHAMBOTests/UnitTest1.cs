using System;
using Xunit;
using ROSHAMBO;

namespace ROSHAMBOTests
{
    public class UnitTest1
    {
        public string rock { get; private set; }
        public string paper { get; private set; }
        public string scissors { get; private set; }
        public string isTrue { get; private set; }

        [Fact]
        public void PaperBeatsRock()
        {
            //Arrange
            string rockInput = rock;
            string paperInput = paper;
            string expectedResult = isTrue;

            RPSClass rpsclass = new RPSClass();

            //Act
            string result = rpsclass.PaperWins(rockInput, paperInput);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ScissorsBeatPaper()
        {
            //Arrange
            string scissorsInput = scissors;
            string paperInput = paper;
            string expectedResult = isTrue;

            RPSClass rpsclass = new RPSClass();

            //Act
            string result = rpsclass.ScissorsWin(scissorsInput, paperInput);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void RockBeatsScissors()
        {
            //Arrange
            string scissorsInput = scissors;
            string rockInput = rock;
            string expectedResult = isTrue;

            RPSClass rpsclass = new RPSClass();

            //Act
            string result = rpsclass.RockWins(scissorsInput, rockInput);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
