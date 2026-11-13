using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public GameObject explosionEffect;
    public bool scorableobject = false;
    public float backwardthrustforce =-50f;
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
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
  asteroid_scr enemy = collision.gameObject.GetComponent<asteroid_scr>();
  if(enemy != null)
  {
            Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
  }
    }
}