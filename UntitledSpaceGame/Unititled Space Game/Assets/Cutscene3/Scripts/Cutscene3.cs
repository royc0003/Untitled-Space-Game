using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cutscene3 : MonoBehaviour
{
    private Queue<string> sentences;
    public Button button;
    public Text dialogueText;
    public Animator animatorCamera;
    public Animator animatorText;
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
        animatorCamera.SetBool("move",false);
    }

    public void StartDialogue(Cutscene3Dialogue dialogue)
    {
        Invoke("ChangeValueOfOpenToTrue",0.5f);
        
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
            Invoke("EndDialogue", 0.5f);
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
        button.gameObject.SetActive(false);
        animatorCamera.SetBool("move",true);
        Invoke("LoadNextScene",4.0f);
        return;
    }

    public void LoadNextScene() {
        SceneManager.LoadScene("Start");
    }
}
