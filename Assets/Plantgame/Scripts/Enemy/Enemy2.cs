using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    
    [SerializeField] GameObject enemy2;
    
    public Objectpool bulletPool;
    [SerializeField] public float EnemyHP, EnemymaxHP;
    public SpawnEnemy SpawnEnemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EnemyHP = EnemymaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Enemy2TakesDMG(float damageAmount)
    {
        EnemyHP -= damageAmount;
        if (EnemyHP <= 0)
        {
            Debug.Log("dmg");
            SpawnEnemy.Enemy2Number--;
            enemy2.SetActive(false);
        }
    }
}
