using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPrompt : MonoBehaviour
{   
    public GameObject startPrompt;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        startPrompt.SetActive(true);
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {   
        timer = timer + Time.deltaTime;
        if(timer > 7f){startPrompt.SetActive(false);}
    }
}
