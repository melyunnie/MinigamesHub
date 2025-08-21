using UnityEngine;
using System.Collections;
using System;
using Unity.VisualScripting;
public class EnemyProjectile : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] GameObject bullet;
    [SerializeField] Transform Enemy2;
    [SerializeField] float enemyspeed;
    
    void Start()
    {
        StartCoroutine(SpawnBullets());
        // alle x sekunden wird ein projectile in richtung spieler geschossen
        //die kugeln treffen entweder den spieler oder die werden zerstört 
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void Projectile() 
    {
        GameObject newBullet = Instantiate (bullet, Enemy2.position, Enemy2.rotation);
        Rigidbody2D rb = newBullet.GetComponent<Rigidbody2D>();
        Vector2 direction = (player.position - transform.position).normalized;
        rb.linearVelocity = (direction * enemyspeed);
    }
 


    IEnumerator SpawnBullets()
    {
        while(true)
            {
            Projectile();
            yield return new WaitForSeconds(10f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Enemy"))
            {

            Destroy(gameObject);
        }
    }
}
