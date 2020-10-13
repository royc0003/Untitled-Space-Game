using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Audio")]
	public AudioClip[] Tracks;

    AudioSource audioSource;
    [SerializeField] EnemyHealth enemyHealth;
  

    void Start(){
        audioSource = GetComponent<AudioSource>();
    }
   void Awake() {
               audioSource = GetComponent<AudioSource>();
               playBGM(1);
        
    }
    private void Update() {
        if(enemyHealth.isLowHealth() == true){
            playBGM(2);
        }
    }
    
// keeps a list of Songs to play
    public void playBGM(int songNo){
        if(audioSource.isPlaying == true){
            audioSource.Stop(); //stop music first before playing
        }
        audioSource.clip = this.Tracks[songNo];
        audioSource.Play();
    }
}
