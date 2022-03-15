using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public float playerSpeed;
    public bool player1;
    public float yMin;
    public float yMax;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player1 == true)
        {
            Player1Move();
        }
        else 
        {
            Player2Move();
        }
    }

    public void Player1Move() 
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMin, yMax));

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * playerSpeed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * playerSpeed * Time.deltaTime);
        }        
    }

    public void Player2Move() 
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMin, yMax));
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * playerSpeed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * playerSpeed * Time.deltaTime);
        }        
    }
}
