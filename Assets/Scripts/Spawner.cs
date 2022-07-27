using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Spawner attributes
    public GameObject pedestrian;
    public int count = 1;
    public GameObject goal;
    public float min_range = 1.0f;
    public float max_range = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        // getting the collider of the spawner
        Collider myCollider = this.GetComponent<Collider>();
        // spwaning the pedestrian 
        for(int i=0;i<count;i++){
            // creating a random position
            Vector3 rand_pos = RandomPointInBounds(myCollider.bounds);
            //creating the pedestrian at that random position
            GameObject p = Instantiate(pedestrian,rand_pos,transform.rotation);
            // getting the AIcomponent attached to the pedestrian
            AIcontroller aiController = p.GetComponent<AIcontroller>();
            // setting the basic attributes of the pedestrian
            aiController.random_speed = true;
            aiController.goal = goal;
            aiController.min_range = min_range;
            aiController.max_range = max_range;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static Vector3 RandomPointInBounds(Bounds bounds) {
        
        // a function that takes a boundary and creates a random point inside of this bound 
        
        return new Vector3(
            Random.Range(bounds.min.x, bounds.max.x),
            1f,
            Random.Range(bounds.min.z, bounds.max.z)
        );
    }
}
