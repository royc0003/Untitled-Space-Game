using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] int ammoAmount = 10;
    [SerializeField] AmmoType ammoType;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.tag == "Player"){
            Debug.Log("Players triggered me");
            FindObjectOfType<Ammo>().increaseCurrentAmmo(ammoType,ammoAmount);
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
