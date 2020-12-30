using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverData : MonoBehaviour
{
    Text scoreText;
    Text rightText;
    Text wrongText;

    void Start()
    {
        SetDependencies();
        SetScore();
    }

    void SetDependencies()
    {
        scoreText = GameObject.Find("ScoreCount").GetComponent<Text>();
        rightText = GameObject.Find("RightCount").GetComponent<Text>();
        wrongText = GameObject.Find("WrongCount").GetComponent<Text>();
    }

    void SetScore()
    {
        scoreText.text = Data.scoreCount.ToString();
        rightText.text = Data.rightAnswerCount.ToString();
        wrongText.text = Data.wrongAnswerCount.ToString();
    }
}
