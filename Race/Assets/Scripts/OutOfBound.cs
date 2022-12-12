using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBound : MonoBehaviour
{
    private float bound = 0;
    private float sideBound = 3124f;
    private GameManagerScript gameManagerX;

    public ParticleSystem dirtParticle;

    void Start()
    {
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < bound)
        {
            
            transform.position = new Vector3 (transform.position.x, 2, transform.position.z);
            dirtParticle.Play();
            gameManagerX.isGameActive = false;
        }
       if (transform.position.x < -sideBound || transform.position.x > sideBound)
        {
            gameManagerX.GameOver();
        // transform.position = new Vector3(-sideBound, transform.position.y, transform.position.z);
        }
    }
}
