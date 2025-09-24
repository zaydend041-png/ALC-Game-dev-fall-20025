using UnityEngine;


public class FloatUp : MonoBehaviour
{
    public float speed;
    public float upperBound = 15.0f;
    public ScoreManager scoreManager;// Referencing the score manager
    public Balloon balloon;// Referencing the balloon script to get the score

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        balloon = GetComponent<Balloon>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if(transform.position.y >= upperBound)
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive); // Reduce score for allowing the balloon to leave the screen
            Destroy(gameObject);// Pop balloon after leaving screen
        }
    }
}
