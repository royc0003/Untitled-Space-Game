using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingSecLast : MonoBehaviour
{   
    public GameObject prevPlatform;
    //public GameObject nextPlatform;
    public GameObject wallFront;
    public GameObject wallFrontDup;
    public GameObject wallBehind;
    public float lowestY;
    public float highestY;
    public Light myLight;
    public Light yourLight;

    Vector3 YDisplacement = new Vector3(0,0.5f,0);

    bool inTrigger = false;

    // Start is called before the first frame update
    void Start()
    {
        //nextPlatform.GetComponent<Collider>().enabled = false;
        //nextPlatform.GetComponent<Renderer>().enabled = false;
        wallFront.GetComponent<Collider>().enabled = true;
        //highestY = nextPlatform.transform.position.y;
        //nextPlatform.transform.position -= YDisplacement;
        //lowestY = nextPlatform.transform.position.y;
        myLight.range = 0f;
        wallFrontDup.GetComponent<Collider>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        // if(nextPlatform.transform.position.y >= highestY)
        // {
             wallFront.GetComponent<Collider>().enabled = false;
        // }

        if(inTrigger)
        {   
            wallBehind.GetComponent<Collider>().enabled = true;
            wallFront.GetComponent<Collider>().enabled = false;
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
            if(myLight.range<5f){myLight.range += 0.2f;}
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
