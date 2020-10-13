using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float lifeTime = 10.0f;
    public bool inWindZone = false;
    public GameObject windZone;

    Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
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

    private void FixedUpdate(){
        if(inWindZone){
            rb.AddForce(windZone.GetComponent<WindArea>().direction * windZone.GetComponent<WindArea>().strength);
        }
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "WindArea"){
            windZone = other.gameObject;
            inWindZone = true;
        }
    }

    void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "WindArea"){
            inWindZone = false;
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
