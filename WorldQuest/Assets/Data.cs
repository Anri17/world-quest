using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    //Storage of variables through out scenes
    public static int scoreCount = 0;
    public static int rightAnswerCount = 0;
    public static int wrongAnswerCount = 0;

    public static void ResetData()
    {
        scoreCount = 0;
        rightAnswerCount = 0;
        wrongAnswerCount = 0;
    }
}
