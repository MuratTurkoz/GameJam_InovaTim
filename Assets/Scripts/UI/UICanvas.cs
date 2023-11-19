
using System;
using UnityEngine;

public class UICanvas : MonoBehaviour
{
    [SerializeField] private GameObject CardBuz;
    [SerializeField] private GameObject CardElect;
    [SerializeField] private GameObject CardDeep;
    [SerializeField] private GameObject CardBio;
    [SerializeField] private GameObject Cardthe;
    // Start is called before the first frame update


    public void CardBuzDisable()
    {
        CardBuz.SetActive(false);
    }

    public void CardBioObjDisable()
    {
        CardBio.SetActive(false);
    }

    public void CardDeepDisable()
    {
        CardDeep.SetActive(false);
    }

    public void CardElectObjDisable()
    {
        CardElect.SetActive(false);
    }

    public void CardThermaliteObjDisable()
    {
        Cardthe.SetActive(false);
    }
}
