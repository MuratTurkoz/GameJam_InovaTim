using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameSession : MonoBehaviour
{
    // Start is called before the first frame update
    private static GameSession _instance;
    public static GameSession Instance
    {
        get
        {
            if (!_instance)
            {

                _instance = FindObjectOfType<GameSession>();

            }

            return _instance;
        }
    }
    //[SerializeField] private AudioSource _audioSourceOther;
    //[SerializeField] private AudioClip[] _clips;
    //public bool IsInnerVoice = true;
    //public bool IsExternalVoice = true;
    //private AudioSource _audioSource;
    //public AudioSource AudioSource { get => _audioSource; set => _audioSource = value; }
    void Awake()
    {
        if (_instance && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    public event Action<int> BuzChanged;
    public UnityAction<int> OnElectratChanged;
    public UnityAction<int> OnSceneBuildChanged;
    private int _buz;
    public int Buz
    {
        get { return _buz; }
        set
        {
            _buz = value;
            BuzChanged?.Invoke(_buz);
        }
    }
    private int _electrat = 0;
    public int Electrat
    {
        get { return _electrat; }
        set
        {
            _electrat = value;

            OnElectratChanged?.Invoke(_electrat);
        }
    }
    private int _sceneBuidIndex;
    public int SceneBuidIndex
    {
        get { return _sceneBuidIndex; }
        set
        {
            _sceneBuidIndex = value;
            OnSceneBuildChanged?.Invoke(_sceneBuidIndex);
        }
    }
    private void Start()
    {
        //_audioSource = GetComponent<AudioSource>();
        //if (PlayerPrefs.GetInt("Sound") == 0)
        //{
        //    _audioSource.Play();
        //}
    }
}
