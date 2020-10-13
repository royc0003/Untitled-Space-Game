using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueJewelOne : MonoBehaviour
{
    public Light TopGlow;
    public Light BottomGlow;
    public GameObject bridge;
    public float lowestY;
    public float highestY;
    public GameObject blueJewelPrompt;

    Vector3 YDisplacement = new Vector3(0,0.3f,0);

    public float on = 2.5f;
    public float off = 0f;

    bool inTrigger = false;

    void Start()
    {
        lowestY = bridge.transform.position.y;
        bridge.transform.position += YDisplacement;
        highestY = bridge.transform.position.y;
        TopGlow.range = off;
        BottomGlow.range = off;
        blueJewelPrompt.SetActive(false);
    }

    void Update()
    {   
        if(TopGlow.range == on)
        {
            if(bridge.transform.position.y > lowestY) {bridge.transform.Translate(0, -Time.deltaTime/1.5f, 0, Space.World);} 
            if(Input.GetKeyDown(KeyCode.F) && inTrigger)
            {
                Deactivate();
            }          
        }
        else if(TopGlow.range == off)
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
        blueJewelPrompt.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {   
        inTrigger = false;
        blueJewelPrompt.SetActive(false);
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
