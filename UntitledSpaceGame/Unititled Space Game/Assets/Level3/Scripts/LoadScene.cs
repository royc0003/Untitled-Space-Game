using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void loadScene(int index)
    {

        UnityEngine.SceneManagement.SceneManager.LoadScene(index);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
