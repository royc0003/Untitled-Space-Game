using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackMelee : MonoBehaviour
{
    public GameObject Player;
    public WeaponMelee myWeapon;
    public Animator animator;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetTrigger("attack");
            //DoAttack();
        }
    }

    private void DoAttack()
    {
        /*Ray ray = cam.ScreenPointToRay(Input.mousePosition); *//*
        RaycastHit hit;

        *//*if(Physics.Raycast(ray, out hit, myWeapon.attackRange))
        {*//*
            if(hit.collider.tag == "Enemy")
            {
                EnemyHealthMelee eHealth = hit.collider.GetComponent<EnemyHealthMelee>();
                eHealth.TakeDamage(myWeapon.attackDamage);
            }*/
        /*}*/
    }
}
