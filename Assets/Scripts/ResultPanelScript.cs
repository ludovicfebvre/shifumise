using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResultPanelScript : MonoBehaviour
{

    private List<ResultCallback> resultCallbackList = new List<ResultCallback>();

    [SerializeField]
    private List<Sprite> signSpriteList;
    [SerializeField]
    private List<Sprite> coinSpriteList;
    [SerializeField]
    private GameObject Result;
    [SerializeField]
    private GameObject ResultStroke;
    [SerializeField]
    private GameObject OpponentSignImage;
    [SerializeField]
    private GameObject PlayerSignImage;
    [SerializeField]
    private GameObject CoinTotalStroke;
    [SerializeField]
    private GameObject CoinTotalTitle;
    [SerializeField]
    private GameObject CoinTotalImage;

    public void SetActive(bool active)
    {
        gameObject.SetActive(active);
    }

    public void SetResult(Result result)
    {
        switch(result)
        {
            case global::Result.WIN:
                Result.GetComponent<TextMeshProUGUI>().SetText("You win!");
                ResultStroke.GetComponent<TextMeshProUGUI>().SetText("You win!");
                CoinTotalStroke.GetComponent<TextMeshProUGUI>().SetText("You earned :");
                CoinTotalTitle.GetComponent<TextMeshProUGUI>().SetText("You earned :");
                CoinTotalStroke.SetActive(true);
                CoinTotalTitle.SetActive(true);
                CoinTotalImage.SetActive(true);
                break;

            case global::Result.DRAW:
                Result.GetComponent<TextMeshProUGUI>().SetText("Draw!");
                ResultStroke.GetComponent<TextMeshProUGUI>().SetText("Draw!");
                CoinTotalStroke.SetActive(false);
                CoinTotalTitle.SetActive(false);
                CoinTotalImage.SetActive(false);
                break;

            case global::Result.LOSE:
                Result.GetComponent<TextMeshProUGUI>().SetText("You lose!");
                ResultStroke.GetComponent<TextMeshProUGUI>().SetText("You lose!");
                CoinTotalStroke.GetComponent<TextMeshProUGUI>().SetText("Opponent earned :");
                CoinTotalTitle.GetComponent<TextMeshProUGUI>().SetText("Opponent earned :");
                CoinTotalStroke.SetActive(true);
                CoinTotalTitle.SetActive(true);
                CoinTotalImage.SetActive(true);
                break;
        }
    }

    public void SetCoinTotal(int value)
    {
        CoinTotalImage.GetComponent<Image>().sprite = coinSpriteList[value - 1];
    }

    public void SetOpponentSign(SignName sign)
    {
        switch (sign)
        {
            case SignName.ROCK:
                OpponentSignImage.GetComponent<Image>().sprite = signSpriteList[0];
                break;

            case SignName.PAPER:
                OpponentSignImage.GetComponent<Image>().sprite = signSpriteList[1];
                break;

            case SignName.SCISSORS:
                OpponentSignImage.GetComponent<Image>().sprite = signSpriteList[2];
                break;
        }
    }

    public void SetPlayerSign(SignName sign)
    {
        switch (sign)
        {
            case SignName.ROCK:
                PlayerSignImage.GetComponent<Image>().sprite = signSpriteList[0];
                break;

            case SignName.PAPER:
                PlayerSignImage.GetComponent<Image>().sprite = signSpriteList[1];
                break;

            case SignName.SCISSORS:
                PlayerSignImage.GetComponent<Image>().sprite = signSpriteList[2];
                break;
        }
    }

    public void Confirm()
    {
        resultCallbackList.ForEach(delegate (ResultCallback resultCallback) {
            resultCallback.OnConfirm();
        });
    }

    public void AddResultCallback(ResultCallback resultCallback)
    {
        resultCallbackList.Add(resultCallback);
    }

    public void RemoveResultCallback(ResultCallback resultCallback)
    {
        resultCallbackList.Remove(resultCallback);
    }

    public interface ResultCallback
    {
        void OnConfirm();
    }

}
