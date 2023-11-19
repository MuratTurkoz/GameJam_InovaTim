using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UICanvas UICanvas;
    [SerializeField] private GameObject _buzObj;
    [SerializeField] private GameObject _electObj;
    [SerializeField] private GameObject _TherObj;
    [SerializeField] private GameObject _DeepObj;
    [SerializeField] private GameObject _BioObj;
    //public static bool isBuz=false;
    public void GetBuzUpdate()
    {
        StartCoroutine(nameof(WaitBuzz));
    }
    private IEnumerator WaitBuzz()
    {
        yield return new WaitForSeconds(0.2f);
        GameSession.Instance.Buz++;
        UICanvas.CardBuzDisable();
        //isBuz = true;
        _buzObj.SetActive(false);
    }
    public void GetElectratUpdate()
    {
        StartCoroutine(nameof(WaitElectrat));
    }
    private IEnumerator WaitElectrat()
    {
        yield return new WaitForSeconds(0.2f);
        GameSession.Instance.Buz++;
        UICanvas.CardElectObjDisable();
        //isBuz = true;
        _electObj.SetActive(false);
    }
    public void GetTherObjUpdate()
    {
        StartCoroutine(nameof(WaitTherObj));
    }
    private IEnumerator WaitTherObj()
    {
        yield return new WaitForSeconds(0.2f);
        GameSession.Instance.Thermalite++;
        UICanvas.CardThermaliteObjDisable();
        //isBuz = true;
        _electObj.SetActive(false);
    }
    public void GetBioUpdate()
    {
        StartCoroutine(nameof(WaitBio));
    }
    private IEnumerator WaitBio()
    {
        yield return new WaitForSeconds(0.2f);
        GameSession.Instance.BioGrow++;
        UICanvas.CardBioObjDisable();
        //isBuz = true;
        _BioObj.SetActive(false);
    }
    public void GetDeepUpdate()
    {
        StartCoroutine(nameof(WaitDeep));
    }
    private IEnumerator WaitDeep()
    {
        yield return new WaitForSeconds(0.2f);
        GameSession.Instance.DeepCore++;
        UICanvas.CardDeepDisable();
        //isBuz = true;
        _DeepObj.SetActive(false);
    }
}
