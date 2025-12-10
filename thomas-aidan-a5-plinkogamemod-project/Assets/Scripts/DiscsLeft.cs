using TMPro;
using UnityEngine;

public class DiscsLeft : MonoBehaviour
{
    public TMP_Text dlDisplay;
    public TMP_Text outOfDiscsText;
    public GameObject restartButton;
    public int discs = 5;

    private bool prizeShown = false;

    private void Start()
    {
        if (restartButton != null)
            restartButton.SetActive(false);

        if (outOfDiscsText != null)
            outOfDiscsText.gameObject.SetActive(false);

        UpdateDiscsDisplay();
    }

    public void SubDiscs(int dispense)
    {
        discs -= dispense;
        UpdateDiscsDisplay();

        if (discs <= 0 && !prizeShown)
        {
            prizeShown = true;

            if (outOfDiscsText != null)
                outOfDiscsText.gameObject.SetActive(true);

            if (restartButton != null)
                restartButton.SetActive(true);

            // Show prize
            PrizeManager prizeManager = FindObjectOfType<PrizeManager>();
            ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();

            if (prizeManager != null && scoreKeeper != null)
            {
                prizeManager.CheckPrize(scoreKeeper.score);
            }
        }
    }

    public void UpdateDiscsDisplay()
    {
        if (dlDisplay != null)
            dlDisplay.text = $"DISCS LEFT: {discs}";
    }
}