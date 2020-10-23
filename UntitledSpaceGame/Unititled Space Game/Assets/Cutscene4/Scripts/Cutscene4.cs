using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cutscene4 : MonoBehaviour
{
    public Button button;
    public Animator animatorCamera;
    // Start is called before the first frame update
    void Start()
    {
        animatorCamera.SetBool("camera_move",false);
        button.onClick.AddListener(NextScene);
    }
    
    public void NextScene() {
        button.gameObject.SetActive(false);
        animatorCamera.SetBool("camera_move",true);
        Invoke("LoadNextScene",3.5f);
        return;
        
    }
    public void LoadNextScene() {
        SceneManager.LoadScene("Level4Start");
    }
}
