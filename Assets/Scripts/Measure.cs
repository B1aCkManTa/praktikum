using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
public class Measure : MonoBehaviour
{
    public List<GameObject> colliderList = new List<GameObject>();
    public float avg_speed;
    public int pedestrian_cnt;
    public float cum_speed;
    // Start is called before the first frame update
    void Start()
    {
        avg_speed = 0.0f;
        pedestrian_cnt = 0;
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (!colliderList.Contains(collider.gameObject))
        {
            colliderList.Add(collider.gameObject);
            Debug.Log("Passed " + gameObject.name);
            Debug.Log("Frame Count " + Time.frameCount);
            Debug.Log("FPS " + 1/Time.deltaTime);
            Debug.Log("RealTimeSinceStartup " + Time.realtimeSinceStartup);

            AIcontroller aiController = collider.gameObject.GetComponent<AIcontroller>();
            float distance = Vector3.Distance (aiController.start_pos, this.transform.position);
            pedestrian_cnt +=1;

            cum_speed = distance/Time.realtimeSinceStartup;
            avg_speed = cum_speed/pedestrian_cnt;

            Debug.Log("cum_speed " + cum_speed);
            Debug.Log("avg_speed " + avg_speed);
        }
    }
}
