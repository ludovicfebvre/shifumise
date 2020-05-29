using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class Slot
/// </summary>
public class Slot : MonoBehaviour
{
    private List<Player> players;
    private int movePlayerNumber;
    
    /// <summary>
    /// Slot Constructor
    /// </summary>
    /// <param name="movement"></param>
    public Slot(int movement)
    {
        this.players = new List<Player>();
        this.movePlayerNumber = movement;
    }

    /// <summary>
    /// Method that add a player to the players list
    /// </summary>
    /// <param name="player"></param>
    public void AddPlayer(Player player)
    {
        this.players.Add(player);
    }

    /// <summary>
    /// Method that remove a player from the players list
    /// </summary>
    /// <param name="player"></param>
    public void RemovePlayer(Player player)
    {
        this.players.Remove(player);
    }


    /// <summary>
    /// Method that return the players list
    /// </summary>
    /// <returns></returns>
    public List<Player> GetPlayers()
    {
        return this.players;
    }
}
