using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndingScene : MonoBehaviour
{
    public Animator animatorText;
    public GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        animatorText.SetBool("scroll",true);
        Invoke("LoadNextScene",22.0f);
    }
    
    public void LoadNextScene() {
        SceneManager.LoadScene("Main Screen");
    }
}
