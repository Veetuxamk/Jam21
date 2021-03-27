using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick_Generator : MonoBehaviour
{
    // Prefabs
    public GameObject Basic_1;
    public GameObject Basic_2;
    public GameObject Basic_3;
    public GameObject Repulse_1;
    public GameObject Laser_1;
    public GameObject Durable_1;

    // Random number boundraries
    public int Maxwidth;
    public int Maxheight;

    // The space in between the bricks
    public int Spacewidth;
    public int Spaceheight;

    // Find all enemies
    private int Enemies;

    // Random numbers
    private int Randomint;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Find all of the enemies
        Enemies = GameObject.FindGameObjectsWithTag("Enemy").Length;

        // if no enemies are found
        if (Enemies == 0)
        {

            for (int y = Maxheight; y > 0; y = y - Spaceheight)
            {
                for (int x = Maxwidth; x > 0; x = x - Spacewidth)
                {
                    Randomint = Random.Range(0, 7); // generate random number 0-6 (i know it says 7, ignore it, this is just how random works)

                    switch (Randomint)
                    {// instantiate a random Enemy

                        case 0:
                            break;
                        case 1:
                            Instantiate(Basic_1, new Vector2(x, y), Quaternion.identity);
                            Instantiate(Basic_1, new Vector2(-x, y), Quaternion.identity);
                            break;
                        case 2:
                            Instantiate(Basic_2, new Vector2(x, y), Quaternion.identity);
                            Instantiate(Basic_2, new Vector2(-x, y), Quaternion.identity);
                            break;
                        case 3:
                            Instantiate(Basic_3, new Vector2(x, y), Quaternion.identity);
                            Instantiate(Basic_3, new Vector2(-x, y), Quaternion.identity);
                            break;
                        case 4:
                            Instantiate(Repulse_1, new Vector2(x, y), Quaternion.identity);
                            Instantiate(Repulse_1, new Vector2(-x, y), Quaternion.identity);
                            break;
                        case 5:
                            Instantiate(Laser_1, new Vector2(x, y), Quaternion.identity);
                            Instantiate(Laser_1, new Vector2(-x, y), Quaternion.identity);
                            break;
                        case 6:
                            Instantiate(Durable_1, new Vector2(x, y), Quaternion.identity);
                            Instantiate(Durable_1, new Vector2(-x, y), Quaternion.identity);
                            break;
                    }

                    if(x == 1)// Instantiate something in the middle
                    {
                        Randomint = Random.Range(0, 7); // generate random number 0-6 (i know it says 7, ignore it, this is just how random works)

                        switch (Randomint)
                        {// instantiate a random Enemy

                            case 0:
                                break;
                            case 1:
                                Instantiate(Basic_1, new Vector2(0, y), Quaternion.identity);
                                break;
                            case 2:
                                Instantiate(Basic_2, new Vector2(0, y), Quaternion.identity);
                                break;
                            case 3:
                                Instantiate(Basic_3, new Vector2(0, y), Quaternion.identity);
                                break;
                            case 4:
                                Instantiate(Repulse_1, new Vector2(0, y), Quaternion.identity);
                                break;
                            case 5:
                                Instantiate(Laser_1, new Vector2(0, y), Quaternion.identity);
                                break;
                            case 6:
                                Instantiate(Durable_1, new Vector2(0, y), Quaternion.identity);
                                break;
                        }
                    }
                }
            }
        }
    }
}
