using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop = 3; //How many clicks before balloon pops

    Public float scaleToIncrease = 0.10f; //Scale increased each time the balloon is clicked

    public int scoreToGive; // Score given for the popped balloon

    private ScoreManager scoreManager; // A variable to reference the ScoreManager

    public GameObject popEffect; // Reference Pop Effect Particle System

    // Start is called before the first frame update

    void Start()
    {
        // Reference ScoreManager Component*
        //scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnmouseDown()
    {
        // Reduce clicks by one
        clickToPop -=1;
        //Increase balloon size
        transform.localScale += Vector3.one * scaleToIncrease;

        if(clickToPop ==0)
        {
            //scoreManager.IncreaseScoreText(scoreToGive); // Increase Score*
            //Instantiate(popEffect, transform.position, transform.rotation); // Instantiate Particle Effect - POP Effect*
            Destroy(gameObject)
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
