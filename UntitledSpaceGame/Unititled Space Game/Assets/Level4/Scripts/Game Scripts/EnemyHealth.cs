using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]float hitPoints = 1000f;
     private float maxHealth;
    [SerializeField] BossHealthManager bossHealth;
    private bool isLow = false;
    private bool isDead = false;


    void Start(){
        this.maxHealth = this.hitPoints;
        bossHealth.SetMaxHealth(this.maxHealth);
    }
    // Create a public method which reduces hitpoints by the amount of dmg
    void Update() {
         if(this.hitPoints < 0.4*hitPoints) {isLow = true;
        }
        
    }
    public bool isLowHealth(){
        return this.isLow;
    }

   
    public void TakeDamage(float damage){
        
       
        BroadcastMessage("onDamageTaken"); //method only called on object or children
        hitPoints -= damage;
        bossHealth.SetHealth(this.hitPoints);
        if(this.hitPoints < 0.4*hitPoints) {isLow = true;
        }
        if(hitPoints <= 0){
            GetComponent<Animator>().SetBool("isDead",true);
            this.isDead = true;
            //Destroy(gameObject);
            Invoke("invokeEndgame",2.5f);
            //SceneManager.LoadScene("Level4End");
            return;

        }
    }
    public void invokeEndgame(){
        SceneManager.LoadScene("Level4End");

    }
    public bool getIsDead(){
        return this.isDead;
    }
    
   
       
    
}
