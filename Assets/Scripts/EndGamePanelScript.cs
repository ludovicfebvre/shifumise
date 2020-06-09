using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGamePanelScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI Title;
    [SerializeField]
    private TextMeshProUGUI TitleStroke;

    public void SetWinner(Player player)
    {
        Title.SetText(player.name + " wins!");
        TitleStroke.SetText(player.name + " wins!");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SetActive(bool active)
    {
        gameObject.SetActive(active);
    }

}
