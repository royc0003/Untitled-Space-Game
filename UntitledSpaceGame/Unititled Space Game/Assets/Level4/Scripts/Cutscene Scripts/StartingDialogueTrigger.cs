using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class StartingDialogueTrigger : MonoBehaviour
{
    public StartingDialogue dialogue;
    public GameObject timeline;
    public GameObject textScene;
    private bool started;

    void Start() {
        started = false;
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<StartingDialogueManager>().StartDialogue(dialogue);
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
