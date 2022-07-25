using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
public class Measure : MonoBehaviour
{
    public List<GameObject> colliderList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
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
        }
    }
}
