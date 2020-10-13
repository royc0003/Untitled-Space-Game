using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingStart : MonoBehaviour
{
    public GameObject nextPlatform;
    public GameObject wallFront;
    public GameObject wallFrontDup;
    public float lowestY;
    public float highestY;

    public Light thislight;

    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;
    public Light light5;
    public Light light6;
    public Light light7;
    public Light light8;
    public Light light9;
    public Light light10;
    public Light light11;
    public Light light12;
    public Light light13;
    public Light light14;
    public Light light15;
    public Light light16;
    public Light light17;
    public Light light18;
    public Light myLight;


    Vector3 YDisplacement = new Vector3(0,0.5f,0);

    bool inTrigger = false;

    // Start is called before the first frame update
    void Start()
    {
        nextPlatform.GetComponent<Collider>().enabled = false;
        nextPlatform.GetComponent<Renderer>().enabled = false;
        wallFront.GetComponent<Collider>().enabled = true;
        wallFrontDup.GetComponent<Collider>().enabled = false;

        highestY = nextPlatform.transform.position.y;
        nextPlatform.transform.position -= YDisplacement;
        lowestY = nextPlatform.transform.position.y;

        myLight.range = 0f;
        thislight.intensity = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        if(inTrigger)
        {   
            if(nextPlatform.transform.position.y < highestY) 
            {
                nextPlatform.GetComponent<Collider>().enabled = true;
                nextPlatform.GetComponent<Renderer>().enabled = true;
                nextPlatform.transform.Translate(0, Time.deltaTime/(0.8f), 0, Space.World);
            }
            else
            {
                nextPlatform.transform.position = new Vector3(nextPlatform.transform.position.x,highestY,nextPlatform.transform.position.z);
            }
            if(nextPlatform.transform.position.y >= highestY)
            {
                wallFront.GetComponent<Collider>().enabled = false;
            }
            
            if(light1.range > 0f || light8.intensity > 0f || light9.intensity > 0f  ){
                light1.range -= 0.1f;
                light2.range -= 0.1f;
                light3.range -= 0.1f;
                light4.range -= 0.1f;
                light5.range -= 0.1f;
                light6.range -= 0.1f;
                light7.range -= 0.1f;
                light10.range -= 0.1f;
                light11.range -= 0.1f;
                light12.range -= 0.1f;
                light13.range -= 0.1f;
                light14.range -= 0.1f;
                light15.range -= 0.1f;
                light16.range -= 0.1f;
                light17.range -= 0.1f;
                light18.range -= 0.1f;
                light8.intensity -= 0.05f;
                light9.intensity -= 0.05f;
            }
            
            if(myLight.range < 5f){myLight.range += 0.2f; thislight.intensity += 0.008f;}
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
