using System;
using Xunit;

namespace tennisGame
{
    public class tennisGameTest
    {
        [Fact]

        public void StartGameScoreShouldBeLoveLove()
        {
            //Arrange
            Tennis tennis = new Tennis();

            //Action
            string score = tennis.ShowScore();

            //Assert
            Assert.Equal("Love - Love", score);
        }

        // [Fact]

        public void PlayerTwoWinFirstBallScoreShouldBeLoveFifteen()
        {
            //Arrange
            Tennis tennis = new Tennis();
            
            tennis.ScoreTwo();
            tennis.ScoreTwo();

            //Assert
            Assert.Equal("Love - Fifteen", tennis.ShowScore());

        }

        [Fact]

        public void PlayerTwoWinTwoBallScoreShouldBeLoveThirty()
        {
            //Arrange
            Tennis tennis = new Tennis();
            
            tennis.ScoreTwo();
            tennis.ScoreTwo();
            //tennis.ScoreTwo();

            //Assert
            Assert.Equal("Love - Thirty", tennis.ShowScore());

        }

        [Fact]

        public void PlayerTwoWinThreeBallScoreShouldBeLoveForty()
        {
            //Arrange
            Tennis tennis = new Tennis();
            
            tennis.ScoreTwo();
            tennis.ScoreTwo();
            tennis.ScoreTwo();
            //tennis.ScoreTwo();

            //Action
            //String score = tennis.ShowScore();

            //Assert
            Assert.Equal("Love - Forty", tennis.ShowScore());

        }

        [Fact]

        public void PlayerTwoWinFourBallScoreShouldBeGame()
        {
            //Arrange
            Tennis tennis = new Tennis();
            
            tennis.ScoreTwo();
            tennis.ScoreTwo();
            tennis.ScoreTwo();
            tennis.ScoreTwo();

            //Action
            //String score = tennis.ShowScore();

            //Assert
            Assert.Equal("Player 2 Game", tennis.ShowScore());

        }

        [Fact]
        public void PlayerOneWin3BallAndPlayerTwoWin3BallScoreShouldBeDeuce(){

            Tennis tennis = new Tennis();
            tennis.ScoreTwo();
            tennis.ScoreTwo();
            tennis.ScoreTwo();
            tennis.ScoreOne();
            tennis.ScoreOne();
            tennis.ScoreOne();

             //Assert
            Assert.Equal("Deuce", tennis.ShowScore());
        }

        private void createScore(Tennis tennis, int numberOfBall){
            for (int i = 0; i < numberOfBall; i++){
                tennis.ScoreTwo();
            }
        }


    }
}