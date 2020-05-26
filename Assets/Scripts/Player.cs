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
