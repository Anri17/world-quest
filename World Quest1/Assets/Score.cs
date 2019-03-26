using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Button rightAnswer;
    private int score;

    void Start()
    {
        rightAnswer.onClick.AddListener(() => ButtonClicked());
    }

    private void ButtonClicked()
    {
        score += 100;
        Debug.Log($"Score is {score}");
    }

    void Update()
    {

    }
}
