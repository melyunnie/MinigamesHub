using UnityEngine;

public class EnemyWeapons : MonoBehaviour
{
    public Transform player;
    void Start()
    {
        
    }
    void Update()
    {
        WeaponLookatPlayer();
    }
    void WeaponLookatPlayer()
    {

        Vector2 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
