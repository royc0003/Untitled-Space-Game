using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenJewelFour : MonoBehaviour
{
    public Light TopGlow1;
    public Light BottomGlow1;
    public Light TopGlow2;
    public Light BottomGlow2;
    public Light TopGlow3;
    public Light BottomGlow3;
    public GameObject bridge;
    public GameObject barrier;
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
        TopGlow3.range = off;
        BottomGlow3.range = off;

        lowestY = bridge.transform.position.y;
        bridge.transform.position += YDisplacement;
        highestY = bridge.transform.position.y;

        barrier.GetComponent<Renderer>().enabled = false;
        barrier.GetComponent<Collider>().enabled = false;
    }

    void Update()
    {   
        if(TopGlow1.range == on)
        {
            if(bridge.transform.position.y > lowestY) 
            {
                bridge.transform.Translate(0, -Time.deltaTime/1.5f, 0, Space.World);
            }
            if(Input.GetKeyDown(KeyCode.F) && inTrigger)
            {
                Deactivate();
            }          
        }
        else if(TopGlow1.range == off)
        {   
            if(bridge.transform.position.y < highestY) 
            {
                bridge.transform.Translate(0, Time.deltaTime/1.5f, 0, Space.World);
            }
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
        TopGlow3.range = on;
        BottomGlow3.range = on;
        barrier.GetComponent<Renderer>().enabled = true;
        barrier.GetComponent<Collider>().enabled = true;
    }

    void Deactivate()
    {   
        TopGlow1.range = off;
        BottomGlow1.range = off;
        TopGlow2.range = off;
        BottomGlow2.range = off;
        TopGlow3.range = off;
        BottomGlow3.range = off;
        barrier.GetComponent<Renderer>().enabled = false;
        barrier.GetComponent<Collider>().enabled = false;
    }
}