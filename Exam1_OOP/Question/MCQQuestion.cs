using System;

namespace Exam1_OOP
{
    public class MCQQuestion : Question
    {
        public MCQQuestion(string body, int mark) : base("MCQ Question", body, mark)
        {
            AnswerList = new Answer[4];
        }

        public override object Clone()
        {
            return MemberwiseClone();
        }
    }
}