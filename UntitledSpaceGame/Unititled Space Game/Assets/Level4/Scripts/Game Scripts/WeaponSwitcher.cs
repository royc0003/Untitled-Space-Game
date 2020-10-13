using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int currentWeapon = 0;
    private AudioManager2 audioManager;
    private AudioClip audioClip;
    void Start()
    {
        audioManager = GetComponentInParent<AudioManager2>();
        audioClip = audioManager.changeBGM(9);
        SetWeaponActive();
        
    }
        // Update is called once per frame

    void Update() {
        int previousWeapon = currentWeapon;

        ProcessKeyInput();
        ProcessScrollWheel();

        if(previousWeapon != this.currentWeapon){
            SetWeaponActive(); 
        }
        
    }

    private void ProcessScrollWheel()
    {
        if(Input.GetAxis("Mouse ScrollWheel")<0){
            //loop back to 0 if >2
            if(currentWeapon >= transform.childCount -1){
                currentWeapon = 0;
            }
            else{
                currentWeapon++;
            }
        }
            if(Input.GetAxis("Mouse ScrollWheel")>0){
            //loop back to 0 if >2
            if(currentWeapon <= 0){
                currentWeapon = transform.childCount - 1;
            }
            else{
                currentWeapon--;
            }
        }
    }

    private void ProcessKeyInput()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            this.currentWeapon = 0;
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
            this.currentWeapon = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)){
            this.currentWeapon = 2;
        }
    }

    private void SetWeaponActive()
    {
        int weaponIndex = 0;

        foreach( Transform weapon in transform){
            if(weaponIndex == currentWeapon){
                weapon.gameObject.SetActive(true);
            }
            else{
                weapon.gameObject.SetActive(false);
            }
            weaponIndex++;
        }
    }
    
    private void playWeaponSound(){
    AudioSource.PlayClipAtPoint(audioClip, transform.position, 0.7f);

    }

  
}
