using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{

    // we changed all public class to private

    private float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    private GameManagerScript gameManagerX;


    // Start is called before the first frame update
    void Start()
    {
        
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerScript>();
        gameManagerX.isGameActive = false;
        
    }

    public void StartGame(int difficulty)
    {
        speed = speed * difficulty;
        turnSpeed = turnSpeed * difficulty;
        gameManagerX.isGameActive = true;
    }

    // Update is called once per frame
    void Update()
    {
       
        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        if (gameManagerX.isGameActive)
        {
            // We move the vehicle forward
            transform.Translate(Vector3.forward * Time.deltaTime * speed );


            // We turn the vehicle 
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        }
    }


    

  }  


