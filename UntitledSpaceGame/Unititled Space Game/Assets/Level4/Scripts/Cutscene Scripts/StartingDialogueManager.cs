using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartingDialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public Text dialogueText;
    public Animator animatorText;
    public Animator animatorCharacter;
    public Button button;
    private int currentId;
    public GameObject myFace;
    public GameObject friendFace;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        button.onClick.AddListener(DisplayNextSentence);
        currentId = 1;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void StartDialogue(StartingDialogue dialogue)
    {
        Invoke("ChangeValueOfOpenToTrue",12f);
        
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
            animatorCharacter.SetBool("expand", true);
            Invoke("EndDialogue", 3f);
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
        switch (currentId) {
            case 1:
                myFace.SetActive(true);
                friendFace.SetActive(false);
                currentId++;
                break;
            case 2:
                myFace.SetActive(false);
                friendFace.SetActive(true);
                currentId--;
                break;
        }
    }

    public void ChangeValueOfOpenToTrue()
    {
        animatorText.SetBool("IsOpen", true);
    }

    public void EndDialogue()
    {
        SceneManager.LoadScene("Level4");
    }

}
