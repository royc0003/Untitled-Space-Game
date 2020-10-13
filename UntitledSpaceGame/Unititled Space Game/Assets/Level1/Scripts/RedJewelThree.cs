using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedJewelThree : MonoBehaviour
{
    public Light TopGlow1;
    public Light BottomGlow1;
    public Light TopGlow2;
    public Light BottomGlow2;
    public GameObject bridge;
    public GameObject barrier1;
    public GameObject barrier2;
    public GameObject barrier3;
    public float lowestY;
    public float highestY;

    Vector3 YDisplacement = new Vector3(0,0.3f,0);

    public float on = 2.5f;
    public float off = 0f;

    bool inTrigger = false;

    void Start()
    {
        TopGlow1.range = off;
        BottomGlow1.range = off;
        TopGlow2.range = off;
        BottomGlow2.range = off;

        lowestY = bridge.transform.position.y;
        bridge.transform.position += YDisplacement;
        highestY = bridge.transform.position.y;

        barrier1.GetComponent<Renderer>().enabled = false;
        barrier1.GetComponent<Collider>().enabled = false;
        barrier2.GetComponent<Renderer>().enabled = false;
        barrier2.GetComponent<Collider>().enabled = false;
        barrier3.GetComponent<Renderer>().enabled = false;
        barrier3.GetComponent<Collider>().enabled = false;
    }

    void Update()
    {   
        if(TopGlow1.range == on)
        {
            if(bridge.transform.position.y > lowestY) {bridge.transform.Translate(0, -Time.deltaTime/1.5f, 0, Space.World);}
            if(Input.GetKeyDown(KeyCode.F) && inTrigger)
            {
                Deactivate();
            }          
        }
        else if(TopGlow1.range == off)
        {   
            if(bridge.transform.position.y < highestY) {bridge.transform.Translate(0, Time.deltaTime/1.5f, 0, Space.World);}
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
        TopGlow1.range = on;
        BottomGlow1.range = on;
        TopGlow2.range = on;
        BottomGlow2.range = on;
        barrier1.GetComponent<Renderer>().enabled = true;
        barrier1.GetComponent<Collider>().enabled = true;
        barrier2.GetComponent<Renderer>().enabled = true;
        barrier2.GetComponent<Collider>().enabled = true;
        barrier3.GetComponent<Renderer>().enabled = true;
        barrier3.GetComponent<Collider>().enabled = true;
    }

    void Deactivate()
    {   
        TopGlow1.range = off;
        BottomGlow1.range = off;
        TopGlow2.range = off;
        BottomGlow2.range = off;
        barrier1.GetComponent<Renderer>().enabled = false;
        barrier1.GetComponent<Collider>().enabled = false;
        barrier2.GetComponent<Renderer>().enabled = false;
        barrier2.GetComponent<Collider>().enabled = false;
        barrier3.GetComponent<Renderer>().enabled = false;
        barrier3.GetComponent<Collider>().enabled = false;
    }
}
