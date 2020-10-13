using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToStageFour : MonoBehaviour
{
    bool inTrigger = false;
    public GameObject frenemyTrapped;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && inTrigger && frenemyTrapped.GetComponent<Renderer>().enabled == false)
        {
            SceneManager.LoadScene("Level1D");
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