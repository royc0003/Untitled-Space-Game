using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeObject : MonoBehaviour
{
 
// Then assign a new vector3
    public GameObject Player;

    private void OnTriggerEnter(Collider other){
        
        if(other.gameObject == Player){

            Debug.Log("TOUCH");

            float x = gameObject.transform.position.x * Mathf.Sin(Time.time * .1f) * .1f;
            float y = gameObject.transform.position.y;
            float z = gameObject.transform.position.z;
            
            gameObject.transform.position = new Vector3 (x, y, z);
        }
        
    }

    // Vector3 startingPos;

    // void Awake () {
    //     startingPos.x = transform.position.x;
    //     startingPos.y = transform.position.y;
    //     startingPos.z = transform.position.z;
    // }

    // // Update is called once per frame
    // void Update () {

    //     gameObject.transform.position.x = startingPos.x + (Mathf.Sin(Time.time * speed) * amount);

    //     gameObject.transform.position.y = startingPos.y + (Mathf.Sin(Time.time * speed) * amount);

    //     gameObject.transform.position.z = startingPos.z + (Mathf.Sin(Time.time * speed) * amount); 

    // }


    
}
