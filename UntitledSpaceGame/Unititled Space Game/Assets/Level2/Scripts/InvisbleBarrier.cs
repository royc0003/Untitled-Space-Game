using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisbleBarrier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerManager.enemiesLeft == 4)
        {
            FindObjectOfType<AudioManager>().Play("Background1");
            FindObjectOfType<AudioManager>().StopPlaying("Background2");
            gameObject.active = false;
        }
    }
}
