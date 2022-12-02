using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{

    // we changed all public class to private

    private float speed = 10.0f;
    private float turnSpeed = 15.0f;
    private float horizontalInput;
    private float forwardInput;
    private float leftLimit = 19.0f;
    private float rightLimit = 7.0f;
    private GameManagerScript gameManagerX;

    




    // Start is called before the first frame update
    void Start()
    {
        
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerScript>(); 
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
            transform.Translate(Vector3.forward * Time.deltaTime * speed);


            // We turn the vehicle 
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        }
    }


    

  }  


