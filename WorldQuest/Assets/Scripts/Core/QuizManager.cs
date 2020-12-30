using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WorldQuest
{
    public class QuizManager : MonoBehaviour
    {
        public static QuizManager Instance { get; private set; }

        private void Awake()
        {
            CreateSingleton();
        }

        private void CreateSingleton()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
                DontDestroyOnLoad(this);
            }
        }
    }
}
