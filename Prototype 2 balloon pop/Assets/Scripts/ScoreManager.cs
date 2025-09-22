
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText; // Reference the UI Text

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreText();
    }

    public void IncreaseScoreText(int amount)
    {
        score += amount; //increase score by amount
        UpdateScoreText(); //Update score Text UI
    }
     public void DecreaseScoreText(int amount)
    {
        score -= amount; //Decrease score by amount
        UpdateScoreText(); 
    }


    public void UpdateScoreTex()
    {
        scoreText.text = "Score: " + score;
    }
   
  
}
