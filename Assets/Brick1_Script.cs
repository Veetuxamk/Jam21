using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick1_Script : MonoBehaviour
{
    
    public AudioClip Splosion;
    private float timer;

    void Start()
    {
        timer = Time.realtimeSinceStartup;
        AudioSource.PlayClipAtPoint(Splosion, Camera.main.transform.position);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        

        if (timer > 1)
        {
            if (other.transform.CompareTag("Ball"))
            {
                GetComponent<AudioSource>().Play();
                Destroy(this.gameObject);
            }
        }

    }
}