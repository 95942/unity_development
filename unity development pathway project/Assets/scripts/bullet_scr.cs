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
            
    

            
    if (Mouse.current.leftButton.isPressed)
        {
    rb.AddForce(direction * backwardthrustforce);
        }
     if (Mouse.current.rightButton.isPressed)
        {
             Debug.Log("test");
            if(allowedtofire == 1f){
                Debug.Log("test2");
                if(instanceamount == 0f && followingmouse ==1f ){
                    instanceamount ++;
        Instantiate(gameObject);
          Destroy(gameObject);
            Destroy(gameObject);
            followingmouse = 0f;
    rb.AddForce(direction * thrustForce);
         allowedtofire = 0f;
         Debug.Log("test3");
               
                }
            } 
        }
     }
     
    void OnCollisionEnter2D(Collision2D collision)
    {
  
        Destroy(gameObject);
    }
}
