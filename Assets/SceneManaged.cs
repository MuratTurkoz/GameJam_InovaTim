using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManaged : MonoBehaviour
{
    [SerializeField] private GameObject _start;
    [SerializeField] private GameObject _next;
    // Start is called before the first frame update
    public void GameStart()
    {
        _start.SetActive(false);
        _next.SetActive(true);
    }
    public void GameExit()
    {
        Application.Quit();
    }
    public void Next()
    {
        
        SceneManager.LoadScene(1);
    }
    public void GetStart()
    {

        SceneManager.LoadScene(0);
    }
}
