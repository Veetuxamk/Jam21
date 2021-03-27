using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Script : MonoBehaviour
{
    public float speed;
    public float RScreenEdge = 5;
    public float LScreenEdge = -5;
    private void Update()
    {
        //Gets the inputs from Unitys Input manager
        float horizontal = Input.GetAxis("Horizontal");

        //Moves the platform with unitys inputs
        transform.Translate(Vector2.right * horizontal * Time.deltaTime * speed);

        //These stop movement if we hit the screen edge. Our screens edges x position determines L and R ScreenEdges.
        if(transform.position.x < LScreenEdge)
        {
            transform.position = new Vector2(LScreenEdge, transform.position.y);
        }
        if (transform.position.x > RScreenEdge)
        {
            transform.position = new Vector2(RScreenEdge, transform.position.y);
        }
    }
}
