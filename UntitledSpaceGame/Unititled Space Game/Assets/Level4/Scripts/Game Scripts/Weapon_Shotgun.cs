using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Shotgun: MonoBehaviour
{
    
    // Start is called before the first frame update
    [SerializeField] TextManager textManager;

    [SerializeField] Camera FPCamera;
    [SerializeField] float range = 100f;

    //[SerializeField] float ammo = 6;

    [SerializeField] float damage = 30f;
    [SerializeField] ParticleSystem muzzleFlash;
    [SerializeField] GameObject hitEffect;
    [SerializeField] Ammo ammoSlot;
    [SerializeField] AmmoType ammoType;



    public AudioSource weaponSound;
    private AudioManager audioManager;
   // [SerializeField] AudioSource source;
  //note this is for audio sources 
    
    public AudioClip otherClip;
    private float fireRate = 0.1f;
    private float nextFire = 0f;
        bool canShoot = true;



    void Start()
    {

     //source = GetComponent<AudioSource>();  
     //audioManager = GetComponentInParent<AudioManager>();
     //otherClip = audioManager.changeBGM(3);
      textManager.setBulletCount(ammoSlot.getAmmoAmount(ammoType));
    textManager.setTotalCount(ammoSlot.getAmmoAmount(ammoType));

    
    }
    void OnEnable() {
             Debug.Log("Machine gun is shooting");

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire && canShoot == true ){
            nextFire = Time.time + fireRate;
            Shoot();
        }
         textManager.setBulletCount(ammoSlot.getAmmoAmount(ammoType));
            textManager.setTotalCount(ammoSlot.getMaxAmount(ammoType));

    }
    private void Shoot(){
        canShoot = false;
        if(ammoSlot.getAmmoAmount(ammoType)>0){
        PlayMuzzleFlash();
        ProcessRayCast();
        Debug.Log(ammoSlot.getAmmoAmount(ammoType));
        ammoSlot.reduceCurrentAmmo(ammoType);
        }
        else{
        AudioSource.PlayClipAtPoint(otherClip, transform.position, 0.7f);
        }
        canShoot = true;

     
    }
    private void PlayMuzzleFlash(){
        Debug.Log("Im muzzling now");
        muzzleFlash.Play();
    }



    private void invokeDelaySoundEffect(){}

    private void ProcessRayCast() {
        RaycastHit hit;
        //Note that (Vector3 Origin, Vector3 direction, hitinfo, maxDistance, layerMask, QueryTriggerInterraction)
        //https://docs.unity3d.com/ScriptReference/Physics.Raycast.html 
        if(Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range)){
     CreateHitImpact(hit);
        Debug.Log("I hit: " + hit.transform.name);
        //Todo: Add some hit effects
        EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
        if(target==null) return;
        target.TakeDamage(damage);

        //Call enemy method that decreases the enemy's health


        }
        else {
            return;
        }
    }

    //CreateHitImpact == 
    private void CreateHitImpact(RaycastHit hit)
    {
        GameObject impact=Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impact, 1);

    }
    public bool isNotLock(){
        return this.canShoot;
    }
    public void setNotLock(bool set){
        this.canShoot = set;
    }
}
