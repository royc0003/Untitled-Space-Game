using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public enum rotationAxis{
        x,
        y,
        z
    }
    

    public float maxRotationAngle;
    public float periodT;
    float mytime;
    public rotationAxis rotation;


    // Update is called once per frame
    void Update()
    {
        if(rotation == rotationAxis.x){ //Check if x axis rotating
            mytime += Time.deltaTime;
            float phase = Mathf.Sin(mytime / periodT);
            transform.localRotation = Quaternion.Euler(new Vector3 (phase * maxRotationAngle, 0, 0));
        }

        else if(rotation == rotationAxis.y){
            mytime += Time.deltaTime;
            float phase = Mathf.Sin(mytime / periodT);
            transform.localRotation = Quaternion.Euler(new Vector3(0, phase * maxRotationAngle, 0));
        }

        else if(rotation == rotationAxis.z){
            mytime += Time.deltaTime;
            float phase = Mathf.Sin(mytime / periodT);
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, phase * maxRotationAngle));
        }
    }
}
