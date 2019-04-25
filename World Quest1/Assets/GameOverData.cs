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
        scoreText = GameObject.Find("ScoreCount").GetComponent<Text>();
        scoreText.text = Data.scoreCount.ToString();
        rightText = GameObject.Find("RightCount").GetComponent<Text>();
        rightText.text = Data.rightAnswerCount.ToString();
        wrongText = GameObject.Find("WrongCount").GetComponent<Text>();
        wrongText.text = Data.wrongAnswerCount.ToString();
    }
}
