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
    public bool isGameActive = true;
    public Button restartButton;

    
    public void StartGame()
    {
        isGameActive = true;
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
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
        
    }
    
}
