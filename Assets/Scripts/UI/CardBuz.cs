using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardBuz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _buzText;
    private void OnEnable()
    {
        UpdateBuzDisplay();
        GameSession.Instance.BuzChanged += OnBuzChanged;
    }
    private void OnDisable()
    {
        GameSession.Instance.BuzChanged -= OnBuzChanged;
    }
    public void OnBuzChanged(int newEnergy)
    {
        UpdateBuzDisplay(newEnergy);
    }
    private void UpdateBuzDisplay(int val)
    {
        _buzText.text = $"+{GameSession.Instance.Buz}";
    }
    private void UpdateBuzDisplay()
    {
        UpdateBuzDisplay(GameSession.Instance.Buz);
    }
}
