using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]float hitPoints = 100f;
    [SerializeField] PlayerHealthManager playerHealth;
    
    

    private float maxHealth;
   
    private bool isDead = false;

    // Create a public method which reduces hitpoints by the amount of dmg
    void Start(){
        this.maxHealth = hitPoints;
        playerHealth.SetMaxHealth(this.maxHealth);
        
    }
    public void TakeDamage(float damage){

        hitPoints -= damage;
       playerHealth.SetHealth(this.hitPoints);
        if(hitPoints <= 0){
            Debug.Log("Your current health is: "+ hitPoints);
            Debug.Log("You are DEADSDS");
            isDead = !isDead;
            manageDeath(isDead);
        }
    }
    public void increaseHealth(float health){
        float totalHealth = this.hitPoints + health;
        if(totalHealth >= maxHealth){
            Debug.Log("player helath is greater than max health");
            this.hitPoints = this.maxHealth;
        }
        else{
            hitPoints+= health;
        }
                playerHealth.SetHealth(this.hitPoints);

        
    }
    public float getPlayerHealth(){
        return this.hitPoints;
    }
    public bool IsDead(){
        return isDead;
    }
    public void manageDeath(bool isDead){
        if(isDead){
        DeathHandler deathHandler = GetComponent<DeathHandler>();
        deathHandler.playDeathSong();
        
        deathHandler.HandleDeath();
        
        }
    }

   

    
}
