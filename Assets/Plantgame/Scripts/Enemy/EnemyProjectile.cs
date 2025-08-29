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
    public Objectpool bulletPool;
    
    // schade zwischen spieler und enemy noch bei beiden skripten fehlend
    void Start()
    {
        StartCoroutine(SpawnBullets());

      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Projectile() 
    {
        GameObject newBullet = bulletPool.GetBulletObject();
        newBullet.transform.position = Enemy2.position;
        newBullet.transform.rotation = Enemy2.rotation;
        Rigidbody2D rb = newBullet.GetComponent<Rigidbody2D>();
        Vector2 direction = (player.position - transform.position).normalized;
        rb.linearVelocity = (direction * enemyspeed);
        StartCoroutine(DeactivateBullet(newBullet));
    }
 


    IEnumerator SpawnBullets()
    {
        while(true)
            {
           
            Projectile();
           
            yield return new WaitForSeconds(2f);
        }
        
    }
    IEnumerator DeactivateBullet(GameObject bullet) 
    {
        yield return new WaitForSeconds(5f);
        bulletPool.ReturnBulletObject(bullet);
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Enemy"))
            {

            Destroy(gameObject);
            //schaden zu player fehlt + player kann nicht zerstören
        }
    }
   
    
}
