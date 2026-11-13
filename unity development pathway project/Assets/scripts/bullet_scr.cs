using UnityEngine;
using UnityEngine.InputSystem;


public class bullet_scr : MonoBehaviour
{
    public bool enemy = false;
    public bool followingmouse = true;
    public float backwardthrustforce =-50f;
    public float bullet_speed = 50f;
    public float thrustForce = 1f;
    public bool bulletdestory = false;
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
            if(followingmouse == true){
            transform.up = direction;
            
            rb.AddForce(direction * thrustForce);
            }
            
            
  
     if (Mouse.current.rightButton.isPressed)
        {

  

  
        rb.AddForce(direction * bullet_speed);
                  followingmouse = false;
       bulletdestory = true;
        }
     
   
}
 void OnCollisionEnter2D(Collision2D collision)
    {
      
        followingmouse = true;
}
    }
    
