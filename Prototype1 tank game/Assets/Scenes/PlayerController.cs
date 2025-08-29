using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotspeed;
    public float hInput;
    public float vInput;
    public float jumpforce;
    public Rigidbody playerRB;

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, hInput * rotspeed * Time.deltaTime); //Move the vehicle left and right (side-to-side)
        transform.Translate(Vector3.forward * vInput * speed * Time.deltaTime);//Moves the vehicle forward and backwards
    }
}
