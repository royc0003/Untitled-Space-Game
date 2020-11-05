using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cutscene3 : MonoBehaviour
{
    public Button button;
    public Animator animatorCamera;
    // Start is called before the first frame update
    void Start()
    {
        animatorCamera.SetBool("move",false);
        button.onClick.AddListener(NextScene);
    }

    public void NextScene() {
        button.gameObject.SetActive(false);
        animatorCamera.SetBool("move",true);
        Invoke("LoadNextScene",4.0f);
        return;
    }

    public void LoadNextScene() {
        SceneManager.LoadScene("Level1A");
    }
}
