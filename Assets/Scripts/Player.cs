using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Player Interface
/// </summary>
public abstract class Player : MonoBehaviour
{
    [SerializeField]
    protected string name { get; set; }
    protected int currentBet { get; set; }
    protected SignName currentSign { get; set; }

    protected int position { get; set; }

    protected List<PlayerCallBack> playerCallBackList = new List<PlayerCallBack>();
    [SerializeField]
    private GameObject Roulette;

    public void Move(int amount)
    {
        position += amount;
        transform.RotateAround(Roulette.transform.position, Vector3.back, (float)360 / 37 * amount);
        playerCallBackList.ForEach(delegate (PlayerCallBack playerCallBack) {
            playerCallBack.OnStartMoving(this);
        });
        if(position > 37)
        {
            playerCallBackList.ForEach(delegate (PlayerCallBack playerCallBack) {
                playerCallBack.OnWin(this);
            });
        }
    }

    public void AddCallback(PlayerCallBack playerCallBack)
    {
        playerCallBackList.Add(playerCallBack);
    }

    public void RemoveCallback(PlayerCallBack playerCallBack)
    {
        playerCallBackList.Remove(playerCallBack);
    }


    public interface PlayerCallBack
    {
        void OnStartMoving(Player player);
        void OnMoving(Player player);
        void OnStopMoving(Player player);
        void OnWin(Player player);
    }

}

