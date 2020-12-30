using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WorldQuest.Question
{
    public class Quiz
    {
        public int Size { get => Questions.Count; }
        public List<Question> Questions { get; set; }
    }
}
