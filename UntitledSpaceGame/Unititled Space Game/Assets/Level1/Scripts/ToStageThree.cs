using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToStageThree : MonoBehaviour
{
    bool inTrigger = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && inTrigger)
        {
            SceneManager.LoadScene("Level1C");
        }
    }

    void OnTriggerEnter(Collider other)
    {   
        inTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {   
        inTrigger = false;
    }
}
