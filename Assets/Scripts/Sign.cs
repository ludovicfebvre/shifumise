using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class Sign
/// </summary>
public class Sign
{
    private SignName name;
    private Player player;

    /// <summary>
    /// Sign Constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="player"></param>
    public Sign(SignName name, Player player)
    {
        this.name = name;
        this.player = player;
    }

    /// <summary>
    /// Name Getter
    /// </summary>
    /// <returns></returns>
    public SignName GetName()
    {
        return name;
    }
}
