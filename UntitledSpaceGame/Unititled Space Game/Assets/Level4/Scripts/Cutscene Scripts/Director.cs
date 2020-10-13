using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Director : MonoBehaviour
{
    public GameObject timeline;
    private PlayableDirector director;
    
    // Start is called before the first frame update
    void Awake()
    {
        director = timeline.GetComponent<PlayableDirector>();
        director.Play();
    }
}
