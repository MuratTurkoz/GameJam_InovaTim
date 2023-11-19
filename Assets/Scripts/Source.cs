using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Source")]
public class Source : ScriptableObject
{
    [SerializeField] private Sprite _image;
    public Sprite Image { get { return _image; } set { _image = value; } }
    [SerializeField] private string _textHeader;
    public string TextHeader { get { return _textHeader; } set { _textHeader = value; } }
    [SerializeField][Multiline(10)] private string _textContext;
    public string TextContent { get { return _textContext; } set { _textContext = value; } }
}

