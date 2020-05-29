using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class Board
/// </summary>
public class Board
{
    private List<Slot> slots;

    /// <summary>
    /// Board Constructor
    /// </summary>
    public Board()
    {
        this.slots = new List<Slot>();
    }

    /// <summary>
    /// Method that move a player from a given displacement number
    /// </summary>
    /// <param name="player"></param>
    /// <param name="displacement"></param>
    public void movePlayer(Player player, int displacement)
    {
        List<Player> players;
        foreach (Slot slot in slots)
        {
            players = slot.GetPlayers();
            //TODO
        }
    }
}
