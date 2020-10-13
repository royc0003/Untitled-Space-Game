using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueJewelTwo : MonoBehaviour
{
    public Light TopGlow;
    public Light BottomGlow;
    public GameObject bridge1;
    public GameObject bridge2;
    public float lowestY;
    public float highestY;

    Vector3 YDisplacement = new Vector3(0,0.3f,0);

    public float on = 2.5f;
    public float off = 0f;

    bool inTrigger = false;

    void Start()
    {
        lowestY = bridge1.transform.position.y;
        bridge1.transform.position += YDisplacement;
        bridge2.transform.position += YDisplacement;
        highestY = bridge1.transform.position.y;
        TopGlow.range = off;
        BottomGlow.range = off;
    }

    void Update()
    {   
        if(TopGlow.range == on)
        {
            if(bridge1.transform.position.y > lowestY) 
            {
                bridge1.transform.Translate(0, -Time.deltaTime/1.5f, 0, Space.World);
                bridge2.transform.Translate(0, -Time.deltaTime/1.5f, 0, Space.World);
            }
            if(Input.GetKeyDown(KeyCode.F) && inTrigger)
            {
                Deactivate();
            }          
        }
        else if(TopGlow.range == off)
        {   
            if(bridge1.transform.position.y < highestY) 
            {
                bridge1.transform.Translate(0, Time.deltaTime/1.5f, 0, Space.World);
                bridge2.transform.Translate(0, Time.deltaTime/1.5f, 0, Space.World);
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
        TopGlow.range = on;
        BottomGlow.range = on;
    }

    void Deactivate()
    {   
        TopGlow.range = off;
        BottomGlow.range = off;
    }
}
