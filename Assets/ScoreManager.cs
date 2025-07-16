using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score;
    public TMP_Text scoreText;

    private void Start()
    {
        score = 0;
        UpdateScoreTextUI();
    }

    public void AddScore()
    {
        score++;
        UpdateScoreTextUI();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreTextUI();
    }

    public void UpdateScoreTextUI()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
