using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class scoring : MonoBehaviour
{
    private float elapsedTime = 0f;
    private float score = 0f;
    
    public float scoreMultiplier = 10f;
    public float thrustForce = 1f;
    

    
    public UIDocument uiDocument;
    private Label scoreText;
        
    void Start()
    {
  
        scoreText = uiDocument.rootVisualElement.Q<Label>("ScoreLabel");
    }

    void Update()
    {
        
        
        
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
       score = Mathf.FloorToInt(elapsedTime * scoreMultiplier);
         scoreText.text = "Score: " + score + 1;
    }

}