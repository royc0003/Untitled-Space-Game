using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cutscene3 : MonoBehaviour
{
    public Button button;
    public GameObject UI;
    public Animator animatorFuel;
    // Start is called before the first frame update
    void Start()
    {
        animatorFuel.SetBool("pour",false);
        UI.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        button.onClick.AddListener(NextScene);
    }
    

    public void NextScene() {
        button.gameObject.SetActive(false);
        animatorFuel.SetBool("pour",true);
        Invoke("LoadNextScene",3.0f);
        return;
        
    }
    public void LoadNextScene() {
        SceneManager.LoadScene("Cutscene4");
    }
    
}
