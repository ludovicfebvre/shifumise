using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BetPanelScript : MonoBehaviour
{

    private List<BetCallback> betCallbackList = new List<BetCallback>();

    [SerializeField]
    private GameObject OpponentBetImage;
    [SerializeField]
    private GameObject OpponentBetText;
    [SerializeField]
    private GameObject OpponentBetTextStroke;
    [SerializeField]
    private List<Sprite> coinSpriteList;

    public void AddBetCallback(BetCallback betCallback)
    {
        betCallbackList.Add(betCallback);
    }

    public void RemoveBetCallback(BetCallback betCallback)
    {
        betCallbackList.Remove(betCallback);
    }

    public void Bet(int value)
    {
        betCallbackList.ForEach(delegate (BetCallback betCallback) {
            betCallback.OnBet(value);
        });
    }

    public void SetActive(bool active)
    {
        gameObject.SetActive(active);
    }

    public void SetOpponentBetActive(bool active)
    {
        OpponentBetImage.SetActive(active);
        OpponentBetText.SetActive(active);
        OpponentBetTextStroke.SetActive(active);
    }

    public void SetOpponentBetImage(int betValue)
    {
        OpponentBetImage.GetComponent<Image>().sprite = coinSpriteList[betValue - 1];
    }


    public interface BetCallback
    {
        void OnBet(int bet);
        void OnTimeOut();
    }

}
