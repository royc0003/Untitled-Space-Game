using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalPromptC : MonoBehaviour
{
    public GameObject interactPrompt;
    public GameObject rescuePrompt;
    public GameObject frenemy;

    // Start is called before the first frame update
    void Start()
    {
        interactPrompt.SetActive(false);
        rescuePrompt.SetActive(false);
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }

    void OnTriggerEnter(Collider other)
    {
        if(frenemy.GetComponent<Renderer>().enabled){
            interactPrompt.SetActive(true);
        }
        else{
            rescuePrompt.SetActive(true);
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        interactPrompt.SetActive(false);
        rescuePrompt.SetActive(false);
    }
}
