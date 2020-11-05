using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public string currentStage;
    public bool lockEnabled;

    public GameObject pauseMenuUI;
    //public GameObject otherPrompts;

    void Start()
    {
        pauseMenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            // if(GameIsPaused)
            // {
            //     Resume();
            // }
            Pause();
        }

    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        if(lockEnabled){Screen.lockCursor = true;}
       
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        Resume();
        SceneManager.LoadScene(currentStage);
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Screen.lockCursor = false;
        //otherPrompts.SetActive(false);
    }
}
