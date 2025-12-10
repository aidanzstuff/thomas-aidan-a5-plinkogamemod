using System.Linq;
using TMPro;
using UnityEngine;

public class DiscsLeft : MonoBehaviour
{
    [Header("UI")]
    public TMP_Text dlDisplay;
    public TMP_Text outOfDiscsText;
    public GameObject restartButton;

    [Header("Gameplay")]
    public int discs = 5;

    private void Awake()
    {
        if (restartButton != null)
            restartButton.SetActive(false);

        if (outOfDiscsText != null)
            outOfDiscsText.gameObject.SetActive(false);
    }

    private void Start()
    {
        UpdateDiscsDisplay();
    }

    public void SubDiscs(int amount)
    {
        // Defensive: ignore nonsensical calls
        if (amount <= 0)
        {
            Debug.LogWarning($"[DiscsLeft] SubDiscs called with non-positive amount: {amount}", this);
            return;
        }

        // Subtract and clamp
        int before = discs;
        discs -= amount;
        if (discs < 0) discs = 0;

        UpdateDiscsDisplay();
        Debug.Log($"[DiscsLeft] SubDiscs({amount}) called. before={before} after={discs}", this);

        if (discs == 0)
        {
            OutOfDiscs();
        }
    }

    private void OutOfDiscs()
    {
        Debug.Log("[DiscsLeft] OutOfDiscs triggered - showing UI.", this);
        if (outOfDiscsText != null) outOfDiscsText.gameObject.SetActive(true);
        if (restartButton != null) restartButton.SetActive(true);
    }

    public void UpdateDiscsDisplay()
    {
        if (dlDisplay != null)
            dlDisplay.text = $"DISCS LEFT: {discs}";
    }
}