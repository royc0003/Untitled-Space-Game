using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cutscene3 : MonoBehaviour
{
    public Button button;
    public GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        UI.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        button.onClick.AddListener(NextScene);
    }
    
    public void NextScene()
    {
        SceneManager.LoadScene("Cutscene4");
    }
}
