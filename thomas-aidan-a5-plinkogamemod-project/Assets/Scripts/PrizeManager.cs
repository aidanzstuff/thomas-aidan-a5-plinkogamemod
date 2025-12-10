using UnityEngine;

public class PrizeManager : MonoBehaviour
{
    public int maxScore = 500;

    public void CheckPrize(int points)
    {
        string prize;

        if (points >= maxScore)
        {
            prize = "Jackpot!";
        }
        else if (points >= 400)
        {
            prize = "Huge Prize!";
        }
        else if (points >= 300)
        {
            prize = "Big Prize!";
        }
        else if (points >= 200)
        {
            prize = "Medium Prize!";
        }
        else if (points >= 100)
        {
            prize = "Small Prize!";
        }
        else
        {
            prize = "Better luck next time!";
        }

        Debug.Log($"You scored {points} points. You win: {prize}");
        // Optional: show on UI here
    }
}