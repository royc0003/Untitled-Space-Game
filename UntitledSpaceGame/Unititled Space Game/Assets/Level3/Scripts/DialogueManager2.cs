using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager2 : MonoBehaviour{
    private Queue<string> sentences;
    public Text text;
    public Button button;
    public int[] id;
    private int currendId;
    public GameObject myFace;
    public GameObject friendFace;
    public GameObject alienFace;

    void Start()
    {
        sentences = new Queue<string>();
       // button.gameObject.SetActive(false);
        button.onClick.AddListener(DisplayNextSentence);
        currendId = -1;
    }


    public void StartDialogue(Dialogue2 d){
        sentences.Clear();
        foreach(string sentence in d.sentences) {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence() {
        if (sentences.Count == 0){
            EndDialogue();
            return;
        }
        currendId++;
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        //button.gameObject.SetActive(false);
        StartCoroutine(TypeSentence(sentence));
        showFace();
        //button.gameObject.SetActive(true);
        //button.onClick.AddListener(DisplayNextSentence);

    }

    IEnumerator TypeSentence(string sentence) {
        button.gameObject.SetActive(false);

        text.text = "";
        foreach (char letter in sentence.ToCharArray()){
            text.text += letter;
            yield return null;
        }
        button.gameObject.SetActive(true);
    }

    public void EndDialogue() {
        SceneManager.LoadScene("Main");
    }

    public void showFace() {
        
        switch (id[currendId]) {
            case 1:
                Debug.Log(id[currendId]);
                myFace.SetActive(true);
                friendFace.SetActive(false);
                alienFace.SetActive(false);

                break;
            case 2:
                Debug.Log(id[currendId]);
                myFace.SetActive(false);
                friendFace.SetActive(true);
                alienFace.SetActive(false);

                break;

            case 3:
                Debug.Log(id[currendId]);
                myFace.SetActive(false);
                friendFace.SetActive(false);
                alienFace.SetActive(true);

                break;
        }
    }
}
