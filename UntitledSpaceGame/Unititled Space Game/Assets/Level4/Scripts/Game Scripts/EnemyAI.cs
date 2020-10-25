using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 5f;
    [SerializeField] float turnSpeed = 5f;
    NavMeshAgent navMeshAgent;
    bool isProvoked = false;
    float distanceToTarget = Mathf.Infinity;
    EnemyHealth health;
    
    // Start is called before the first frame update

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        health = GetComponent<EnemyHealth>();

    }

    // Update is called once per frame
    void Update()
    {
        // for each frame, set the destination of where the destination of the player may be
        if(health.getIsDead() == true){
            this.isProvoked = false;
            Debug.Log("I am no provoked: " + isProvoked);}
        
        distanceToTarget = Vector3.Distance(target.position, transform.position);
        if(isProvoked){
            //set faster speed
            navMeshAgent.speed = 25;
            EngageTarget();
        }
        else if (distanceToTarget <= chaseRange){
             if(health.getIsDead() == true){
            this.isProvoked = false;
            Debug.Log("I am inside " + isProvoked);}
            else{isProvoked = true;
            navMeshAgent.SetDestination(target.position);}
            
        }

        if(distanceToTarget > chaseRange){
            isProvoked = false;
            GetComponent<Animator>().SetTrigger("idle");

        }
        
        
        
    }
    private void EngageTarget() {
        //if (something)
        FaceTarget();

        if(distanceToTarget >= navMeshAgent.stoppingDistance){

            
            ChaseTarget();

        }
        // if (something else)
        if(distanceToTarget <= navMeshAgent.stoppingDistance){
            AttackTarget();
        }
        navMeshAgent.speed = 5;
    }
         void OnDrawGizmosSelected()
    {
        // Display the explosion radius when selected
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }

    private void ChaseTarget(){
        GetComponent<Animator>().SetBool("attack",false);

        GetComponent<Animator>().SetTrigger("move");
        navMeshAgent.SetDestination(target.position);

        
    }
    private void AttackTarget(){
        GetComponent<Animator>().SetBool("attack",true);

        Debug.Log(name + " has seek and is destroying " + target.name);

    }
    private void FaceTarget() {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation,lookRotation,Time.deltaTime*turnSpeed);
        //transform.rotation = where the target is, we need to rotate at a certain speed


    }

    public void onDamageTaken(){
        isProvoked = true;
    }
}
