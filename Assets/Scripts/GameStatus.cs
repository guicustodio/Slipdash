using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    [SerializeField] int scorePointsPerCoin;
    [SerializeField] public int currentScore = 0;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] SpriteRenderer door;
    [SerializeField] GameObject player;

    //Instantiate(player, new Vector3(-21.5f, -10.5f, 0), Quaternion.identity);

    void Start()
    {
        {
            scoreText.text = currentScore.ToString();
        }
    }

    public void AddToScore() {
        currentScore += scorePointsPerCoin;
        scoreText.text = currentScore.ToString();
    }
}
