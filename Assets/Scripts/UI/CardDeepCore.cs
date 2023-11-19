using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardDeepCore : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI _deepCoreText;
    private void OnEnable()
    {
        UpdateDeepCoretDisplay();
        GameSession.Instance.OnDeepCoreChanged += OnDeepCoreChanged;
    }
    private void OnDisable()
    {
        GameSession.Instance.OnDeepCoreChanged -= OnDeepCoreChanged;
    }
    public void OnDeepCoreChanged(int newEnergy)
    {
        UpdateDeepCoreDisplay(newEnergy);
    }
    private void UpdateDeepCoreDisplay(int val)
    {
        _deepCoreText.text = $"+{GameSession.Instance.DeepCore}";
    }
    private void UpdateDeepCoretDisplay()
    {
        UpdateDeepCoreDisplay(GameSession.Instance.DeepCore);
    }
}
