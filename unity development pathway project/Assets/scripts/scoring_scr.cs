using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class scoring : MonoBehaviour
{
    private float score = 0f;
    private float scorepoints = 0f;

    public float thrustForce = 1f;
    

    
    public UIDocument uiDocument;
    private Label scoreText;
        
    void Start()
    {
  
        scoreText = uiDocument.rootVisualElement.Q<Label>("ScoreLabel");
    }

    void Update()
    {
        score = scorepoints;
        
        
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        scorepoints ++;
       score = Mathf.FloorToInt(scorepoints);
         scoreText.text = "Score: " + score ++;
    }

}