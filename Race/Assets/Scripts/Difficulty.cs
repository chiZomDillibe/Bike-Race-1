using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    public int difficulty;
    private GameManagerScript gameManagerX;
    private Controller controllerX;
    private LEFT leftX;
    private RIGHT rightX;
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
       
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerScript>();
        controllerX = GameObject.Find("Player").GetComponent<Controller>();
        leftX = GameObject.Find("Left").GetComponent<LEFT>();
        rightX = GameObject.Find("Right").GetComponent<RIGHT>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetDifficulty()
    {
       
        controllerX.StartGame(difficulty);
        leftX.StartGame(difficulty);
        rightX.StartGame(difficulty);
        Debug.Log(gameObject.name + "was clicked");
    }
    
}
