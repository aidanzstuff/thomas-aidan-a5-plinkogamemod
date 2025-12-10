using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public TMP_Text scoreDisplay;
    public int score = 10;

    private void Start()
    {
        UpdateScoreDisplay();
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreDisplay();
    }

    public void UpdateScoreDisplay()
    {
        scoreDisplay.text = $"SCORE: {score}";
    }
}
