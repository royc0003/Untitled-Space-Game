using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractPrompt : MonoBehaviour
{
    public GameObject interactPrompt;
    // Start is called before the first frame update
    void Start()
    {
        interactPrompt.SetActive(false);
    }

    // Update is called once per frame
    // void Update()
    // {

    // }

    void OnTriggerEnter(Collider other)
    {
        interactPrompt.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        interactPrompt.SetActive(false);
    }
}
