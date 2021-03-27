using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick_Move : MonoBehaviour
{

    public float speed;
    private float currenty;
    private float time = 0;

    private int x;

    // Start is called before the first frame update
    void Start()
    {
        currenty = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (x != 10) {
            if (time - Time.realtimeSinceStartup < -2)
            {
                    transform.Translate(Vector2.down * speed);
                    time = Time.realtimeSinceStartup;
                x++;
            }
        }
    }
}
