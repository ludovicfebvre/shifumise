using UnityEngine;

public class Player
{

    public Bet currentBet { get; set; }
    public int moveBet { get; set; }


    public void PerformBet(int moveBet, Bet bet)
    {
        this.moveBet = moveBet;
        this.currentBet = bet;
    }

    public bool IsWinner(Bet opponentBet)
    {
        if (opponentBet == Bet.ROCK && currentBet == Bet.PAPER)
        {
            return true;
        }
        else if (opponentBet == Bet.PAPER && currentBet == Bet.SCISSORS)
        {
            return true;
        }
        else if (opponentBet == Bet.SCISSORS && currentBet == Bet.ROCK)
        {
            return true;
        }
        return false;
    }

    public Bet RandBet()
    {
        int random = Random.Range(0, 3);
        switch (random)
        {
            case 0:
                return Bet.ROCK;

            case 1:
                return Bet.PAPER;

           default:
                return Bet.SCISSORS;
        }
    }
}
