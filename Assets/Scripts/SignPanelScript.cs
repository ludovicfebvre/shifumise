using System.Collections.Generic;
using UnityEngine;

public class SignPanelScript : MonoBehaviour
{

    private List<SignCallback> signCallbackList = new List<SignCallback>();

    public void AddSignCallback(SignCallback signCallback)
    {
        signCallbackList.Add(signCallback);
    }

    public void RemoveSignCallback(SignCallback signCallback)
    {
        signCallbackList.Remove(signCallback);
    }

    public void ChoseSign(SignName signName)
    {
        signCallbackList.ForEach(delegate (SignCallback signCallback) {
            signCallback.OnSignChosen(signName);
        });
    }

    public void ChoseRock()
    {
        ChoseSign(SignName.ROCK);
    }

    public void ChosePaper()
    {
        ChoseSign(SignName.PAPER);
    }

    public void ChoseScissors()
    {
        ChoseSign(SignName.SCISSORS);
    }

    public void SetActive(bool active)
    {
        gameObject.SetActive(active);
    }

    public interface SignCallback
    {
        void OnSignChosen(SignName sign);
        void OnTimeOut();
    }
}
