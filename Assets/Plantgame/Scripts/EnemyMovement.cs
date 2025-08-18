using UnityEngine;
using UnityEngine.EventSystems;


public class EnemyMovement : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float enemyspeed;
    [SerializeField]Rigidbody2D rb;
    public float EnemyHP;
    public float EnemyDMG;
    bool flip;
    Vector2 movement;
    void Start()
    {
        
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
    //enemy2
    //Vector2 direction = (player.position - transform.position).normalized;
    //movement = direction;
    //rb.MovePosition(direction * enemyspeed);   
}

