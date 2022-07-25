using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIcontroller : MonoBehaviour
{
    public GameObject goal;
    NavMeshAgent agent;
    public bool random_speed = false;
    public float min_range = 1.0f;
    public float max_range = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        if(random_speed)
            agent.speed = Random.Range(min_range, max_range);
        agent.SetDestination(goal.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
