using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// Class GameManager
/// </summary>
public class GameManager : MonoBehaviour
{

    private Human player;
    private IA ia;
    private Board board;



    //BET UI
    public GameObject UIBet;


    void Start()
    {
        OnStartGame(new Human("HUMAINNNNNNNNN",0, SignName.PAPER, 0), new IA("SKYNET",0,SignName.PAPER,0));
    }

    void Update()
    {

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
        UIBet.SetActive(true);
    }

    public void betTreatment(Button btn)
    {
        player.SetCurrentBet(Int32.Parse(btn.name.Substring(btn.name.Length-1)));
        ia.SetCurrentBet();
        UIBet.SetActive(false);
    }

    /// <summary>
    /// Method that determine which Sign has won.
    /// </summary>
    /// <param name="playerSign"></param>
    /// <param name="opponentSign"></param>
    /// <returns></returns>
    public bool IsWinner(Sign playerSign, Sign opponentSign)
    {
        if (opponentSign.GetName() == SignName.ROCK && playerSign.GetName() == SignName.PAPER)
        {
            return true;
        }
        else if (opponentSign.GetName() == SignName.PAPER && playerSign.GetName() == SignName.SCISSORS)
        {
            return true;
        }
        else if (opponentSign.GetName() == SignName.SCISSORS && playerSign.GetName() == SignName.ROCK)
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
