using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private Player player1;
    private Player player2;

    void Start()
    {
        OnStartGame(new Player(), new Player());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            OnBet();
        }
        
    }



    public void OnStartGame(Player player1, Player player2)
    {
        this.player1 = player1;
        this.player2 = player2;
    }

    public bool IsWinner(Bet playerBet, Bet opponentBet)
    {
        if (opponentBet == Bet.ROCK && playerBet == Bet.PAPER)
        {
            return true;
        }
        else if (opponentBet == Bet.PAPER && playerBet == Bet.SCISSORS)
        {
            return true;
        }
        else if (opponentBet == Bet.SCISSORS && playerBet == Bet.ROCK)
        {
            return true;
        }
        return false;
    }


    public void OnBet()
    {
        player1.PerformBet(UnityEngine.Random.Range(0, 3), player1.RandBet());
        player2.PerformBet(UnityEngine.Random.Range(0, 3),  player2.RandBet());
        Debug.Log(String.Format("Player 1 : '{0}'", player1.currentBet.ToString()));
        Debug.Log(String.Format("Player 2 : '{0}'", player2.currentBet.ToString()));
        OnBetResult();
    }

    public void OnBetResult()
    {
        if (IsWinner(player1.currentBet, player2.currentBet))
        {
            Debug.Log("Player 1 wins");
        }
        else if (IsWinner(player2.currentBet, player1.currentBet))
        {
            Debug.Log("IA wins");
        }
        else
        {
            Debug.Log("Draws");
        }
    }

    public void OnProcessing()
    {

    }

    public void OnEnd()
    {

    }

}
