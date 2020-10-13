using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public string nextScene;

    public GameObject startMenuUI;
    //public GameObject otherPrompts;

    void Start()
    {
        startMenuUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Play()
    {
        SceneManager.LoadScene(nextScene);
    }
}
