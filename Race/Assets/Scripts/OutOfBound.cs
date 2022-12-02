using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBound : MonoBehaviour
{
    private float bound = 0f;
    private float sideBound = 15f;
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
            dirtParticle.Play();
            transform.position = new Vector3 (transform.position.x, 0, transform.position.z);
        }
       if (transform.position.x < -sideBound)
        {
            //gameManagerX.GameOver();
        // transform.position = new Vector3(-sideBound, transform.position.y, transform.position.z);
        }
    }
}
