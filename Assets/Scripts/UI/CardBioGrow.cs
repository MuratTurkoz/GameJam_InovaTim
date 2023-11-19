using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardBioGrow : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI _cardBioGrowText;
    private void OnEnable()
    {
        UpdateCardBioGrowDisplay();
        GameSession.Instance.OnCardBioGrowChanged += OnCardBioGrowChanged;
    }
    private void OnDisable()
    {
        GameSession.Instance.OnCardBioGrowChanged -= OnCardBioGrowChanged;
    }
    public void OnCardBioGrowChanged(int newEnergy)
    {
        UpdateCardBioGrowDisplay(newEnergy);
    }
    private void UpdateCardBioGrowDisplay(int val)
    {
        _cardBioGrowText.text = $"+{GameSession.Instance.BioGrow}";
    }
    private void UpdateCardBioGrowDisplay()
    {
        UpdateCardBioGrowDisplay(GameSession.Instance.BioGrow);
    }
}
