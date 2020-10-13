using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{   
    public AudioClip AudioClip;
    AudioSource AudioSource;
    bool inTrigger = false;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && inTrigger)
        {
            AudioSource.PlayOneShot(AudioClip, 0.7f);
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
