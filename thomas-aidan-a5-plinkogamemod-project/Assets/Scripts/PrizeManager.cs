using TMPro;
using UnityEngine;

public class PrizeManager : MonoBehaviour
{
    public int maxScore = 500;
    public TMP_Text prizeText;  // assign in Inspector

    public void CheckPrize(int points)
    {
        string prize;

        if (points >= maxScore)
            prize = "You win a diamond medal!";
        else if (points >= 400)
            prize = "You win a gold medal!";
        else if (points >= 300)
            prize = "You win a silver medal!";
        else if (points >= 200)
            prize = "You win a bronze medal!";
        else
            prize = "Unfortunately you did not win, better luck next time!";

        if (prizeText != null)
            prizeText.text = prize;
        else
            Debug.LogWarning("Prize Text not assigned!");
    }
}