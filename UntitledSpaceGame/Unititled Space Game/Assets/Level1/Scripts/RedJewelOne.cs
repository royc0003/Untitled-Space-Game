using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedJewelOne : MonoBehaviour
{
    public Light TopGlow;
    public Light BottomGlow;
    public GameObject barrier;
    public GameObject redJewelPrompt;

    public float on = 2.5f;
    public float off = 0f;

    bool inTrigger = false;

    void Start()
    {
        redJewelPrompt.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && inTrigger)
        {
            if(TopGlow.range == on)
            {
                Deactivate();
            }
            else if(TopGlow.range == off)
            {
                Activate();
            }

            
        }
    }

    void OnTriggerEnter(Collider other)
    {   
        inTrigger = true;
        redJewelPrompt.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {   
        inTrigger = false;
        redJewelPrompt.SetActive(false);
    }

    void Activate()
    {
        TopGlow.range = on;
        BottomGlow.range = on;
        barrier.GetComponent<Renderer>().enabled = true;
        barrier.GetComponent<Collider>().enabled = true;
    }

    void Deactivate()
    {   
        TopGlow.range = off;
        BottomGlow.range = off;
        barrier.GetComponent<Renderer>().enabled = false;
        barrier.GetComponent<Collider>().enabled = false;
    }
}
