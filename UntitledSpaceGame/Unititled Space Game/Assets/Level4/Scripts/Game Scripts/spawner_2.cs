using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_2 : MonoBehaviour
{

    public Transform spawnPos;
    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    // Start is called before the first frame update
  
  void Start() {
      InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
      
  }

  public void SpawnObject(){
        Instantiate(spawnee, spawnPos.position, spawnPos.rotation);

        if(stopSpawning){
            CancelInvoke("SpawnObject");
        }
  }

    // Update is called once per frame
    
}
