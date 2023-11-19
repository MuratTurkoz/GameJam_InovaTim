using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SourceCard : MonoBehaviour
{
    [SerializeField] GameObject _gameObject;
    [SerializeField] TextMeshProUGUI _textHeader;
    [SerializeField] TextMeshProUGUI _textContent;
    [SerializeField] Image _image;
    [SerializeField] Source _source;

    private void OnTriggerEnter(Collider other)
    {
       OpenCard();
    }
    private void OnTriggerExit(Collider other)
    {
        CloseCard();
        Debug.Log("Çýktý");
    }


    public void OpenCard()
    {
        _textHeader.text = _source.TextHeader;
        _textContent.text = _source.TextContent;
        _image.sprite= _source.Image;
        _gameObject.SetActive(true);
    }

    public void CloseCard()
    {
        _gameObject.SetActive(false);
    }
}