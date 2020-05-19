using UnityEngine;

public class IA : Player
{
    new public void PerformBet(int moveBet, Bet bet)
    {
        this.moveBet = moveBet;
        int random = Random.Range(0, 3);
        switch (random)
        {
            case 0:
                currentBet = Bet.ROCK;
                break;

            case 1:
                currentBet = Bet.PAPER;
                break;

            case 2:
                currentBet = Bet.SCISSORS;
                break;
        }
    }
}
