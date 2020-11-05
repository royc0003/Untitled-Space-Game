using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class EndSceneManager : MonoBehaviour {
    public Button button;
    public GameObject panel;
    public GameObject t;
    public bool finished;

    // Start is called before the first frame update
    void Start()
    {
        finished = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (t.GetComponent<PlayableDirector>().state != PlayState.Playing && finished)
        {
            SceneManager.LoadScene("Cutscene4");
        }
    }

    public void PlayEndScene() {
        Debug.Log("Play End Scene");
        panel.SetActive(false);
        t.GetComponent<PlayableDirector>().Play();
        finished = true;

    }
}
