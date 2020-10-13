using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] float damage = 40f;
    [SerializeField] AudioSource audioSource;
    public AudioClip audioClip;
public AudioClip[] Tracks;


    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
        audioSource = GetComponent<AudioSource>();
       
        
    }

    // Update is called once per frame
    public void AttackHitEvent(){
        if(target == null) return;
        target.GetComponent<ShowDamage>().ShowDamageImpact();
        target.TakeDamage(damage);

        playImpact();
        
    }

    private void playImpact()
    {
        //audioSource.Play();
        audioSource.clip= audioClip;
        audioSource.Play();
        //AudioSource.PlayClipAtPoint(audioClip, transform.position, 100f);
        
       
    }
    private void playDeath(){
        audioSource.clip = Tracks[0];
                audioSource.Play();

    }
     public void onDamageTaken(){

         Debug.Log(name + "i also know i took damage");        
    }
}
