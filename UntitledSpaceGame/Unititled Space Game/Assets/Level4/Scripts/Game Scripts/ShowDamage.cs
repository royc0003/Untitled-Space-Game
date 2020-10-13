using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowDamage : MonoBehaviour
{
    [SerializeField] Canvas impactCanvas;
    [SerializeField] float impactTime = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        impactCanvas.enabled = false;

        
    }
    public void ShowDamageImpact(){
        StartCoroutine(ShowPlatter());
    }

    IEnumerator ShowPlatter()
    {
                impactCanvas.enabled = true;

        yield return new WaitForSeconds(impactTime);
                impactCanvas.enabled = false;

    }
}
