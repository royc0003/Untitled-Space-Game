using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    
    public GameObject vertical; //What I am obritting around
    public float speed = 100.0f; //Speed of orbit
    
    void Update()
    {
        OrbitAround(); 
    }

    void OrbitAround()
    {
        transform.RotateAround(vertical.transform.position, Vector3.up, speed * Time.deltaTime);
    }
}
