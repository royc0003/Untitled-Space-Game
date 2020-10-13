using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class DialogueTrigger2 : MonoBehaviour {
    public Dialogue2 d;
    public GameObject t;
    public GameObject textScene;
    private bool started;
    private Animator textAnimator;

    void Start() {
        started = false;
    }

    public void TriggerDialogue() {
        FindObjectOfType<DialogueManager2>().StartDialogue(d);
    }

    void Update() {
        if (t.GetComponent<PlayableDirector>().state != PlayState.Playing && !started)
        {   
            TriggerDialogue();
            textScene.SetActive(true);
            textAnimator = textScene.GetComponent<Animator>();
            textAnimator.Play("DialogueIn");
            started = true;
        }
    }
}
