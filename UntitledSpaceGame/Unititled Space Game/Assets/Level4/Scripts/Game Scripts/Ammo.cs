using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    private List<AudioClip> assaultRiflereload = new List<AudioClip>();
    private List<AudioClip> gunReload = new List<AudioClip>();
    
    [SerializeField] TextManager textManager;


    private AudioManager2 audioManager;
   // [SerializeField] int ammoAmount=10;

    private int size = 2;
    [SerializeField] AmmoSlot[] ammoSlots;
    [System.Serializable] //show content belonging to this class
     private class AmmoSlot{
        public AmmoType ammoType;
        public int ammoAmount;
        public int maxAmount;

    }
    // Start is called before the first frame update
    void Start()
    {
        audioManager = GetComponent<AudioManager2>();
        assaultRiflereload.Add(audioManager.changeBGM(5));
        assaultRiflereload.Add(audioManager.changeBGM(6));
        gunReload.Add(audioManager.changeBGM(7));
        gunReload.Add(audioManager.changeBGM(8));
       

        //AudioSource.PlayClipAtPoint(zoomClip, transform.position, 0.7f);

        
    }
   

    public void reduceCurrentAmmo(AmmoType ammoType){
        if(GetAmmoSlot(ammoType)!= null){
         GetAmmoSlot(ammoType).ammoAmount-=1;
         textManager.setBulletCount(GetAmmoSlot(ammoType).ammoAmount);
       }
        
    }
     public void increaseCurrentAmmo(AmmoType ammoType, int increaseAmount){
        if(GetAmmoSlot(ammoType)!= null){
            int temp = getAmmoAmount(ammoType) + increaseAmount;
            /*if(temp == getMaxAmount(ammoType)){
                return;
            }
            else */
            if(temp >= getMaxAmount(ammoType)){
                Debug.Log("Beyond max amount of: "+ temp + " maxamount: " +getMaxAmount(ammoType) );
                setAmmoAmount(ammoType,getMaxAmount(ammoType));
                AudioSource.PlayClipAtPoint( audioManager.changeBGM(7), transform.position, 1f);
            }
            else{
                GetAmmoSlot(ammoType).ammoAmount+= increaseAmount;
                textManager.setBulletCount(GetAmmoSlot(ammoType).ammoAmount);
                AudioSource.PlayClipAtPoint( audioManager.changeBGM(8), transform.position, 1f);
            }
         

       }
        
    }
    public int getMaxAmount(AmmoType ammoType){
        //this.ammoAmount = amount;
        return GetAmmoSlot(ammoType).maxAmount;

    }
    public void setAmmoAmount(AmmoType ammoType, int amount){
        GetAmmoSlot(ammoType).ammoAmount = amount;

    }
    public int getAmmoAmount(AmmoType ammoType){
       // return this.ammoAmount;
       if(GetAmmoSlot(ammoType)!= null){
           return GetAmmoSlot(ammoType).ammoAmount;
       }
       return 0;
    }
    private AmmoSlot GetAmmoSlot(AmmoType ammoType){
        foreach(AmmoSlot slot in ammoSlots){
            if(slot.ammoType == ammoType ){
                return slot;
            }
        }
        return null;
    }   
}
