using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrenemyFollow : MonoBehaviour
{
    public GameObject frenemyTrapped;
    public GameObject frenemyFollow;
    public GameObject helpText;

    bool inTrigger = false;

    void Start()
    {
        frenemyTrapped.GetComponent<Renderer>().enabled = true;
        frenemyFollow.GetComponent<Renderer>().enabled = false;
        helpText.GetComponent<Renderer>().enabled = true;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && inTrigger)
        {
            frenemyTrapped.GetComponent<Renderer>().enabled = false;
            frenemyFollow.GetComponent<Renderer>().enabled = true; 
            helpText.GetComponent<Renderer>().enabled = false;  
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
