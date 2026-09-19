using System;
using System.Diagnostics; 

namespace Exam1_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub1 = new Subject(10, "C# Programming");

            sub1.CreateExam();

            Console.Clear();
            Console.WriteLine("Do You Want To Start Exam (Y | N)");

            if (Console.ReadLine().ToUpper() == "Y")
            {
                Console.Clear();

                Stopwatch sw = new Stopwatch();
                sw.Start();

                sub1.SubjectExam.ShowExam();

                sw.Stop();
                Console.WriteLine($"Time = {sw.Elapsed}");
                Console.WriteLine("Thank you");
            }

            Console.ReadLine();
        }
    }
}