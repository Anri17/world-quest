using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text scoreText;
    bool rightAnswer = false;

    //Initializes the Score from Data class
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = Data.scoreCount.ToString();
    }

    //Sets the new Data.score, and displays it
    public void ClickRightAnswer()
    {
        Data.scoreCount += 100;
        scoreText.text = Data.scoreCount.ToString();
        Debug.Log($"Score is {Data.scoreCount}");
        rightAnswer = true;
    }

    //Checks for answer and adds to the right or wrong answers.
    public void CheckQuestionAnswer()
    {
        if (rightAnswer)
        {
            Data.rightAnswerCount += 1;
            Debug.Log($"Number of Right Answers: {Data.rightAnswerCount}");
        }
        else
        {
            Data.wrongAnswerCount += 1;
            Debug.Log($"Number of Wrong Answers: {Data.wrongAnswerCount}");
        }
    }
}
