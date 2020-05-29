using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Class Coin
/// </summary>
public class Coin
{
    private int move;
    private Player player;

    /// <summary>
    /// Coin Constructor
    /// </summary>
    /// <param name="move"></param>
    /// <param name="player"></param>
    public Coin(int move, Player player)
    {
        this.move = move;
        this.player = player;
    }

    /// <summary>
    /// Getter of attribute move
    /// </summary>
    /// <returns></returns>
    public int GetMove()
    {
        return this.move;
    }
}
