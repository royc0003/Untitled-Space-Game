using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer_2 : MonoBehaviour
{
    public float lifeTime = 20.0f;
    
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
    spawner_2 testObject = GetComponentInParent<spawner_2>();
    //error handling, incase never put as a childeren 
    if(testObject == null) return;
       bool spawnOnce = testObject.isSpawnOnce();
       
        if(lifeTime > 0){
            lifeTime -= Time.deltaTime;
            if(lifeTime <= 0){
                if(spawnOnce == true) return;
                    Destruction();
                
            }
        }
    }

    void Destruction(){
        //Debug.Log("I am bullet destroyed" + this.gameObject);
       //spawner_2 someObject = this.gameObject.GetComponentInParent<spawner_2>();
        Destroy(this.gameObject);
        //someObject.SpawnObject();
    }
}
