using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score=0;

    public void AddCoin()
    {
        score ++;
        Debug.Log(score);
        scoreText.text = $"Score: {score}";
    }
    public void ResetScore()
    {
        score = 0;
    }

}
