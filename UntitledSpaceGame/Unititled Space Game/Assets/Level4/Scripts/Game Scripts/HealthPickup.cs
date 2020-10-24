using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float healthIncrement = 20.0f;

    [SerializeField] PlayerHealth playerHealth;

    public AudioClip audioClip;
    private void OnTriggerEnter(Collider other) {
            if(other.gameObject.tag == "Player"){
            Debug.Log("Healing your health");
            playerHealth.increaseHealth(this.healthIncrement);
            AudioSource.PlayClipAtPoint(audioClip, transform.position, 100f);
            Destroy(gameObject);
        }
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
