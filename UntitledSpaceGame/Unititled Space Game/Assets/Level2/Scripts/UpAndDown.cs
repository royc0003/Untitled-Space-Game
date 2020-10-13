using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDown : MonoBehaviour
{
    public float Ymin=2f;
    public float Ymax=3f;
    public float speed = 15f;
    public float startTime = 0f;
    public float displacement = 15f;
    // Use this for initialization
    void Start () {
       
        Ymin=transform.position.y-displacement;
        Ymax=transform.position.y;
    }
    // Update is called once per frame
    void Update () {
        transform.position =new Vector3(transform.position.x , Mathf.PingPong((Time.time+startTime)*speed, Ymax-Ymin)+Ymin, transform.position.z);  
    }
}