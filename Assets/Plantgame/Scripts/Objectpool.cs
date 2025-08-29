using System.Collections.Generic;
using UnityEngine;

public class Objectpool : MonoBehaviour
{
    public GameObject bulletprefab;
    private Queue<GameObject> bulletpool = new Queue<GameObject>();
    public GameObject Enemy1prefab;
    private Queue<GameObject> enemy1pool = new Queue<GameObject>();
    public GameObject Enemy2prefab;
    private Queue<GameObject> enemy2pool = new Queue<GameObject>();
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

    public GameObject GetEnemy1Object()
    {
        if (enemy1pool.Count > 0)
        {
            GameObject en1 = enemy1pool.Dequeue();
            en1.SetActive(true);
            return en1;
        }
        return Instantiate(Enemy1prefab);
    }
    public void ReturnEnemy1Object(GameObject en1)
    {
        en1.SetActive(false);
        enemy1pool.Enqueue(en1);
    }
    public GameObject GetEnemy2Object()
    {
        if (enemy2pool.Count > 0)
        {
            GameObject en2 = enemy2pool.Dequeue();
            en2.SetActive(true);
            return en2;
        }
        return Instantiate(Enemy2prefab);
    }
    public void ReturnEnemy2Object(GameObject en2)
    {
        en2.SetActive(false);
        enemy2pool.Enqueue(en2);
    }
}
