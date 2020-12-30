using System.Collections.Generic;

namespace WorldQuest.Question
{
    public static class QuizFactory
    {
        public static Quiz CreateQuiz(List<Question> questions)
        {
            return new Quiz()
            {
                Questions = questions
            };
        }

        public static Question CreateQuestion(string statement, List<Answer> options)
        {
            return new Question()
            {
                Statement = statement,
                Options = options
            };
        }

        public static Answer CreateAnswer(string statement, bool isCorrect)
        {
            return new Answer()
            {
                Statement = statement,
                IsCorrect = isCorrect
            };
        }
    }
}
