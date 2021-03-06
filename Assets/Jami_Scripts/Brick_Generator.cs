using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick_Generator : MonoBehaviour
{
    // Prefabs
    public GameObject Basic_1;
    public GameObject Basic_2;
    public GameObject Basic_3;
    /*public GameObject Repulse_1;
    public GameObject Laser_1;*/
    public GameObject Durable_1;

    // Random number boundraries
    public float Maxwidth;
    public float Maxheight;

    // The space in between the bricks
    public float Spacewidth;
    public float Spaceheight;

    // Find all enemies
    private int Enemies;

    // Random numbers
    private int Randomint;

    // Difficulty level
    private int difficulty = 7;

    private GameObject Hivemind;
    private Hivemind Queen;

    // Start is called before the first frame update
    void Start()
    {
        Hivemind = GameObject.FindGameObjectWithTag("Hivemind");
        Queen = Hivemind.GetComponent<Hivemind>();
    }

    // Update is called once per frame
    void Update()
    {
        // Find all of the enemies
        Enemies = GameObject.FindGameObjectsWithTag("Brick").Length;

        // if no enemies are found
        if (Enemies == 0)
        {
            Queen.Restart();

            for (float y = Maxheight; y > 0; y = y - Spaceheight)
            {
                for (float x = Maxwidth; x > 0; x = x - Spacewidth)
                {
                    Randomint = Random.Range(difficulty - 7, difficulty); // generate random number 0-6 (i know it says 7, ignore it, this is just how random works)

                    switch (Randomint)
                    {// instantiate a random Enemy
                     // We have stopped working on special units so some numbers have been 
                     // commented out so they can be quickly restored if work on them resumes

                        case 0: case 1:/**/ case 2: /*case 6:*/
                            break;
                        case 4: case 5: case 9:
                            Instantiate(Basic_1, new Vector2(x, y + 5), Quaternion.identity);
                            Instantiate(Basic_1, new Vector2(-x, y + 5), Quaternion.identity);
                            break;
                        case 3:/**/ case 7: case 8:/* case 10: case 12:*/
                            Instantiate(Basic_2, new Vector2(x, y + 5), Quaternion.identity);
                            Instantiate(Basic_2, new Vector2(-x, y + 5), Quaternion.identity);
                            break;
                        case 10: case 11: case 12: case 13:/*case 11: case 13: case 15: case 18: case 19: case 20:*/
                            Instantiate(Basic_3, new Vector2(x, y + 5), Quaternion.identity);
                            Instantiate(Basic_3, new Vector2(-x, y + 5), Quaternion.identity);
                            break;
                        /*case 4:
                            Instantiate(Repulse_1, new Vector2(x, y + 5), Quaternion.identity);
                            Instantiate(Repulse_1, new Vector2(-x, y + 5), Quaternion.identity);
                            break;
                        case 5:
                            Instantiate(Laser_1, new Vector2(x, y + 5), Quaternion.identity);
                            Instantiate(Laser_1, new Vector2(-x, y + 5), Quaternion.identity);
                            break;*/
                        case 14: case 15: case 16:/*case 6:*/
                            Instantiate(Durable_1, new Vector2(x, y + 5), Quaternion.identity);
                            Instantiate(Durable_1, new Vector2(-x, y + 5), Quaternion.identity);
                            break;
                    }

                    if(x <= 1.5)// Instantiate something in the middle
                    {
                        Randomint = Random.Range(difficulty - 7, difficulty); // generate random number

                        switch (Randomint)
                        {// instantiate a random Enemy
                            // We have stopped working on special units so some numbers have been 
                            // commented out so they can be quickly restored if work on them resumes

                            case 4: case 5:/**/case 9: /*case 6:*/
                                break;
                            case 0: case 1: case 2:
                                Instantiate(Basic_1, new Vector2(0, y + 5), Quaternion.identity);
                                break;
                            case 3:/**/ case 7: case 8:/* case 10: case 12:*/
                                Instantiate(Basic_2, new Vector2(0, y + 5), Quaternion.identity);
                                break;
                            case 10: case 11: case 12: case 13:/*case 11: case 13: case 15: case 18: case 19: case 20:*/
                                Instantiate(Basic_3, new Vector2(0, y + 5), Quaternion.identity);
                                break;
                            /*case 7: case 14:
                                Instantiate(Repulse_1, new Vector2(0, y + 5), Quaternion.identity);
                                break;
                            case 8: case 16:
                                Instantiate(Laser_1, new Vector2(0, y + 5), Quaternion.identity);
                                break;*/
                            case 14: case 15: case 16: /*case 9: case 17:*/
                                Instantiate(Durable_1, new Vector2(0, y + 5), Quaternion.identity);
                                break;
                        }
                    }
                }
            }
            if (difficulty < 17)// after instantiating the bricks, increase difficulty
            {
                Debug.Log("difficulty up");
                difficulty++;
            }
        }
    }
}
