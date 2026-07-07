using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int bestScore;
    public int score;
    public TMP_Text scoreText;

    public GameObject restartMenu;
    public TMP_Text restartBestScoreText;
    public TMP_Text restartScoreText;

    private void Start()
    {
        if (PlayerPrefs.HasKey("BestScore"))
        {
            bestScore = PlayerPrefs.GetInt("BestScore");
        }
    }
    public void AddScore()
    {
        score+=1;
        scoreText.text = score.ToString();
    }

    public void Death()
    {
        restartBestScoreText.text = "BEST SCORE: " + bestScore.ToString();
        restartScoreText.text = "SCORE: " + score.ToString();
        
        if (score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetInt("BestScore", bestScore);    
        }

        restartMenu.SetActive(true);
        Time.timeScale = 0;
    }

}
