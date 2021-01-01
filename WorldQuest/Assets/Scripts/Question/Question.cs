﻿using System.Collections.Generic;

namespace WorldQuest.Quiz
{
    public class Question
    {
        public int Size { get => Options.Count; }
        public string Statement { get; set; }
        public List<Answer> Options { get; set; }
    }
}
