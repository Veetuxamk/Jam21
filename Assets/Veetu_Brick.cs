using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veetu_Brick : MonoBehaviour
{
    
    public GameObject Brickaruu;
    private float timer;

    private void Start()
    {
        timer = Time.realtimeSinceStartup;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (timer < 1)
        {
             if (other.transform.CompareTag ("Ball"))
             {
                Object.Instantiate(Brickaruu, transform.position, Quaternion.identity);
                Destroy(this.gameObject);
             }
        }
       
    }
}
