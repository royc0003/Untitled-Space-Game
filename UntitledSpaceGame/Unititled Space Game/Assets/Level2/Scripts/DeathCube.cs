using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCube : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        //Debug.Log("triggered");
        //SceneManager.LoadScene(nextSceneToLoad);

        if (collider.gameObject.tag == "Player")
        {
            PlayerManager.health -= 1000;
        }
    }
}
