using UnityEngine;
using UnityEngine.InputSystem;


public class bullet_scr : MonoBehaviour
{
    public bool followingmouse = true;
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
          
    
  if(followingmouse == false){
    rb.AddForce(direction * bullet_speed);
            }
            
            
    if (Mouse.current.leftButton.isPressed)
        {
            if(followingmouse == true){
    rb.AddForce(direction * backwardthrustforce);
            }
            

        }
     if (Mouse.current.rightButton.isPressed)
        {
        followingmouse = false;
   
    
               bulletdeath = true;
                
            } 
        }
     
    void OnCollisionEnter2D(Collision2D collision)
    {
if(bulletdeath == true){
    if(gameObject.tag == "asteroid"){
        Destroy(gameObject, 5f);
        bulletdeath = false;
        followingmouse = false;
      instanceamount = 0f;
}
    }
    }
}
