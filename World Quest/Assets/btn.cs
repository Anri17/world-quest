using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class btn : MonoBehaviour
{

  
    public float delay = 440;
    
  
     public void OnClick ()
     {
         StartCoroutine(LoadLevelAfterDelay(delay));
        
     }
 
     IEnumerator LoadLevelAfterDelay(float delay)
     {
         yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
     }
 
       

}
