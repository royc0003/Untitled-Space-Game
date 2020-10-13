using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public LevelScript levelScript { get; private set; }

    protected void Start()
    {
        levelScript = GetComponent<LevelScript>();
    }





}