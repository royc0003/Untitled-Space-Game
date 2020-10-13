using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToStageTwo : MonoBehaviour
{
    bool inTrigger = false;
    public GameObject portalPrompt;

    void Start()
    {
        portalPrompt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && inTrigger)
        {
            SceneManager.LoadScene("Level1B");
        }
    }

    void OnTriggerEnter(Collider other)
    {   
        inTrigger = true;
        portalPrompt.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {   
        inTrigger = false;
        portalPrompt.SetActive(false);
    }
}
