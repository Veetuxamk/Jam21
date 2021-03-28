using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //Points when destroy the block
    [SerializeField] int PointsperBlock = 15;

    // state variables
    [SerializeField] int currentScore = 0;

    public void AddToScore()
    {
        currentScore += PointsperBlock;
    }
    //Line for the brick script FindObjectOfType<PlayerStats>().AddToScore();

}
