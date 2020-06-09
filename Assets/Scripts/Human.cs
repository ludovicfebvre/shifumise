using UnityEngine;

/// <summary>
/// Class Human that implements Player interface
/// </summary>
public class Human : Player
{

    /// <summary>
    /// Bet Setter
    /// </summary>
    /// <param name="choosedBet"></param>
    public void SetCurrentBet(int choosedBet)
    {
        currentBet = choosedBet;
    }

    public void SetSign(SignName sign)
    {
        currentSign = sign;
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

    public SignName GetCurrentSign()
    {
        return currentSign;
    }
}
