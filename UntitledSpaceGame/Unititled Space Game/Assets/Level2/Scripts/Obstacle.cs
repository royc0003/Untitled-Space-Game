using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    public int damage;
    public float rotationSpeed = 60;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("triggered");
        //SceneManager.LoadScene(nextSceneToLoad);

        if (collider.gameObject.tag == "Player")
        {

            PlayerManager.health -= damage;
        }
    }
}
