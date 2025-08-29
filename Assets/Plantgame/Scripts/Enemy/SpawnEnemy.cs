using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public float Enemy1Number;
    public float Enemy2Number;
    float Enemy1spawn;
    float Enemy2spawn;
    public Objectpool enemy1pool;
    public Vector2 spawnAreaMin = new Vector2(-10f, -10f);
    public Vector2 spawnAreaMax = new Vector2(10f, 10f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnEnemy1());


    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void Spawn()
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
            
                Spawn();

               
            yield return new WaitForSeconds(2f);
        }

    }

    IEnumerator DeactivateEnemy1(GameObject Enemy1)
        {
            yield return new WaitForSeconds(5f);
            enemy1pool.ReturnEnemy1Object(Enemy1);

        }

        // erst wenig enemy spawnene aber nach zeit immer mehr-> objectpooling mit spawncount 

        // wennn 10 enemy spwan
        //wenn enemy tod spawn new

        //if (Enemy1Number && Enemy2Number == 0) 
        //{ 
        //next level
        // }
    }

