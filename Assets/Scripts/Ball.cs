using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballSpeed;
    public Rigidbody2D oRigidbody2D;
    public AudioSource hitSound;
    
    // Start is called before the first frame update
    void Start()
    {
        oRigidbody2D.velocity = new Vector2(ballSpeed, ballSpeed) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        hitSound.Play();
    }
}
