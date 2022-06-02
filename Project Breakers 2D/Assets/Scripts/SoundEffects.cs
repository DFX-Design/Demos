using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundEffects : MonoBehaviour
{
    public AudioClip soundFile;
    private bool firstHit = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            AudioSource.PlayClipAtPoint(soundFile, Camera.current.transform.position, 1f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.gameObject.CompareTag("Paddle"))
        {
            //prevents sound from playing at start of game when ball is on paddle
            if (firstHit)
            {
                if (collision.gameObject.CompareTag("Ball"))
                {
                    AudioSource.PlayClipAtPoint(soundFile, Camera.current.transform.position, 1f);
                }

            }
            else
            {
                firstHit = true;
            }
        }
        if (this.gameObject.CompareTag("Shattered"))
        {
            if (collision.gameObject.CompareTag("Ball"))
            {
                AudioSource.PlayClipAtPoint(soundFile, Camera.current.transform.position, 0.5f);
            }
        }
        if ((this.gameObject.CompareTag("Wall") || this.gameObject.CompareTag("Brick")))
        {
            if (collision.gameObject.CompareTag("Ball"))
            {
                AudioSource.PlayClipAtPoint(soundFile, Camera.current.transform.position, 1f);
            }
        }
    }
}
