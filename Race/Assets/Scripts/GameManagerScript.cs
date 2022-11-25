using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    private int score = 0;
    public bool isGameActive = true;

    // Start is called before the first frame update
    void Start()
    {
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
        isGameActive = false;
    }

}
