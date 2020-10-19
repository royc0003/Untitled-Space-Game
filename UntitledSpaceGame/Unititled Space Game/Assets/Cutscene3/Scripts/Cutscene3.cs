using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cutscene3 : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(NextScene);
    }

    public void NextScene() {
        Invoke("LoadNextScene",3.0f);
        return;
        
    }
    public void LoadNextScene() {
        SceneManager.LoadScene("Cutscene2");
    }
    
}
