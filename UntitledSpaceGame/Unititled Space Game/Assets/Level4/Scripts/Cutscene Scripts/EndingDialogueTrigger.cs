using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class EndingDialogueTrigger : MonoBehaviour
{
    public EndingDialogue dialogue;
    public GameObject timeline;
    public GameObject textScene;
    private bool started;

    void Start() {
        started = false;
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<EndingDialogueManager>().StartDialogue(dialogue);
    }

    void Update() {
        if (timeline.GetComponent<PlayableDirector>().state != PlayState.Playing && !started)
        {   
            TriggerDialogue();
            textScene.SetActive(true);
            started = true;
        }
    }
}
