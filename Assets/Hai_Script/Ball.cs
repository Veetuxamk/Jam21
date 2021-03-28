using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    AudioSource Bounce;
    

    Rigidbody2D Rigidbody;
    // config param 
    [SerializeField] Platform_Script platform1;
    [SerializeField] float xPush = 2f;
    [SerializeField] float yPush = 15f;

    // state
    Vector2 platformToBallVector;

    bool hasStarted = false;


    // Start is called before the first frame update
    void Start()
    {
        Bounce = GetComponent<AudioSource>();
        
        platformToBallVector = transform.position - platform1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            LockBallToPlatform();
            LaunchBall();

            
        }
       
    }
    
    private void LaunchBall()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
        }

    }

    private void LockBallToPlatform()
    {
        Vector2 platformPos = new Vector2(platform1.transform.position.x, platform1.transform.position.y);
        transform.position = platformPos + platformToBallVector;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bounce.Play();
    }
}
