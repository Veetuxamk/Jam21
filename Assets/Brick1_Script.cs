using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick1_Script : MonoBehaviour
{
    
    
    private float timer;

    void Start()
    {
        timer = Time.realtimeSinceStartup;
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {

        FindObjectOfType<PlayerStats>().AddToScore();
        if (timer > 1)
        {
            
            if (other.transform.CompareTag("Ball"))
            {
                
                Destroy(this.gameObject);
            }
        }

    }
}