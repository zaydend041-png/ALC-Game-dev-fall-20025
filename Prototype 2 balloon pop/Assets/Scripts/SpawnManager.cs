using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
   public GameObject[] balloonPreFabs();
   public float startDelay = 0.5f;
   public float spawnInterval = 1.5f;
   public float xRange = 10.0f;
   public float yPos = 20.0f;
   
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void SpawnRandomBalloon()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange),yPos, 0);
        int balloonIndex = Random.Range(0,balloonPreFabs.Length);
        Instantiate(balloonPreFabs[balloonIndex],spawnPos,balloonPreFabs[balloonIndex].transform.rotation);
    }
}
