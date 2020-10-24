using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_2 : MonoBehaviour
{

    public Transform spawnPos;
    public GameObject spawnee;
    public bool stopSpawning = false;
    public bool spawnOnce = false;


    public float spawnTime;
    public float spawnDelay;
    public AudioClip audioClip;
    // Start is called before the first frame update
  
  
  void Awake(){
      if(spawnOnce == true){
        CancelInvoke("SpawnObject");
        Instantiate(spawnee, spawnPos.position, spawnPos.rotation);


      }
  }
  void Start() {
      if(spawnOnce == true) return;
      InvokeRepeating("SpawnObject", spawnTime, spawnDelay);

    
      
  }

  public void SpawnObject(){
        Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
        setSpawnTime();
        setSpawnDelay();
        if(audioClip != null){
            AudioSource.PlayClipAtPoint(audioClip, transform.position, 50f);
        }


        if(stopSpawning){
            CancelInvoke("SpawnObject");
        }
  }

    // Update is called once per frame
    
    private void setSpawnTime(){
        //lifeTime
        this.spawnTime = Random.Range(50.0f, 100.0f);
    }
        private void setSpawnDelay(){
            //How long before next spawn
        this.spawnDelay = Random.Range(50.0f, 100.0f);
    }

    public bool isSpawnOnce(){
        return this.spawnOnce;
    }
}
