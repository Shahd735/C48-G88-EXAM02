using System;

namespace Exam1_OOP
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public void CreateExam()
        {
            Console.WriteLine("Enter the type of exam (1 for Practical, 2 for Final):");
            int examType = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the time for the exam (30 to 180 minutes):");
            int time = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of questions:");
            int numQ = int.Parse(Console.ReadLine());

            if (examType == 1)
                SubjectExam = new PracticalExam(time, numQ);
            else
                SubjectExam = new FinalExam(time, numQ);

            for (int i = 0; i < numQ; i++)
            {
                int qType = 1;
                if (examType == 2)
                {
                    Console.WriteLine($"Enter details for question {i + 1}:");
                    Console.WriteLine("Choose question type: 1 for MCQ, 2 for True/False:");
                    qType = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Please enter the question body:");
                string body = Console.ReadLine();

                Console.WriteLine("Please enter the question mark:");
                int mark = int.Parse(Console.ReadLine());

                if (qType == 1 || examType == 1)
                {
                    MCQQuestion mcq = new MCQQuestion(body, mark);

                    Console.WriteLine("Choices of Question:");
                    for (int j = 0; j < 4; j++)
                    {
                        Console.WriteLine($"Please enter choice number {j + 1}:");
                        string choice = Console.ReadLine();
                        mcq.AnswerList[j] = new Answer(j + 1, choice);
                    }

                    Console.WriteLine("Please enter the ID of the correct answer (1 to 4):");
                    int rightId = int.Parse(Console.ReadLine());

                    mcq.RightAnswer = mcq.AnswerList[rightId - 1];
                    SubjectExam.Questions[i] = mcq;
                }
                else
                {
                    TFQuestion tf = new TFQuestion(body, mark);

                    Console.WriteLine("Please enter the ID of the correct answer (1 for True, 2 for False):");
                    int rightId = int.Parse(Console.ReadLine());
                    tf.RightAnswer = tf.AnswerList[rightId - 1];

                    SubjectExam.Questions[i] = tf;
                }
            }
        }
    }
}