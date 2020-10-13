using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{   
    public float lifeTime = 15.0f;
    // Update is called once per frame
    void Update()
    {
        if(lifeTime > 0){
            lifeTime -= Time.deltaTime; //Decrease lifetime if lifetime > 0

            if(lifeTime <= 0){
                Destruction();
            }
        }

        if(this.transform.position.y <= -20){ //If the object goes way off screen
            Destruction();
        }
    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.name == "destroyer"){
            Destruction();
        }
    }

    void Destruction(){
        Destroy(this.gameObject);
    }
}
