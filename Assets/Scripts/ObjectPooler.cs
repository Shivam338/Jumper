using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public GameObject ObjectToPool;
    public int NumberOfObjectsToPool;

    List<GameObject> ObjectsToPool;

    // Start is called before the first frame update
    void Start()
    {
        ObjectsToPool = new List<GameObject> ();

        for(int i =0; i< NumberOfObjectsToPool; i++)
        {
            GameObject obj = (GameObject) Instantiate(ObjectToPool);
            obj.SetActive(false);
            ObjectsToPool.Add(obj);
        }   
    }

    public GameObject GetPooledObject()
    {
        for(int i=0; i< ObjectsToPool.Count; i++)
        {
            if (ObjectsToPool[i].activeInHierarchy)
            {
                return ObjectsToPool[i];
            }
        }

        GameObject obj = (GameObject)Instantiate(ObjectToPool);
        obj.SetActive(false);
        ObjectsToPool.Add(obj);
        return obj;
    }

  
}
