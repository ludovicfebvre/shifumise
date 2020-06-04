using UnityEngine;

/// <summary>
/// Class Human that implements Player interface
/// </summary>
public class Human : Player
{

    private string name;
    private int currentBet;
    private SignName currentSign;
    private int currentPlace;

    /// <summary>
    /// Human Constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="currentBet"></param>
    /// <param name="currentSign"></param>
    /// <param name="currentPlace"></param>
    public Human(string name, int currentBet, SignName currentSign, int currentPlace)
    {
        this.name = name;
        this.currentBet = currentBet;
        this.currentSign = currentSign;
        this.currentPlace = currentPlace;
    }


    /// <summary>
    /// Bet Setter
    /// </summary>
    /// <param name="choosedBet"></param>
    public void SetCurrentBet(int choosedBet)
    {
        currentBet = choosedBet;
    }

    public SignName ChooseSign()
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// Name Getter
    /// </summary>
    /// <returns></returns>
    public string GetName()
    {
        return this.name;
    }

    /// <summary>
    /// Name Setter
    /// </summary>
    /// <returns></returns>
    public void SetName(string name)
    {
        this.name = name;
    }


    /// <summary>
    /// bet Getter
    /// </summary>
    /// <returns></returns>
    public int GetCurrentBet()
    {
        return this.currentBet;
    }
}
