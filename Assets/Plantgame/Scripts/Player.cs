using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float Speed = 10f;
    private Rigidbody2D rb;
    private Vector2 movmentDiraction;
    public float PlayerHP;
   public float PlayerDMG;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
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

   
   
}
