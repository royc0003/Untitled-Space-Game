using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene3DialogueTrigger : MonoBehaviour
{
    public Cutscene3Dialogue dialogue;
    public GameObject textScene;

    // Start is called before the first frame update
    void Start()
    {
        textScene.SetActive(true);
        FindObjectOfType<Cutscene3>().StartDialogue(dialogue);
    }
}
