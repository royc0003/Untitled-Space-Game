using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleDamage : MonoBehaviour
{
    public int damage = 10;

    private void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "Player")
        {
            PlayerManager.health -= damage;
            FindObjectOfType<AudioManager>().Play("ObstacleDamage");

        }
    }
}
