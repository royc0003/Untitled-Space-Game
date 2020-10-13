using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager2 : MonoBehaviour

{
    [Header("Audio")]
	public AudioClip[] Tracks;
  

// keeps a list of Songs to play
    public AudioClip changeBGM(int songNo){
        return this.Tracks[songNo];
    }
}
