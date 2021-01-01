using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {

    void Start()
    {
        Data.scoreCount = 0;
        Debug.Log($"Score count is {Data.scoreCount}");
        Data.rightAnswerCount = 0;
        Debug.Log($"Right answer count is {Data.rightAnswerCount}");
        Data.wrongAnswerCount = 0;
        Debug.Log($"Wrong answer count is {Data.wrongAnswerCount}");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadQuizEditor()
    {
        SceneManager.LoadScene("QuizEditor");
    }

    public void OptionsMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
         
}

