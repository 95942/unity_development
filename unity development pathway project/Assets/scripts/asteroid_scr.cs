using UnityEngine;
public class asteroid_scr : MonoBehaviour
{
       public float minSize = 0.5f;
    public float maxSize = 2.0f;
    public float minSpeed = 50f;
    public float maxSpeed = 150f;

    Rigidbody2D rb;

    void Start()
    {
        float randomSize = Random.Range(minSize, maxSize);
        transform.localScale = new Vector3(randomSize, randomSize, 1);

        float randomSpeed = Random.Range(minSpeed, maxSpeed);
        Vector2 randomDirection = Random.insideUnitCircle;

        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(randomDirection * randomSpeed);
        
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
Vector2 randomDirection = Random.insideUnitCircle;

 Instantiate(gameObject);
 Destroy(gameObject);
        transform.localScale = new Vector3(minSize, minSize);
  
}
}

