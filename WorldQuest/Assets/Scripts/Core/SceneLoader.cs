using UnityEngine;
using UnityEngine.SceneManagement;

namespace WorldQuest.Core
{
    public enum SceneIndex
    {
        TITLE,
        EDITOR,
        QUIZ
    }

    public class SceneLoader : MonoBehaviour
    {
        public void LoadScene(SceneIndex sceneIndex)
        {
            SceneManager.LoadScene((int)sceneIndex);
        }
    }
}
