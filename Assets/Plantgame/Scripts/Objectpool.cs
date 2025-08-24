using System.Collections.Generic;
using UnityEngine;

public class Objectpool : MonoBehaviour
{
    public GameObject bulletprefab;
    private Queue<GameObject> bulletpool = new Queue<GameObject>();

    public GameObject GetBulletObject() 
    { 
         if (bulletpool.Count > 0) 
        { 
            GameObject obj = bulletpool.Dequeue();
            obj.SetActive(true);
            return obj;
        }
        return Instantiate(bulletprefab);
    }
    public void ReturnBulletObject(GameObject obj) 
    { 
        obj.SetActive(false);
        bulletpool.Enqueue(obj);
    }

}
