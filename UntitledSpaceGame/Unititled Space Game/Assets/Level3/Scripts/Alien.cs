using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour {
    private int id;    // unique identifier
    private string type;  // type(color)
    private string[] types = {"R", "G", "B"};
    

    // Start is called before the first frame update
    void Start() {
        System.Random r = new System.Random();
        int i = r.Next(0, 2);
        type = types[i];
    }

    // Update is called once per frame
    void Update(){
        
    }

    public int getID() {
        return id;
    }

    public string getType() {
        return type;
    }

    public void setType(string type) {
        this.type = type;
    }

    public void randomizeType() {
        System.Random r = new System.Random();
        int i = r.Next(0, 2);
        type = types[i];
        
    }


}
