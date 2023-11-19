using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UICanvas UICanvas;

    [SerializeField] private GameObject _buzObj;
    [SerializeField] private GameObject _yapi1;
    [SerializeField] private GameObject _yapi2;
    [SerializeField] private GameObject _yapi3;
    [SerializeField] private GameObject _yapi4;
    [SerializeField] private GameObject _yapi5;
    [SerializeField] private GameObject _electObj;
    [SerializeField] private GameObject _TherObj;
    [SerializeField] private GameObject _DeepObj;
    [SerializeField] private GameObject _BioObj;
    [SerializeField] private GameObject _LastCard;
    public static int _val = 0;
    private bool isBuz = false;
    //public static bool isBuz=false;
    public void GetBuzUpdate()
    {
        StartCoroutine(nameof(WaitBuzz));
    }
    private IEnumerator WaitBuzz()
    {
        yield return new WaitForSeconds(0.2f);

        UICanvas.CardBuzDisable();
        _yapi1.SetActive(true);
        isBuz = true;
        _val++;
        InvokeRepeating("IncreaseBuzzVaue", 0, 5f);
        PlayerCharacterMoveTest.IsInteractable = false;
        _buzObj.SetActive(false);
        yield return new WaitForSeconds(1);
        if (_val == 5)
        {

            _LastCard.SetActive(true);

        }
    }
    private void IncreaseBuzzVaue()
    {
        GameSession.Instance.Buz++;
    }
    private void IncreaseElecVaue()
    {
        GameSession.Instance.Electrat++;
    }
    private void IncreaseTherVaue()
    {
        GameSession.Instance.Thermalite++;
    }
    private void IncreaseDeepVaue()
    {
        GameSession.Instance.DeepCore++;
    }
    private void IncreaseBiopVaue()
    {
        GameSession.Instance.BioGrow++;
    }
    public void GetElectratUpdate()
    {
        StartCoroutine(nameof(WaitElectrat));
    }
    private IEnumerator WaitElectrat()
    {
        yield return new WaitForSeconds(0.2f);
        _yapi2.SetActive(true);
        _val++;
        InvokeRepeating("IncreaseElecVaue", 0, 5f);
        UICanvas.CardElectObjDisable();
        //isBuz = true;
        PlayerCharacterMoveTest.IsInteractable = false;
        _electObj.SetActive(false);
        yield return new WaitForSeconds(1);
        if (_val == 5)
        {

            _LastCard.SetActive(true);

        }
    }
    public void GetTherObjUpdate()
    {
        StartCoroutine(nameof(WaitTherObj));
    }
    private IEnumerator WaitTherObj()
    {
        yield return new WaitForSeconds(0.2f);
        _yapi3.SetActive(true);
        _val++;
        InvokeRepeating("IncreaseTherVaue", 0, 5f);
        UICanvas.CardThermaliteObjDisable();
        //isBuz = true;
        PlayerCharacterMoveTest.IsInteractable = false;
        _TherObj.SetActive(false);
        yield return new WaitForSeconds(1);
        if (_val == 5)
        {

            _LastCard.SetActive(true);

        }
    }
    public void GetBioUpdate()
    {
        StartCoroutine(nameof(WaitBio));
    }
    private IEnumerator WaitBio()
    {
        yield return new WaitForSeconds(0.2f);
        _yapi5.SetActive(true);
        _val++;
        InvokeRepeating("IncreaseBiopVaue", 0, 5f);
        UICanvas.CardBioObjDisable();
        //isBuz = true;
        PlayerCharacterMoveTest.IsInteractable = false;
        _BioObj.SetActive(false);
        yield return new WaitForSeconds(1);
        if (_val == 5)
        {

            _LastCard.SetActive(true);

        }

    }
    public void GetDeepUpdate()
    {
        StartCoroutine(nameof(WaitDeep));
    }
    private IEnumerator WaitDeep()
    {
        yield return new WaitForSeconds(0.2f);
        _yapi4.SetActive(true);
        _val++;
        InvokeRepeating("IncreaseDeepVaue", 0, 5f);
        UICanvas.CardDeepDisable();
        //isBuz = true;
        PlayerCharacterMoveTest.IsInteractable = false;
        _DeepObj.SetActive(false);
        yield return new WaitForSeconds(1);
        if (_val == 5)
        {

            _LastCard.SetActive(true);

        }
    }
    public void GetStart()
    {

        SceneManager.LoadScene(0);
    }

}
