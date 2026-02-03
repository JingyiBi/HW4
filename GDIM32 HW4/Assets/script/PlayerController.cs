using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

   public float flapStrength = 2f;
   public AudioSource flapSound;
   public AudioSource collisionSound;
    private Rigidbody2D rb;
    private bool isDead = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && !isDead)
        {

            rb.velocity = Vector2.up * flapStrength;
            flapSound.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") )
        {
            if (!isDead)
            {

               TriggerGameOver();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ScoreSlot")&& !isDead)

        {
            if (ScoreManager.instance != null)
            {
            ScoreManager.instance.AddPoint();
        }}}
        private void TriggerGameOver()
        {
         isDead = true;
         Debug.Log("game Over:Hit an obstacle!");
         if (collisionSound != null)
         {
            collisionSound.Play();
         }
         Time.timeScale = 0;   
        }
    }

