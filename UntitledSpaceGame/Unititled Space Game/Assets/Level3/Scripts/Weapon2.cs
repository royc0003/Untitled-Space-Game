﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon2 : MonoBehaviour
{

    [SerializeField]
    private ParticleSystem flash;
    private AudioSource shoot;

    // Start is called before the first frame update
    void Start()
    {
        shoot = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            flash.Play();
            shoot.Play();
        }
    }

    
}
