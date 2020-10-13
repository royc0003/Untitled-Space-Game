using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToCutScene : MonoBehaviour
{
     bool inTrigger = false;
     public GameObject interactPrompt;
     public AudioSource bgm;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && inTrigger)
        {   
            SceneManager.LoadScene("cs1");
        }
    }

    void OnTriggerEnter(Collider other)
    {   
        inTrigger = true;
        interactPrompt.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {   
        inTrigger = false;
        interactPrompt.SetActive(false);
    }
}
