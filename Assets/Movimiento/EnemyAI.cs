using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
   
    MeshRenderer meshRenderer;

    public NavMeshAgent agent;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;
  
    //Patrol
    public Vector3 walKPoint;
    bool walkPointSet;
    public float walkPointRange;

    //Attack
    public float timeBetweenAtacks;
    bool alredyAttacked;

    //States
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;
    public Animator animator;
    //audio
    public AudioSource musica;
    bool playsound;
    bool soundplayed =false;

    

    private void Start()
    {
        
        meshRenderer = GetComponent<MeshRenderer>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {

        
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (!playerInSightRange && !playerInAttackRange)
        {
            Patrolling();
            playsound = false;
        }
        if (playerInSightRange && !playerInAttackRange)
        {
            Chasing();
            playsound = true;
            if(!soundplayed)
            { 
            StartCoroutine(Sonido());
            }

        }
        if (playerInSightRange && playerInAttackRange)
        { Attacking();
            playsound = false;
        }

         

    }

    private void Patrolling()
    {
        soundplayed = false;
        meshRenderer.material.color = Color.green;

        animator.SetBool("Run", false);

        if (!walkPointSet) SearchWalkPoint();

        if(walkPointSet)  agent.SetDestination(walKPoint);

        Vector3 distanceToWalkPoint = transform.position - walKPoint;

        //Walkpoint reached
        if (distanceToWalkPoint.magnitude < 1f)  walkPointSet = false;
    }

    private void SearchWalkPoint()

    {
        
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walKPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if(Physics.Raycast(walKPoint, -transform.up, 2f, whatIsGround)) walkPointSet = true;

    }

    private void Chasing()
    {
        
        meshRenderer.material.color = Color.yellow;

        animator.SetBool("Run", true);

        agent.SetDestination(player.position);

        
       
    }

    private void Attacking()
    {
        
        meshRenderer.material.color = Color.red;

        animator.SetTrigger("Attack");

        animator.SetBool("Run", false);
       
        agent.SetDestination(transform.position);
        transform.LookAt(player);

        if (!alredyAttacked) 
        {
            alredyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAtacks);
        }
    }

    private void ResetAttack()
    {
        alredyAttacked = false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, attackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }
    private IEnumerator Sonido()
    {
        if (playsound)
        {
            musica.Play(0);
            Debug.Log("uwu");
            soundplayed = true;
        }
        
        yield return new WaitForSeconds(5f);    
    }
}
