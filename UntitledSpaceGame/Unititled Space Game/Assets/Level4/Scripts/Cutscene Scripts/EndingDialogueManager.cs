using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EndingDialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public Text dialogueText;
    public Animator animatorText;
    public Button button;
    private int currentId;
    public GameObject myFace;
    public Camera firstPersonCamera;
    public Camera sceneCamera;
    public GameObject UI1;
    public GameObject UI2;

    // Start is called before the first frame update
    void Start()
    {
        UI1.SetActive(true);
        UI2.SetActive(false);
        firstPersonCamera.gameObject.SetActive(false);
        sceneCamera.gameObject.SetActive(true);
        sentences = new Queue<string>();
        button.onClick.AddListener(DisplayNextSentence);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }

    public void StartDialogue(EndingDialogue dialogue)
    {
        animatorText.SetBool("IsOpen", true);
        
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            animatorText.SetBool("IsOpen", false);
            Invoke("EndDialogue",0.1f);
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        showFace();
    }

    IEnumerator TypeSentence(string sentence) {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray()){
            dialogueText.text += letter;
            yield return null;
        }
    }

    public void showFace() {
        myFace.SetActive(true);
    }

    public void EndDialogue()
    {
        UI1.SetActive(false);
        firstPersonCamera.gameObject.SetActive(true);
        sceneCamera.gameObject.SetActive(false);
        UI2.SetActive(true);
    }
}