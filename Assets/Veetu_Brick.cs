using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veetu_Brick : MonoBehaviour
{
 
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag ("Ball"))
        {
            Destroy(this.gameObject);
        }
    }
}
