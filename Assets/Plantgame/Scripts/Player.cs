using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float Speed = 2f;
    private Rigidbody2D rb;
    private Vector2 movmentDiraction;
    [SerializeField] GameObject pot;
   
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == pot )
        {
            Debug.Log("test1");
          
           
            
            
        }
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == pot && Input.GetKeyDown(KeyCode.E))
        {Debug.Log("test4");
            
            
                //sceene zu pflanze kümmern aka nahansicht-> neues script-> detection von welcher pflanze es ist
            



        }
    }
}
