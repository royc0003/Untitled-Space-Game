using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrenemyFollow : MonoBehaviour
{
    public GameObject frenemyTrapped;
    public GameObject frenemyFollow;

    bool inTrigger = false;

    void Start()
    {
        frenemyTrapped.GetComponent<Renderer>().enabled = true;
        frenemyFollow.GetComponent<Renderer>().enabled = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && inTrigger)
        {
            frenemyTrapped.GetComponent<Renderer>().enabled = false;
            frenemyFollow.GetComponent<Renderer>().enabled = true;        
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
