using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick_Move : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move()
    {
        if (transform.position.y > -2)
        {
            transform.Translate(Vector2.down * speed);
        }
    }
}
