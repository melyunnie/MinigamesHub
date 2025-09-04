using UnityEngine;

public class Fight : MonoBehaviour
{
    [SerializeField] GameObject Enemyweapon;
    public Player player;
    public Enemy1 enemy1;
    public Enemy2 enemy2;
    

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy1>(out Enemy1 enemycomponent)) 
        {
          enemycomponent.Enemy1TakesDMG(player.PlayerDMG);
           
        }
        if(collision.gameObject.TryGetComponent<Player>(out Player playercomponent)) 
        {
            playercomponent.TakesDMG(enemy1.EnemyHP);
            playercomponent.TakesDMG(enemy2.EnemyHP);
        }
        if (collision.gameObject.TryGetComponent(out Enemy2 enemy2component))
        {
            enemy2component.Enemy2TakesDMG(player.PlayerDMG);

        }


        //bullets machen keinen schaden
        //number von dem enemy2 zählt nicht runter
        // collision detection auf spieler nicht weapon
    }
    

}

