using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WorldQuest.Quiz
{
    public class Quiz
    {
        public int Size { get => Questions.Count; }
        public List<Question> Questions { get; set; }
    }
}
