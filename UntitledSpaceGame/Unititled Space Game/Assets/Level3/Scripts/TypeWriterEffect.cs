using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TypeWriterEffect : MonoBehaviour
{
    public float delay = 0.1f;
    public string fullText;
    private string currentText = "";
    private AudioSource type;

    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        type = GetComponent<AudioSource>();
        


        StartCoroutine(showText());



    }

    IEnumerator showText()
    {
        Debug.Log(fullText.Length);
        for(int i=0; i<fullText.Length+1; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
            if(System.String.Compare(fullText[i].ToString(), " ") == 0)
            {

            }
            else
            {
                type.Play();

            }
     
            
        }

    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("current" + currentText.Length);
        Debug.Log("total" + fullText.Length);
        if(currentText.Length == fullText.Length)
        {
            Animator anim = panel.GetComponent<Animator>();
            anim.SetBool("appear", true);
        }

    }
}
