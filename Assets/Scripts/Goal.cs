using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
public class Goal : MonoBehaviour
{
    //Goal Attributes
    public List<GameObject> colliderList = new List<GameObject>();
    int finish_cnt;

    private void Start() {
        // setting default values to the attributes
        finish_cnt = 0;
    }

    // function is called when a pedestrian enters the measure pad collider
    public void OnTriggerEnter(Collider collider)
    {
        // checking if this object was not inside the collider before
        if (!colliderList.Contains(collider.gameObject))
        {
            // tracking the objects that enter the collider
            colliderList.Add(collider.gameObject);
            // keeping count of the pedestrians that reached the goal
            finish_cnt+=1;
            //logging information to the console
            Debug.Log("Added " + gameObject.name);
            Debug.Log("GameObjects in list: " + colliderList.Count);
            Debug.Log("Frame Count " + Time.frameCount);
            Debug.Log("FPS " + 1/Time.deltaTime);
            Debug.Log("RealTimeSinceStartup " + Time.realtimeSinceStartup);
            //destroying the pedestrian object
            Destroy(collider.gameObject);
        }
    }

}
