using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
public class Goal : MonoBehaviour
{
    public List<GameObject> colliderList = new List<GameObject>();
    int finish_cnt;
    private void Start() {
        finish_cnt = 0;
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (!colliderList.Contains(collider.gameObject))
        {
            finish_cnt+=1;
            colliderList.Add(collider.gameObject);
            Debug.Log("Added " + gameObject.name);
            Debug.Log("GameObjects in list: " + colliderList.Count);
            Destroy(collider.gameObject);
            Debug.Log("Frame Count " + Time.frameCount);
            Debug.Log("FPS " + 1/Time.deltaTime);
            Debug.Log("RealTimeSinceStartup " + Time.realtimeSinceStartup);
        }
    }

    public void OnTriggerExit(Collider collider)
    {
        if(colliderList.Contains(collider.gameObject))
        {
            colliderList.Remove(collider.gameObject);
            Debug.Log("Removed " + gameObject.name);
            Debug.Log("GameObjects in list: " + colliderList.Count);
        }
    }
}
