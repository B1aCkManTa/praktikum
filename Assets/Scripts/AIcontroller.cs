using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIcontroller : MonoBehaviour
{
    // pedestrian attributes
    public GameObject goal;
    NavMeshAgent agent;
    public bool random_speed = false;
    public float min_range = 1.0f;
    public float max_range = 10.0f;
    public Vector3 start_pos;

    // Start is called before the first frame update
    void Start()
    {
        // getting the NavMeshAgent attached to the pedestrian 
        agent = this.GetComponent<NavMeshAgent>();
        //setting the speed of the pedestrian
        if(random_speed)
            agent.speed = Random.Range(min_range, max_range);
        // setting the distination of the pedestrian 
        agent.SetDestination(goal.transform.position);
        // saving the start position of the pedestrian
        start_pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
