using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{   
    [System.Serializable] //To mark it as an attribute
    public class Pool
    {
        public string tag; 
        public GameObject prefab;
        public int size; //When to reuse objects instead of spawning new ones
    }

    public List<Pool> pools;
    public Dictionary<string, Queue<GameObject>> poolDictionary;
    // Start is called before the first frame update
    void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();

        foreach(Pool pool in pools) //For each pool
        {
            Queue<GameObject> objectPool = new Queue<GameObject>(); //Create a queue of objects

            for(int i = 0; i< pool.size; i++) //Add objects to queue
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }

            poolDictionary.Add(pool.tag, objectPool);
        }
    }


}
