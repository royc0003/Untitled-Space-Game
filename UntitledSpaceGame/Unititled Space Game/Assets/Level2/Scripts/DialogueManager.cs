using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DialogueManager : MonoBehaviour
{
    //public Text nameText;
    public Text dialogueText;
    public Animator animator;
    public static Queue<string> sentences; //Put sentences into queue, load each word at the end of queue
    public GameObject button;
    public string sceneToLoad;

    void Start()
    {
        sentences = new Queue<string>();
        animator.SetBool("IsOpen", true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void StartDialogue (Dialogue dialogue){

        button.SetActive(false);
        animator.SetBool("IsOpen", true);

        Debug.Log("Start cutscene");
        
        //nameText.text = dialogue.name;
        
        sentences.Clear();

        foreach(string sentence in dialogue.sentences){
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence(){
        if(sentences.Count == 0){
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        Debug.Log(sentence);
    }

    IEnumerator TypeSentence(string sentence){
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray()){
            dialogueText.text += letter; //Append each letter to the end of string
            yield return null;
        }
    }

    void EndDialogue(){
        
        animator.SetBool("IsOpen", false);
        Debug.Log("End of conversation");
        SceneManager.LoadScene(sceneToLoad);
    }

}
