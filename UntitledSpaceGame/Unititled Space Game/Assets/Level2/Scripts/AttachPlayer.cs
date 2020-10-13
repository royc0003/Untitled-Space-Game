using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPlayer : MonoBehaviour
{
    public GameObject Player;
    public GameObject Platform;
    
    private void OnTriggerEnter(Collider collider) 
     {
         if(collider.gameObject.tag == "Player")
         {
            
            Debug.Log("Collide");
            Player.transform.parent = Platform.transform;
            //GameObject.FindWithTag("Player").transform.parent = transform;
         }
     
     }

     private void OnTriggerExit(Collider collider) 
     {
         if(collider.gameObject == Player)
         {
             Player.transform.parent = null;
         }
     }
}
