using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    float Speed = 10f;
    private Rigidbody2D rb;
    private Vector2 movmentDiraction;
    public float PlayerHP;
    public float PlayerDMG;
    public Rigidbody2D Playerrotation;
    public float Mausspeed = 5f;
   public GameObject weapon;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        Movement();
        Weaponmovement();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = movmentDiraction * Speed;
    }
    void Movement()
    {
        movmentDiraction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        
    }
   public void TakesDMG(float EnemydamageAmount) 
    {
        PlayerHP -= EnemydamageAmount;
        if (PlayerHP <= 0)
        {
            Debug.Log("you died");
        }
    }
    void Weaponmovement() 
    {
        Vector2 direction = Input.mousePosition - weapon.transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        weapon.transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    // tode nicht drin
    

   
   
}
