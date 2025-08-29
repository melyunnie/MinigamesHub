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


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        Movement();

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
    // tode nicht drin
    //weapon mit maus bewegen nicht drin

   
   
}
