using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cutscene1 : MonoBehaviour
{
    public Button button;
    public Animator animatorChar;
    public Animator animatorText;
    // Start is called before the first frame update
    void Start()
    {
        animatorChar.SetBool("suck",false);
        button.onClick.AddListener(NextScene);
    }

    public void NextScene() {
        //animatorText.SetBool("close",true);
        animatorChar.SetBool("suck",true);
        Invoke("LoadNextScene",3.0f);
        return;
        
    }
    public void LoadNextScene() {
        SceneManager.LoadScene("Cutscene2");
    }
    
}
