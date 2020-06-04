using UnityEngine;

/// <summary>
/// Class IA that implements Player interface
/// </summary>
public class IA : Player
{
    private string name;
    private int currentBet;
    private SignName currentSign;
    private int currentPlace;

    /// <summary>
    /// IA Constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="currentBet"></param>
    /// <param name="currentSign"></param>
    /// <param name="currentPlace"></param>
    public IA(string name, int currentBet, SignName currentSign, int currentPlace)
    {
        this.name = name;
        this.currentBet = currentBet;
        this.currentSign = currentSign;
        this.currentPlace = currentPlace;
    }

    /// <summary>
    /// Method that return random bet between 1 and 4.
    /// </summary>
    /// <returns></returns>
    public void SetCurrentBet()
    {
        currentBet = Random.Range(1, 4);
    }

    /// <summary>
    /// bet Getter
    /// </summary>
    /// <returns></returns>
    public int GetCurrentBet()
    {
        return currentBet;
    }

    /// <summary>
    /// Method that return a random SignName
    /// </summary>
    /// <returns></returns>
    public SignName ChooseSign()
    {
        int random = Random.Range(0, 3);
        switch (random)
        {
            case 0:
                return SignName.ROCK;

            case 1:
                return SignName.PAPER;

            default:
                return SignName.SCISSORS;
        }
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
}
