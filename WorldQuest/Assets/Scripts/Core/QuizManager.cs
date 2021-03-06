﻿using UnityEngine;

namespace WorldQuest.Core
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
