using UnityEngine;
using UnityEngine.InputSystem;


public class bullet_scr : MonoBehaviour
{
    private float followingmouse = 1f;
    private float allowedtofire = 1f;
private float instanceamount = 0f;
    public float backwardthrustforce =-50f;
    public float bullet_speed = 50f;
    public float thrustForce = 1f;
    private bool bulletdeath = false;
    Rigidbody2D rb;


    void Start()
    {
     
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       
            // Calculate mouse direction
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
            Vector2 direction = (mousePos - transform.position).normalized;

            // Move player in direction of mouse
            transform.up = direction;
   
            rb.AddForce(direction * thrustForce);
            
    
  if(followingmouse == 0f){
    rb.AddForce(direction * bullet_speed);
            }
            
            
    if (Mouse.current.leftButton.isPressed)
        {
            if(followingmouse == 1f){
    rb.AddForce(direction * backwardthrustforce);
            }
            

        }
     if (Mouse.current.rightButton.isPressed)
        {
        followingmouse = 0f;
   
    
               bulletdeath = true;
                
            } 
        }
     
    void OnCollisionEnter2D(Collision2D collision)
    {
if(bulletdeath == true){
        Destroy(gameObject);
        bulletdeath = false;
        followingmouse = 1f;
      instanceamount = 0f;
}
    }
}
