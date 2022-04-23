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
    public void pauseMenu(string �nput)
    {
        if (�nput=="pause")
        {
            Pause.SetActive(true);
            Time.timeScale = 0;
        }
        else if (�nput == "resume")
        {
            Pause.SetActive(false);
            Time.timeScale = 1;
        }
        else if (�nput == "menu")
        {
            SceneManager.LoadScene(0);
        }
        else if (�nput == "quit")
        {
            Application.Quit();
        }
    }
}
