using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pedestrian;
    public int count = 1;
    public GameObject goal;
    public float min_range = 1.0f;
    public float max_range = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        Collider myCollider = this.GetComponent<Collider>();

        for(int i=0;i<count;i++){
            Vector3 rand_pos = RandomPointInBounds(myCollider.bounds);
            GameObject p = Instantiate(pedestrian,rand_pos,transform.rotation);
            AIcontroller aiController = p.GetComponent<AIcontroller>();
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
        return new Vector3(
            Random.Range(bounds.min.x, bounds.max.x),
            1f,
            Random.Range(bounds.min.z, bounds.max.z)
        );
    }
}
