using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPanning : MonoBehaviour
{   

    public GameObject camera;
    public GameObject player;
    public GameObject frenemy;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<PlayerMovement>().enabled = false;
        GetComponent<CharacterController>().enabled = false;
        player.GetComponent<Renderer>().enabled = false;
        frenemy.GetComponent<Renderer>().enabled = false;
        timer = 0f;

    }

    // Update is called once per frame
    void Update()
    {   
        timer = timer + Time.deltaTime;
        if(camera.transform.position.z > -1.5 && timer > 3f)
        {
            camera.transform.Translate(0, 0, -Time.deltaTime/0.2f, Space.World);
        }
        if(camera.transform.position.z <= -1.5)
        {
            GetComponent<PlayerMovement>().enabled = true;
            GetComponent<CharacterController>().enabled = true;
            player.GetComponent<Renderer>().enabled = true;
            frenemy.GetComponent<Renderer>().enabled = true;
        }
    }
}
