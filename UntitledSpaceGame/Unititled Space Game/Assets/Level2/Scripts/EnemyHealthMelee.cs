using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

public class EnemyHealthMelee : MonoBehaviour
{
    public float Health = 25f; 
    public Animator playerAnimator;
    public Animator enemyAnimator;
    public AudioSource hitSound;


    public void TakeDamage(float amnt)
    {
        Health -= amnt;
        if(Health <= 0)
        {
            print("Enemy has died");
            enemyAnimator.SetTrigger("Dead");
        }
        //print("Enemy took some damage");
    }


    void OnTriggerEnter(Collider other)
    {
        int count = 1;

        if (other.gameObject.tag == "Weapon")
        {
            if (playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("attack"))
            {
                enemyAnimator.SetTrigger("BeingAttacked");
                hitSound.Play();
                print("Enemy took some damage");
                TakeDamage(4);
            }

        }
    }
}
