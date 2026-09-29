using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_OOP
{
    public abstract class Exam
    {
        public int Time { get; set; } 
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = new Question[NumberOfQuestions];
        }
        public abstract void ShowExam();
    }
}
