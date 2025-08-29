using UnityEngine;
using UnityEngine.EventSystems;


public class Enemy1 : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] GameObject enemy1;
    [SerializeField] float enemyspeed;
    [SerializeField]Rigidbody2D rb;
    [SerializeField] public float EnemyHP, EnemymaxHP;
    [SerializeField] float EnemyDMG;
    Vector2 movement;
    public SpawnEnemy SpawnEnemy;
    void Start()
    {
        EnemyHP = EnemymaxHP;
    }

    // Update is called once per frame
    void Update()
    {
      followPlayer();
    }
    void followPlayer() 
    {
        Vector2 direction = (player.position - transform.position).normalized;
        movement = direction;
       
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * enemyspeed * Time.fixedDeltaTime );
    

    }
    public void EnemyTakesDMG(float damageAmount)
    {
        EnemyHP -= damageAmount;
        if (EnemyHP <= 0) 
        {
            SpawnEnemy.Enemy1Number--;
            enemy1.SetActive(false);


        }
    }
   
   
}

