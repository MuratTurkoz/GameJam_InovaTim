using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardThermalite : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI _thermaliteText;
    private void OnEnable()
    {
        UpdateThermaliteDisplay();
        GameSession.Instance.OnThermaliteChanged += OnThermaliteChanged;
    }
    private void OnDisable()
    {
        GameSession.Instance.OnThermaliteChanged -= OnThermaliteChanged;
    }
    public void OnThermaliteChanged(int newEnergy)
    {
        UpdateThermaliteDisplay(newEnergy);
    }
    private void UpdateThermaliteDisplay(int val)
    {
        _thermaliteText.text = $"+{GameSession.Instance.Thermalite}";
    }
    private void UpdateThermaliteDisplay()
    {
        UpdateThermaliteDisplay(GameSession.Instance.Thermalite);
    }
}
