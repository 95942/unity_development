using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
  //work on later  RigidBody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        float randomsize = Random.Range(0.5f, 2f);
        transform.localScale = new Vector3(randomsize, randomsize, 1);
    //work on later    rb = GetComponent<RigidBody2D>();
 //work on later      rb.AddForce(Vector2.right * 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
