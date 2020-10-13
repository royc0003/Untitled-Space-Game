using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowJewelFour : MonoBehaviour
{
    public Light TopGlow;
    public Light BottomGlow;
    public GameObject barrier1;
    public GameObject barrier2;

    public float on = 2.5f;
    public float off = 0f;

    bool inTrigger = false;

    void Start()
    {
        TopGlow.range = on;
        BottomGlow.range = on;

        barrier1.GetComponent<Renderer>().enabled = true;
        barrier1.GetComponent<Collider>().enabled = true;
        barrier2.GetComponent<Renderer>().enabled = true;
        barrier2.GetComponent<Collider>().enabled = true;
    }

    void Update()
    {   
        if(TopGlow.range == on)
        {
            if(Input.GetKeyDown(KeyCode.F) && inTrigger)
            {
                Deactivate();
            }          
        }
        else if(TopGlow.range == off)
        {   
            if(Input.GetKeyDown(KeyCode.F) && inTrigger)
            {
                Activate();
            }         
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

    void Activate()
    {
        TopGlow.range = on;
        BottomGlow.range = on;
        barrier1.GetComponent<Renderer>().enabled = true;
        barrier1.GetComponent<Collider>().enabled = true;
        barrier2.GetComponent<Renderer>().enabled = true;
        barrier2.GetComponent<Collider>().enabled = true;
    }

    void Deactivate()
    {   
        TopGlow.range = off;
        BottomGlow.range = off;
        barrier1.GetComponent<Renderer>().enabled = false;
        barrier1.GetComponent<Collider>().enabled = false;
        barrier2.GetComponent<Renderer>().enabled = false;
        barrier2.GetComponent<Collider>().enabled = false;
    }
}
