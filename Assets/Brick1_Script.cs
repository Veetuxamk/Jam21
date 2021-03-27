using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick1_Script : MonoBehaviour
{

  
    private float timer;

    private void Start()
    {
        timer = Time.realtimeSinceStartup;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (timer > 0)
        {
            if (other.transform.CompareTag("Ball"))
            {
                Destroy(this.gameObject);
            }
        }

    }
}