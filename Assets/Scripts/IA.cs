using UnityEngine;

/// <summary>
/// Class IA that implements Player interface
/// </summary>
public class IA : Player
{

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
    public void ChooseSign()
    {
        int random = Random.Range(0, 3);
        switch (random)
        {
            case 0:
                currentSign = SignName.ROCK;
                break;

            case 1:
                currentSign = SignName.PAPER;
                break;

            default:
                currentSign = SignName.SCISSORS;
                break;
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

    public SignName GetCurrentSign()
    {
        return currentSign;
    }
}
