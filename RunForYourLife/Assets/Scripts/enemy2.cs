using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
    private Transform target;
    public float movespeed = 8f;
    private UnityEngine.AI.NavMeshAgent navMeshAgent;
    public GameObject player;
    public bool isLooking;
    // Start is called before the first frame update
    void Start()
    {
        target = player.transform;
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        navMeshAgent.speed = movespeed;
        if (navMeshAgent == null)
        {
            navMeshAgent = gameObject.AddComponent<UnityEngine.AI.NavMeshAgent>();
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
        }
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        if (GameObject.Find("Mom").GetComponent<Range>().isplayerin == true)
        {
            movespeed = 8f;
        }
        else if (GameObject.Find("Mom").GetComponent<Range>().isplayerin == false)
        {
            movespeed = 8f;
        }
    }
}
