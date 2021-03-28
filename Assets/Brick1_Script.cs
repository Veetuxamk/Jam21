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
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        AudioSource.PlayClipAtPoint(Splosion, gameObject.transform.position);

        if (timer > 0)
        {
            if (other.transform.CompareTag("Ball"))
            {
                
                Destroy(this.gameObject);
            }
        }

    }
}