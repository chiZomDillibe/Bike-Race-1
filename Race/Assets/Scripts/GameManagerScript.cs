using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    private int score = 0;
    public bool isGameActive;
    public Button restartButton;
    public int level;
    public GameObject titleScreen;

    
    void Start()
    {
        //isGameActive = true;
        score = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
       if(isGameActive)
        {
            UpdateScore();
        }
    }
    private void UpdateScore()
    {
        
        score += 1;
        scoreText.text = "Score: " + score;
        titleScreen.gameObject.SetActive(false);
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
        
    }
    
}
