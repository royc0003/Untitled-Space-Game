using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttach : MonoBehaviour
{
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Debug.Log("COLDIED");

            Player.transform.parent = transform;


        }
        else
        {
            Debug.Log("Collided but not player");
        }
    }
   
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == Player)
        {
            Debug.Log("EXited");           
            Player.transform.parent = null; 
        }
    }
}
