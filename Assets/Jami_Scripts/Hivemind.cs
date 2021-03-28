using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hivemind : MonoBehaviour
{
    private float moves = 0;
    private int amount;
    private Brick_Move[] swarm;
    private GameObject[] bricks;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moves != 10)
        {
            if (moves - Time.realtimeSinceStartup < -3)
            {
                GetAllBricks();

                moves = Time.realtimeSinceStartup;
                moves++;
            }
        }
    }

    private void GetAllBricks()
    {
        amount = GameObject.FindGameObjectsWithTag("Brick").Length;
        bricks = GameObject.FindGameObjectsWithTag("Brick");
        
        swarm = new Brick_Move[amount];
        for (int x = 0; x < amount; x++)
        {
            swarm[x] = bricks[x].GetComponent<Brick_Move>();
            swarm[x].Move();
        }

                
    }

    public void Restart()
    {
        moves = 0;
    }

}
