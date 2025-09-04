using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
   public SpawnEnemy SpawnEnemy;
    public float EnemyNumber;

    void Start()
    {
        SpawnEnemy.Enemy1spawn = SpawnEnemy.Enemy1Number;
        SpawnEnemy.Enemy2spawn = SpawnEnemy.Enemy2Number;

    }

    
    void Update()
    {
        Newlevel();
    }
    
    // level detection
    void Newlevel() 
    {

        EnemyNumber = SpawnEnemy.Enemy1Number;
            //+ SpawnEnemy.Enemy2Number;

        if (EnemyNumber == 0)
        {
            Debug.Log("test 2");
            //next level bzw shop
            SpawnEnemy.Enemy1Number = SpawnEnemy.Enemy1spawn * 2;
          //  SpawnEnemy.Enemy2Number = SpawnEnemy.Enemy2spawn * 2;

            SceneManager.LoadScene("Plantshop");
        }
       
    }
    

}
