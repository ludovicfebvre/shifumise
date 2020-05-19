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
        OnBet();
    }

    public void OnStartGame(Player player1, Player player2)
    {
        this.player1 = player1;
        this.player2 = player2;
    }

    public void OnBet()
    {
        player1.PerformBet(UnityEngine.Random.Range(0, 3), player1.RandBet());
        player2.PerformBet(UnityEngine.Random.Range(0, 3),  player2.RandBet());
        Debug.Log(String.Format("Player 1 : '{0}'", player1.currentBet.ToString()));
        Debug.Log(String.Format("Player 2 : '{0}'", player2.currentBet.ToString()));
        if (player1.IsWinner(player2.currentBet))
        {
            Debug.Log("Player 1 wins");
        }
        else if(player2.IsWinner(player1.currentBet))
        {
            Debug.Log("Player 2 wins");
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
