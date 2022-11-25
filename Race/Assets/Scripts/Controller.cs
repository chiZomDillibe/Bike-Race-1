using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{

    // we changed all public class to private
    
    private float speed = 20.0f;
    private float turnSpeed = 30.0f;
    private float horizontalInput;
    private float forwardInput;
    private float leftLimit = 19.0f;
    private float rightLimit = 7.0f;
    private GameManagerScript gameManagerX;

    public bool gameOver = false;
    

    public ParticleSystem explosionParticle;

    // Start is called before the first frame update
    void Start()
    {
       gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerScript>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         // This is where we get player input
       horizontalInput= Input.GetAxis("Horizontal");
       forwardInput = Input.GetAxis("Vertical");
        
        
        // We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed );
        // We turn the vehicle 

        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);


        if (transform.position.x > leftLimit)
        {
            
          transform.position = new Vector3(leftLimit, transform.position.y, transform.position.z);
            

        }

        if (transform.position.x > rightLimit)
        {
            
           transform.position = new Vector3(rightLimit, transform.position.y, transform.position.z);
          
        }
    }

    // private void onCollisionEnter(Collision collision)

    //   GameOver();
    //if (gameObject.CompareTag("obstacle"))
    // {
    // explosionParticle.Play();
    // instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
    //  gameOver = true;
    //   Debug.Log("Game Over");

    //playerAudio.PlayOneShot(crashSound, 1.0f);
    // }
    private void OnTriggerEnter(Collider other)
    {
        gameManagerX.GameOver();
    }

    


}