using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InAndOut : MonoBehaviour
{
    public float Zmin = 2f;
    public float Zmax = 3f;
    public float speed = 15f;
    public float startTime = 0f;
    public float displacement = 15f;
    // Use this for initialization
    void Start () {
    
        Zmin = transform.position.z-displacement;
        Zmax = transform.position.z;

    }
   
    // Update is called once per frame
    void Update () {
       
        transform.position =new Vector3(transform.position.x , transform.position.y, Mathf.PingPong((Time.time+startTime)*speed,Zmax-Zmin)+Zmin);
       
    }
}
