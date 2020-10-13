using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class Bullet : MonoBehaviour
{
    public Sprite greenBullet;
    public Sprite redBullet;
    Sprite bulletColor;
    public string curBulletColor;
    Random random;

    // Start is called before the first frame update
    void Start()
    {
        random = new Random();
        setBulletColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setBulletColor() {
        Sprite[] arr = { greenBullet, redBullet };
        string[] types = new string[] {"G", "R"};
        int index = random.Next(0, arr.Length);
        curBulletColor = types[index];
        print("BULLET COLOR " + arr[index]);
        this.gameObject.GetComponent<Image>().sprite = arr[index];
    }

}
