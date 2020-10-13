using System;
using System.Collections;
using System.Collections.Generic;
//using System.Media;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PickUpItem : MonoBehaviour
{
    public float rotationSpeed = 35;
    public float healthIncrease = 50;
    public Boolean rotate = true;

    private void OnTriggerEnter(Collider collider)
    {
        //Debug.Log("triggered");
        //SceneManager.LoadScene(nextSceneToLoad);

        if (collider.gameObject.tag == "Player")
        {
            print("item picked up");
            //StartCoroutine("ReduceSpeedAfter5Seconds");
            PlayerManager.health += healthIncrease;
            
            if (PlayerManager.health >= 100)
            {
                PlayerManager.health = 100;
            }
            Destroy(gameObject);

        }
    }

    /* IEnumerator Wait()
     {
         PlayerManager.health += 10;
         yield return new WaitForSeconds(3);
         Debug.Log("wait is over");
         PlayerManager.health -= 10;
     }

     void changeValues()
     {
         StartCoroutine(Wait());
     }*/
    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(1f, 2f, rotationSpeed * Time.deltaTime);

        if (rotate == true)
        {
            transform.RotateAround(transform.position, transform.up, Time.deltaTime * rotationSpeed);
        }
    }



}
