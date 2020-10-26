using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Disable : MonoBehaviour
{
    
    public void BtnOnClick(string text) { 
        Text txt = transform.Find("Text").GetComponent<Text>();
        txt.text = text;

        //btn.SetActive(false);
        
    }

    public void DisableCamera(){
        Camera camera = gameObject.GetComponent<Camera>();
        camera.enabled = false;
    }

    public void EnableCamera(){
        Camera cam = gameObject.GetComponent<Camera>();
        GetComponent<Camera>().enabled = true;
    }
}
