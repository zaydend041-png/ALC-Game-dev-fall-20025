using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class PlayerController2D : MonoBehaviour
{
    //Valuetypes
    [Header("Player Settings")]
    public float movespeed;
    public float jumpForce;
    public bool isGrounded;
    public int bottomBound = -4;
    [Header("Score")]
    public int score;
    public Rigidbody2D rig;
    public TextMeshProUGUI scoreText;
    public void AddScore (int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }
    void FixedUpdate ()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rig.linearVelocity = new Vector2(moveInput * movespeed, rig.linearVelocity.y);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            isGrounded = false;
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        if(transform.position.y < bottomBound)
        {
            GameOver();
        }
    }
    void OnCollisionEnter2D (Collision2D collision)
    {
        if(collision.GetContact(0).normal == Vector2.up)
        {
            isGrounded = true;
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
