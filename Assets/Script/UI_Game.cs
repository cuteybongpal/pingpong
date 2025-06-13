using UnityEngine;
using UnityEngine.UI;

public class UI_Game : MonoBehaviour
{
    public Text ScoreText;
    public Text WinText;
    void Start()
    {
        ScoreText.text = "0 : 0";
        WinText.gameObject.SetActive(false);
    }

    public void ScoreChange(int[] scores)
    {
        ScoreText.text = $"{scores[0]} : {scores[1]}";

        if (scores[0] >= 7)
        {
            WinText.gameObject.SetActive(true);
            WinText.text = "Player1 Won";
            GameManager.Instance.score = new int[2];
        }
        if (scores[1] >= 7)
        {
            WinText.gameObject.SetActive(true);
            WinText.text = "Player2 Won";
            GameManager.Instance.score = new int[2];
        }
    }
}
