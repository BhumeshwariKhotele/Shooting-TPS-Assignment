using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreBoard : MonoBehaviour
{
    public Text scoreText;
    public int score;

    public void Increment(int value)
    {
        score += value;
        scoreText.text = "Score :" + score;
    }
}
