﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
