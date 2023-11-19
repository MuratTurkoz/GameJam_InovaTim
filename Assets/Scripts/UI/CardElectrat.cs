using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardElectrat : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI _electratText;
    private void OnEnable()
    {
        UpdateElectratDisplay();
        GameSession.Instance.BuzChanged += OnElectratChanged;
    }
    private void OnDisable()
    {
        GameSession.Instance.BuzChanged -= OnElectratChanged;
    }
    public void OnElectratChanged(int newEnergy)
    {
        UpdateElectratDisplay(newEnergy);
    }
    private void UpdateElectratDisplay(int val)
    {
        _electratText.text = $"+{GameSession.Instance.Electrat}";
    }
    private void UpdateElectratDisplay()
    {
        UpdateElectratDisplay(GameSession.Instance.Electrat);
    }
}
