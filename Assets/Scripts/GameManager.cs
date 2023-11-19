using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UICanvas UICanvas;
    public void GetBuzUpdate()
    {
        UICanvas.CardBuzDisable();
        GameSession.Instance.Buz++;
    }
}
