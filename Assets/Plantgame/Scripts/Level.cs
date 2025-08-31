using UnityEngine;

public class Level : MonoBehaviour
{
    SpawnEnemy SpawnEnemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //enemynumber increse
    // level detection
    void Newlevel() 
    {
        float EnemyNumber = SpawnEnemy.Enemy1Number;
            //+ SpawnEnemy.Enemy2Number;
        SpawnEnemy.Enemy1spawn = SpawnEnemy.Enemy1Number;
        SpawnEnemy.Enemy2spawn = SpawnEnemy.Enemy2Number;
        if (EnemyNumber == 0) 
        {
            //next level bzw shop
          SpawnEnemy.Enemy1Number = SpawnEnemy.Enemy1spawn  * 2;
          //SpawnEnemy.Enemy2Number = SpawnEnemy.Enemy2spawn * 2;
        }

        // überschreibt die numbers nicht

        //if (Enemy1Number && Enemy2Number == 0) { next level }
    }

}
