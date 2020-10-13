using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent( typeof(Collider) )]
public class RocketCollidingScript : MonoBehaviour
{
    public Camera playerCamera ; // Drag & Drop the camera of the player
    public Camera cutsceneCamera ; // Drag & Drop the camera used for the cutscene
    public Animator animatorRocket;
    
    private void OnTriggerEnter(Collider other)
    {
        playerCamera.gameObject.SetActive(false);
        cutsceneCamera.gameObject.SetActive(true);
        animatorRocket.SetBool("fly",true);
        Invoke("EndDialogue",10f);
        return;
    }

    public void EndDialogue()
    {
        //SceneManager.LoadScene("Level4");
    }
}
