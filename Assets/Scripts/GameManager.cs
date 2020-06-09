using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// Class GameManager
/// </summary>
public class GameManager : 
    MonoBehaviour, 
    BetPanelScript.BetCallback, 
    SignPanelScript.SignCallback,
    ResultPanelScript.ResultCallback,
    Player.PlayerCallBack
{
    [SerializeField]
    private Human player;
    [SerializeField]
    private IA ia;
    [SerializeField]
    private BetPanelScript betPanelScript;
    [SerializeField]
    private SignPanelScript signPanelScript;
    [SerializeField]
    private ResultPanelScript resultPanelScript;
    [SerializeField]
    private EndGamePanelScript endGamePanelScript;

    private bool betTurn;

    void Start()
    {
        betPanelScript.AddBetCallback(this);
        signPanelScript.AddSignCallback(this);
        resultPanelScript.AddResultCallback(this);
        player.AddCallback(this);
        ia.AddCallback(this);
        OnBetPhase();
    }

    void Update()
    {

    }

    /// <summary>
    /// OnBet Event Method
    /// </summary>
    public void OnBetPhase()
    {
        resultPanelScript.SetActive(false);
        betPanelScript.SetActive(true);
        ia.SetCurrentBet();
        betPanelScript.SetOpponentBetActive(betTurn);
        betPanelScript.SetOpponentBetImage(ia.GetCurrentBet());
        betTurn = !betTurn;
    }

    public void OnSignChoicePhase()
    {
        betPanelScript.SetActive(false);
        signPanelScript.SetActive(true);
        ia.ChooseSign();
    }

    public void OnResultPhase()
    {
        signPanelScript.SetActive(false);
        resultPanelScript.SetResult(IsWinner(player.GetCurrentSign(), ia.GetCurrentSign()));
        resultPanelScript.SetCoinTotal(player.GetCurrentBet() + ia.GetCurrentBet());
        resultPanelScript.SetPlayerSign(player.GetCurrentSign());
        resultPanelScript.SetOpponentSign(ia.GetCurrentSign());
        resultPanelScript.SetActive(true);
        if(IsWinner(player.GetCurrentSign(), ia.GetCurrentSign()) == Result.WIN)
        {
            player.Move(player.GetCurrentBet() + ia.GetCurrentBet());
        } 
        else if(IsWinner(player.GetCurrentSign(), ia.GetCurrentSign()) == Result.LOSE)
        {
            ia.Move(player.GetCurrentBet() + ia.GetCurrentBet());
        }
    }

    public Result IsWinner(SignName playerSign, SignName opponentSign)
    {
        if (opponentSign == playerSign)
        {
            return Result.DRAW;
        }
        if (opponentSign == SignName.ROCK && playerSign == SignName.PAPER)
        {
            return Result.WIN;
        }
        else if (opponentSign == SignName.PAPER && playerSign == SignName.SCISSORS)
        {
            return Result.WIN;
        }
        else if (opponentSign == SignName.SCISSORS && playerSign == SignName.ROCK)
        {
            return Result.WIN;
        }
        return Result.LOSE;
    }

    void BetPanelScript.BetCallback.OnBet(int bet)
    {
        player.SetCurrentBet(bet);
        OnSignChoicePhase();
    }

    void BetPanelScript.BetCallback.OnTimeOut()
    {
        //TODO : Aléatoire
        player.SetCurrentBet(1);
        OnSignChoicePhase();
    }

    void SignPanelScript.SignCallback.OnSignChosen(SignName sign)
    {
        player.SetSign(sign);
        OnResultPhase();
    }

    void SignPanelScript.SignCallback.OnTimeOut()
    {
        //TODO : Aléatoire
        player.SetSign(SignName.PAPER);
        OnResultPhase();
    }

    void ResultPanelScript.ResultCallback.OnConfirm()
    {
        OnBetPhase();
    }

    void Player.PlayerCallBack.OnStartMoving(Player player)
    {

    }

    void Player.PlayerCallBack.OnMoving(Player player)
    {

    }

    void Player.PlayerCallBack.OnStopMoving(Player player)
    {

    }

    void Player.PlayerCallBack.OnWin(Player player)
    {
        endGamePanelScript.SetWinner(player);
        betPanelScript.SetActive(false);
        signPanelScript.SetActive(false);
        resultPanelScript.SetActive(false);
        endGamePanelScript.SetActive(true);
    }
}
