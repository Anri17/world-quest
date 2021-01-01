using System.Collections.Generic;
using UnityEngine;
using WorldQuest.Quiz;

namespace WorldQuest.QuizEditor
{
    public class QuizEditorManager : MonoBehaviour
    {
        Quiz.Quiz newQuiz;

        public void OnNewQuizButton()
        {
            newQuiz = QuizFactory.CreateQuiz(new List<Question>());
        }
    }
}
