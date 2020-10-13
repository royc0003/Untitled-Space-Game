using System;
using System.Collections;
using System.Collections.Generic;
//using System.Runtime.Remoting.Messaging;
using UnityEngine;
using UnityEngine.AI;

public class EnemyyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 5f;
    NavMeshAgent navMeshAgent;
    bool isProvoked = false;
    float distanceToTarget = Mathf.Infinity;

    public float Health = 25f;
    public Animator playerAnimator;
    public Animator enemyAnimator;
    public AudioSource hitSound;
    public float speed = 10f;
    public float enemyDamage = 0.01f;
    Boolean canAttack = true;

    bool enemyDied = false;

    public void TakeDamage(float amnt)
    {
        Health -= amnt;
        if (Health <= 0 && enemyDied == false)
        {
            enemyDied = true;
            print("Enemy has died");
            enemyAnimator.SetTrigger("Dead");
            FindObjectOfType<AudioManager>().Play("MonsterDamage");
            canAttack = false;
            Destroy(gameObject, 4);
            PlayerManager.enemiesLeft++;
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

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Atacking Player");
            PlayerManager.health -= 10;
        }
    }

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.speed = speed;

    }

    void Update()
    {   
        distanceToTarget = Vector3.Distance(target.position, transform.position);
        if (isProvoked)
        {
            EngageTarget();
        }
        else if (distanceToTarget <= chaseRange)
        {
            isProvoked = true;
            navMeshAgent.SetDestination(target.position);
        }

        if (distanceToTarget > chaseRange)
        {
            isProvoked = false;
            GetComponent<Animator>().SetTrigger("idle");
        }
    }

    
    private void EngageTarget()
    {
        if (distanceToTarget >= navMeshAgent.stoppingDistance)
        {
            ChaseTarget();
        }
        if (distanceToTarget <= navMeshAgent.stoppingDistance)
        {
            if (canAttack == true)
            {
                AttackTarget();
            }
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }

    private void ChaseTarget()
    {
        //GetComponent<Animator>().SetBool("running", true);
        navMeshAgent.SetDestination(target.position);
    }
    private void AttackTarget()
    {
        // GetComponent<Animator>().SetBool("attack", true);
        //GetComponent<Animator>().SetTrigger("running");
        //Debug.Log("Atacking Player");
        PlayerManager.health -= enemyDamage;
        //FindObjectOfType<AudioManager>().Play("Eattack");
    }
}
