﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cutscene5 : MonoBehaviour
{
    public Button button;
    public Animator animatorRocket;
    // Start is called before the first frame update
    void Start()
    {
        animatorRocket.SetBool("fly",false);
        button.onClick.AddListener(NextScene);
    }
    
    public void NextScene() {
        button.gameObject.SetActive(false);
        animatorRocket.SetBool("fly",true);
        Invoke("LoadNextScene",10.0f);
        return;
        
    }
    public void LoadNextScene() {
        //SceneManager.LoadScene("Level4Start");
    }
}