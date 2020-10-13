using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private BGMManager BGM;
    [SerializeField] Canvas gameOverCanvas;
    public AudioSource DeathSong;
     private bool enabled = true;
     //private AudioManager ADM;
    // Start is called before the first frame update
    void Start()
    {
        //ADM = GetComponent<AudioManager>();
        gameOverCanvas.enabled = !enabled;
        
    }

    // Update is called once per frame

    public void HandleDeath(){
    gameOverCanvas.enabled = enabled;
    Time.timeScale = 0 ;
    FindObjectOfType<WeaponSwitcher>().enabled = false;
    playDeathSong();
    Cursor.lockState = CursorLockMode.None;
    Cursor.visible = enabled;
    

    }
    public void playDeathSong(){
    float lastTimeScale = Time.timeScale;
     Time.timeScale = 1f;
     if(DeathSong != null) DeathSong.Stop();
     //AudioSource.PlayClipAtPoint( ADM.changeBGM(2), Vector3.zero, 50);
     BGM.playBGM(0);
     Time.timeScale = lastTimeScale;
    }
}
