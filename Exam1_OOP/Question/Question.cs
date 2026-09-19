using System;

namespace Exam1_OOP
{
    public abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }
        public Answer UserAnswer { get; set; }

        public Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        public override string ToString()
        {
            return $"{Header}:\t Mark {Mark}";
        }

        public int CompareTo(Question other)
        {
            return Mark.CompareTo(other?.Mark ?? 0);
        }

        public abstract object Clone();
    }
}