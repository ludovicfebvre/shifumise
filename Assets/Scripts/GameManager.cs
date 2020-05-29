using System;
using UnityEngine;

/// <summary>
/// Class GameManager
/// </summary>
public class GameManager : MonoBehaviour
{

    private Human player;
    private IA ia;
    private Board board;

    void Start()
    {
        OnStartGame(new Human("HUMAINNNNNNNNN",0, SignName.PAPER, 0), new IA("SKYNET",0,SignName.PAPER,0));
    }

    void Update()
    {
        OnBet();
    }

    /// <summary>
    /// Init Method
    /// </summary>
    /// <param name="player1"></param>
    /// <param name="ia"></param>
    public void OnStartGame(Human player, IA ia)
    {
        this.player = player;
        this.ia = ia;
    }

    /// <summary>
    /// OnBet Event Method
    /// </summary>
    public void OnBet()
    {

    }

    /// <summary>
    /// Method that determine which Sign has won.
    /// </summary>
    /// <param name="playerBet"></param>
    /// <param name="opponentbet"></param>
    /// <returns></returns>
    public bool IsWinner(Sign playerBet, Sign opponentBet)
    {
        if (opponentBet.GetName() == SignName.ROCK && playerBet.GetName() == SignName.PAPER)
        {
            return true;
        }
        else if (opponentBet.GetName() == SignName.PAPER && playerBet.GetName() == SignName.SCISSORS)
        {
            return true;
        }
        else if (opponentBet.GetName() == SignName.SCISSORS && playerBet.GetName() == SignName.ROCK)
        {
            return true;
        }
        return false;
    }

    /// <summary>
    /// OnResult Event Method
    /// </summary>
    public void OnResult()
    {

    }

}
