using System;

namespace tennisGame
{
    public class Tennis{
        private int playerTwoScore;
        private int playerOneScore;
        public string ShowScore()
        {
            string[] score = new string[] {"Love","Fifteen","Thirty", "Forty"};

            if(playerOneScore == 4 && playerTwoScore == 3){
                return "Player 1 Advantage";
            }
            if(playerOneScore == 5 && playerTwoScore == 3){
                return "Player 1 Game";
            }            
            // if(playerOneScore == 3 && playerTwoScore ==3){
            //     return "Deuce";
            // }
            if(isDeuce()){
                return "Deuce";
            }
            if(playerTwoScore == 4 && playerOneScore <=3){
                return "Player 2 Game";
            }            
            if(playerTwoScore == 4 && playerOneScore ==3){
                return "Player 2 Advantage";
            }
            if(playerTwoScore == 5 && playerOneScore ==3){
                return "Player 2 Game";
            }  
            return "Love - " + score[playerTwoScore];
        }

        public void ScoreTwo()
        {
            playerTwoScore++;
        }
        public void ScoreOne()
        {
            playerOneScore++;
        }
        private bool isDeuce(){
            return (playerOneScore >= 3 && playerTwoScore >= 3) && (playerOneScore == playerTwoScore);
        }
    }
    


}