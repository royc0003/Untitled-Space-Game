using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject[] spawnee;
    public float radius = 2;
    int randomInt;
    int randomIntTwo;
    Vector3 randomVector;
    float tempTime;
    
    private void Start() {
        spawnPoints = GameObject.FindGameObjectsWithTag("spawnPoint");
    }
    void Update()
    {
        /*if(Input.GetMouseButton(0)){
            SpawnRandom();
        }*/
        tempTime += Time.deltaTime;
        if (tempTime > 0.05)
        {
            tempTime = 0;
            SpawnRandom();
        }

    }

    int GetRandom(int count){
        return Random.Range(0, count);
    }


    Vector3 GetRandomVector(Vector3 v){
        return (Random.insideUnitSphere * radius) + v;
    }   
    void SpawnRandom()
    {
        randomInt = GetRandom(spawnee.Length);
        randomIntTwo = GetRandom(spawnPoints.Length);
        randomVector = GetRandomVector(spawnPoints[randomIntTwo].transform.position);
        Instantiate(spawnee[randomInt], randomVector, spawnPoints[randomIntTwo].transform.rotation);
    }
}
