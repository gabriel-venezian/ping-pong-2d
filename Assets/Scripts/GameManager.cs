using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int player1Score;
    public int player2Score;
    public Text Scoreboard;
    public AudioSource scoreSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void IncrementPlayer1Score() 
    {
        player1Score++;
        UpdateScoreboard();
    }

    public void IncrementPlayer2Score() 
    {
        player2Score++;
        UpdateScoreboard();
    }

    public void UpdateScoreboard() 
    {
        Scoreboard.text = player1Score + " x " + player2Score;

        scoreSound.Play();
    }
}
