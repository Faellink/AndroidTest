using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{

    public static ObjectPooling SharedInstance;
    public List<GameObject> pooledObjects;
    public GameObject objectPool;
    public int amountToPool;
    
    
    void Awake()
    {
        SharedInstance = this;
    }

    void Start()
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i< amountToPool; i++)
        {
            tmp = Instantiate(objectPool);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }
    }
    
    void Update()
    {
        
    }



    public GameObject GetPooledObject()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        
        return null;
    }
}
