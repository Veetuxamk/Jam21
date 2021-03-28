using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    //Points when destroy the block
    [SerializeField] int PointsperBlock = 15;

    // state variables
    [SerializeField] int currentScore = 0;

    //for text
    [SerializeField] TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreText.text = currentScore.ToString();
    }

    public void AddToScore()
    {
        currentScore += PointsperBlock;
        scoreText.text = currentScore.ToString();
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }
    //Line for the brick script FindObjectOfType<PlayerStats>().AddToScore();

}
