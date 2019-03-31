using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    //Storage of variables through out scenes
    public static int scoreCount = 0;
    public static int rightAnswerCount = 0;
    public static int wrongAnswerCount = 0;

    //Dont delete when scene changes. (maybe you dont need this after all. It works without it)
    /*private void Awake()
    {
        DontDestroyOnLoad(this);
    }*/
}
