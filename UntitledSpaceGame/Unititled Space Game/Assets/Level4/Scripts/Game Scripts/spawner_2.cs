using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_2 : MonoBehaviour
{

    public Transform spawnPos;
    public GameObject spawnee;
    public bool stopSpawning = false;
    public bool spawnOnce = false;
    public float lifeTime = 20.0f;
    
    public GameObject clone;
    


    public float spawnTime;
    public float spawnDelay;
    public AudioClip audioClip;
    // Start is called before the first frame update
  
  
  void Awake(){
      if(spawnOnce == true){
        CancelInvoke("SpawnObject");
        clone = Instantiate(spawnee, spawnPos.position, spawnPos.rotation);


      }
  }
  void Start() {
      if(spawnOnce == true) return;
      InvokeRepeating("SpawnObject", spawnTime, spawnDelay);

    
      
  }
    void Update()
    {    //error handling, incase never put as a childeren 
       bool spawnOnce = isSpawnOnce();
        if(lifeTime > 0){
            lifeTime -= Time.deltaTime;
            if(lifeTime <= 0){
                if(spawnOnce == true) return;

                    Destroy(clone);

                
            }
        }
    }

  public void SpawnObject(){
        clone = Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
        setSpawnTime();
        setSpawnDelay();
        if(audioClip != null){
            AudioSource.PlayClipAtPoint(audioClip, transform.position, 50f);
        }
        this.lifeTime = 20.0f;

        if(stopSpawning){
            CancelInvoke("SpawnObject");
        }
  }

    // Update is called once per frame
    
    private void setSpawnTime(){
        //lifeTime
        //this.spawnTime = Random.Range(20.0f, 100.0f);
        this.spawnTime = 25.0f;
    }
        private void setSpawnDelay(){
            //How long before next spawn
        //this.spawnDelay = Random.Range(100.0f, 150.0f);
        this.spawnDelay = 30.0f;
    }

    public bool isSpawnOnce(){
        return this.spawnOnce;
    }

}
