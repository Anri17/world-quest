using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class btn : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;

    public float delay = 440f;
    
  
     public void OnClick ()
     {
        StartCoroutine(LoadLevelAfterDelay(delay));
        button1.interactable = false;
        button2.interactable = false;
        button3.interactable = false;
    }
 
     IEnumerator LoadLevelAfterDelay(float delay)
     {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
     }
 
       

}
