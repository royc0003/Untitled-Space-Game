using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ToNextScene : MonoBehaviour
{
   public string nextSceneToLoad;

    // Start is called before the first frame update
    void Start()
    {
      // nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnTriggerEnter(Collider collider) {
        Debug.Log("triggered");
        SceneManager.LoadScene(nextSceneToLoad);
        //SceneManager.LoadScene("Level 2");


       /* if(collider.gameObject.tag == "Player")
        {
            print("item picked up");
            Destroy(gameObject);

        } */
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
