using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private Transform target;
    public float movespeed = 10f;
    private UnityEngine.AI.NavMeshAgent navMeshAgent;
    public GameObject player;
    public bool isLooking;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        target = player.transform;
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        navMeshAgent.speed = movespeed;
        if (navMeshAgent == null)
        {
            navMeshAgent = gameObject.AddComponent<UnityEngine.AI.NavMeshAgent>();
            animator.SetBool("run", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.speed = movespeed;
        navMeshAgent.SetDestination(target.transform.position);
        if (isLooking == true)
        {
            navMeshAgent.SetDestination(navMeshAgent.transform.position);
            //navMeshAgent.SetDestination(navMeshAgent.transform.position - target.transform.position);
            animator.SetBool("run", false);
        }
        else if(isLooking == false)
        {
            animator.SetBool("run", true);
        }
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
    }
}
