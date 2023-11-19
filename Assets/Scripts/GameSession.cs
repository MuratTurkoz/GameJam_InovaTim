using System;
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
    public UnityAction<int> OnThermaliteChanged;
    public UnityAction<int> OnDeepCoreChanged;
    public UnityAction<int> OnCardBioGrowChanged;
    public UnityAction<int> OnSceneBuildChanged;
    private int _bioGrow;
    public int BioGrow
    {
        get { return _bioGrow; }
        set
        {
            _bioGrow = value;
           OnCardBioGrowChanged?.Invoke(_bioGrow);
        }
    }
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
    private int _thermalite = 0;
    public int Thermalite
    {
        get { return _thermalite; }
        set
        {
            _thermalite = value;

            OnThermaliteChanged?.Invoke(_thermalite);
        }
    }
    private int _deepCore = 0;
    public int DeepCore
    {
        get { return _deepCore; }
        set
        {
            _deepCore = value;

            OnDeepCoreChanged?.Invoke(_deepCore);
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
