using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingLast : MonoBehaviour
{   
    public GameObject prevPlatform;
    public GameObject prevPlatformDup;
    //public GameObject nextPlatform;
    //public GameObject wallFront;
    //public GameObject wallFrontDup;
    public GameObject wallBehind;
    public float lowestY;
    public float highestY;
    public Light myLight1;
    public Light myLight2;
    public Light myLight3;
    public Light myLight4;
    public Light myLight5;
    public Light myLight6;
    public Light yourLight;

    Vector3 YDisplacement = new Vector3(0,0.5f,0);

    bool inTrigger = false;

    // Start is called before the first frame update
    void Start()
    {
        //nextPlatform.GetComponent<Collider>().enabled = false;
        //nextPlatform.GetComponent<Renderer>().enabled = false;
        //wallFront.GetComponent<Collider>().enabled = true;
        highestY = prevPlatformDup.transform.position.y;
        prevPlatformDup.transform.position -= YDisplacement;
        lowestY = prevPlatformDup.transform.position.y;
        myLight1.range = 0f;
        myLight2.range = 0f;
        myLight3.range = 0f;
        myLight4.range = 0f;
        myLight5.range = 0f;
        myLight6.range = 0f;
        //wallFrontDup.GetComponent<Collider>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        // if(nextPlatform.transform.position.y >= highestY)
        // {
             //wallFront.GetComponent<Collider>().enabled = false;
        // }

        if(inTrigger)
        {   
            wallBehind.GetComponent<Collider>().enabled = true;
            //wallFront.GetComponent<Collider>().enabled = false;
            //if(nextPlatform.transform.position.y < highestY) 
            //{
                //nextPlatform.GetComponent<Collider>().enabled = true;
                //nextPlatform.GetComponent<Renderer>().enabled = true;
                //nextPlatform.transform.Translate(0, Time.deltaTime, 0, Space.World);
            //}
            // else
            // {
            //     nextPlatform.transform.position = new Vector3(nextPlatform.transform.position.x,highestY,nextPlatform.transform.position.z);
            // }
            if(prevPlatform.transform.position.y > lowestY) 
            {   
                prevPlatform.transform.Translate(0, -Time.deltaTime/(0.8f), 0, Space.World);
            }
            if(prevPlatform.transform.position.y <= lowestY)
            {
                prevPlatform.GetComponent<Renderer>().enabled = false;
                prevPlatform.GetComponent<Collider>().enabled = false;
            }
            if(myLight1.range<5f)
            {
                myLight1.range += 0.1f;
                myLight2.range += 0.1f;
                myLight3.range += 0.1f;
                myLight4.range += 0.1f;
                myLight5.range += 0.1f;
                myLight6.range += 0.1f;
            }
            if(yourLight.range > 0f){yourLight.range -= 0.3f;}

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

