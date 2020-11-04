using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cutscene6 : MonoBehaviour
{
    public Button button;
    public Animator animatorCam;
    public GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        animatorCam.SetBool("camera_move",false);
        button.onClick.AddListener(NextScene);
    }
    
    public void NextScene() {
        UI.gameObject.SetActive(false);
        animatorCam.SetBool("camera_move",true);
        Invoke("LoadNextScene",7.0f);
        return;
        
    }
    public void LoadNextScene() {
        SceneManager.LoadScene("EndingScene");
    }
}
