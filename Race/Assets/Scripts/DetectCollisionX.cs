using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionX : MonoBehaviour
{
    private GameManagerScript gameManagerX;
    public ParticleSystem explosionParticle;

    public AudioClip crashSound;
    public AudioClip cheersSound;
    private AudioSource playerAudio;
    

    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("End"))
        {
            playerAudio.PlayOneShot(cheersSound, 1.0f);
        }
        explosionParticle.Play();

        
        
        //instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
        playerAudio.PlayOneShot(crashSound, 1.0f);
        gameManagerX.GameOver();
        //explosionParticle.Stop();

    }

    private void OnCollisionEnter(Collision collision)
    {

        gameManagerX.GameOver();
        transform.position = new Vector3(0, 0, 0);
        transform.Translate(0, 0, 0);

    }
}
