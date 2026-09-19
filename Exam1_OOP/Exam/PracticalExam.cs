using System;
using System.Linq;

namespace Exam1_OOP
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions) { }

        public override void ShowExam()
        {
            int totalGrade = 0;
            int totalMarks = 0;

            foreach (var q in Questions)
            {
                Console.WriteLine("Practical Exam");
                Console.WriteLine($"Question {Array.IndexOf(Questions, q) + 1}: {q.Body}");
                Console.WriteLine(q.ToString());

                foreach (var ans in q.AnswerList)
                {
                    Console.WriteLine(ans.ToString());
                }

                Console.WriteLine("Enter your answer ID:");
                int userId = int.Parse(Console.ReadLine());

                var userAnswerText = q.AnswerList.FirstOrDefault(a => a.AnswerId == userId)?.AnswerText ?? "Unknown";
                q.UserAnswer = new Answer(userId, userAnswerText);

                totalMarks += q.Mark;
                if (q.UserAnswer.AnswerId == q.RightAnswer.AnswerId)
                {
                    totalGrade += q.Mark;
                }
                Console.WriteLine("==============================================");
            }

            Console.Clear();
            Console.WriteLine("Practical Exam Results:");
            for (int i = 0; i < Questions.Length; i++)
            {
                var q = Questions[i];
                Console.WriteLine($"Question {i + 1}: {q.Body}");
                Console.WriteLine($"Your Answer => {q.UserAnswer.AnswerText}");
                Console.WriteLine($"Correct Answer => {q.RightAnswer.AnswerText}");
                Console.WriteLine();
            }
            Console.WriteLine($"Your Grade is {totalGrade} from {totalMarks}");
        }
    }
}