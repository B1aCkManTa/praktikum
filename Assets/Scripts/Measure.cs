using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
public class Measure : MonoBehaviour
{
    // Measure pad attributes
    public List<GameObject> colliderList = new List<GameObject>();
    public float avg_speed;
    public int pedestrian_cnt;
    public float cum_speed;

    // Start is called before the first frame update
    void Start()
    {
        // setting default values to the attributes
        avg_speed = 0.0f;
        pedestrian_cnt = 0;
    }

    // function is called when a pedestrian enters the measure pad collider
    public void OnTriggerEnter(Collider collider)
    {
        // checking if this object was not inside the collider before
        if (!colliderList.Contains(collider.gameObject))
        {
            // tracking the objects that enter the collider
            colliderList.Add(collider.gameObject);

            // getting the game object that entered the measure pad collider
            AIcontroller aiController = collider.gameObject.GetComponent<AIcontroller>();
            //calculating the distance covered by the pedestrian to reach teh measure pad
            float distance = Vector3.Distance (aiController.start_pos, this.transform.position);
            //increasing the pedestrian count
            pedestrian_cnt +=1;
            //calculating the avg speed of pedestrians that passed through the measurement pad
            cum_speed = distance/Time.realtimeSinceStartup;
            avg_speed = cum_speed/pedestrian_cnt;

            //logging information to the console
            Debug.Log("Passed " + gameObject.name);
            Debug.Log("Frame Count " + Time.frameCount);
            Debug.Log("FPS " + 1/Time.deltaTime);
            Debug.Log("RealTimeSinceStartup " + Time.realtimeSinceStartup);
            Debug.Log("cum_speed " + cum_speed);
            Debug.Log("avg_speed " + avg_speed);
        }
    }
}
