using TMPro;
using UnityEngine;

public class DiscsLeft : MonoBehaviour
{
    public TMP_Text dlDisplay;
    public TMP_Text outOfDiscsText;
    public int discs = 5;
    public GameObject restartButton;

    private void Start()
    {
        restartButton.SetActive(false);
        outOfDiscsText.gameObject.SetActive(false);
        UpdateDiscsDisplay();
    }

    public void SubDiscs(int dispense)
    {
        discs -= dispense;
        UpdateDiscsDisplay();

        if (discs <= 0)
        {
            // Shows the out of discs text
            outOfDiscsText.gameObject.SetActive(true);
            // Shows the restart button
            restartButton.SetActive(true);
        }
    }

    public void UpdateDiscsDisplay()
    {
        dlDisplay.text = $"DISCS LEFT: {discs}";
    }
}