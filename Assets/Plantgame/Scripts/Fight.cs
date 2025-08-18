using UnityEngine;

public class Fight : MonoBehaviour
{
    [SerializeField] GameObject Enemyweapon;
    public Player player;
    public Enemy1 enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy1>(out Enemy1 enemycomponent)) 
        {
          enemycomponent.EnemyTakesDMG(player.PlayerDMG);
        }
        if(collision.gameObject.TryGetComponent<Player>(out Player playercomponent)) 
        {
            playercomponent.TakesDMG(enemy.EnemyHP);
        }
    }
    

}

