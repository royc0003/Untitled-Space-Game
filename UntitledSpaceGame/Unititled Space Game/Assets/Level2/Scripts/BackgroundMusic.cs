using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public int area = 1;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player" && area == 1)
        {
            FindObjectOfType<AudioManager>().Play("Background1");
        }

        if (collider.gameObject.tag == "Player" && area == 2)
        {
            FindObjectOfType<AudioManager>().Play("Background2");
            FindObjectOfType<AudioManager>().StopPlaying("Background1");
        }

        if (collider.gameObject.tag == "Player" && area == 3)
        {
            FindObjectOfType<AudioManager>().Play("Background3");
            FindObjectOfType<AudioManager>().Play("Siren");
            FindObjectOfType<AudioManager>().StopPlaying("Background1");
        }
    }

}
