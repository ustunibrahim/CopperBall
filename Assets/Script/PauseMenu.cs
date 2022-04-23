using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject Pause;
    void Start()
    {
        Pause.SetActive(false);
    }

    
    void Update()
    {
        
    }
    public void pauseMenu(string ýnput)
    {
        if (ýnput=="pause")
        {
            Pause.SetActive(true);
            Time.timeScale = 0;
        }
        else if (ýnput == "resume")
        {
            Pause.SetActive(false);
            Time.timeScale = 1;
        }
        else if (ýnput == "menu")
        {
            SceneManager.LoadScene(0);
        }
        else if (ýnput == "quit")
        {
            Application.Quit();
        }
    }
}
