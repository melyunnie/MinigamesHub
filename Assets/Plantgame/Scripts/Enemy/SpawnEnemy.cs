using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public float Enemy1Number;
    public float Enemy2Number;
    float Enemy1spawn;
    float Enemy2spawn;
    public Objectpool enemy1pool;
    public Objectpool enemy2pool;
    public Vector2 spawnAreaMin = new Vector2(-10f, -10f);
    public Vector2 spawnAreaMax = new Vector2(10f, 10f);
    
    void Start()
    {
        StartCoroutine(SpawnEnemy1());
        StartCoroutine(SpawnEnemy2());

    }

   
    void Update()
    {
        
    }
     void SpawnEn1()
     {
        GameObject newEnemy1 = enemy1pool.GetEnemy1Object();
        float x = Random.Range(spawnAreaMin.x, spawnAreaMax.x);    
        float y = Random.Range(spawnAreaMin.y, spawnAreaMax.y);    
        newEnemy1.transform.position = new Vector3(x, y, 0f);    
        Rigidbody2D rb = newEnemy1.GetComponent<Rigidbody2D>();    
        newEnemy1.SetActive(true);
        StartCoroutine(DeactivateEnemy1(newEnemy1));     
   
     }      
    IEnumerator SpawnEnemy1()
    {
        while (Enemy1Number > 1)
        {
                SpawnEn1();
            yield return new WaitForSeconds(2f);
        }

    }

    IEnumerator DeactivateEnemy1(GameObject Enemy1)
    {
        yield return new WaitForSeconds(5f);
        enemy1pool.ReturnEnemy1Object(Enemy1);
    }
    void SpawnEn2()
    {
        GameObject newEnemy2 = enemy2pool.GetEnemy2Object();
        float x = Random.Range(spawnAreaMin.x, spawnAreaMax.x);
        float y = Random.Range(spawnAreaMin.y, spawnAreaMax.y);
        newEnemy2.transform.position = new Vector3(x, y, 0f);
        Rigidbody2D rb = newEnemy2.GetComponent<Rigidbody2D>();
        newEnemy2.SetActive(true);
        StartCoroutine(DeactivateEnemy2(newEnemy2));

    }
    IEnumerator SpawnEnemy2()
    {
        while (Enemy2Number > 1)
        {
            SpawnEn2();
            yield return new WaitForSeconds(2f);
        }

    }

    IEnumerator DeactivateEnemy2(GameObject Enemy2)
    {
        yield return new WaitForSeconds(5f);
        enemy2pool.ReturnEnemy2Object(Enemy2);
    }

    // sollen nicht despawnen
    //lengere spawn dauer?

    //if (Enemy1Number && Enemy2Number == 0) { next level }
}

