using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour

{
    public Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    private AudioSource sound;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sound = GetComponent<AudioSource>();
        rb.velocity = new Vector2(speed, -5);
    }
    void Update()

    {
        if(Input.GetKeyDown("space")){
            rb.velocity = new Vector2(speed, jumpForce);
            sound.Play();
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("GameOver");

    }
}
