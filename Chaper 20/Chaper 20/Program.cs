using System;
using System.Collections.Generic;

namespace Chaper_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Question3();
            Question4();
        }

        static void Question3()
        {
            List<Student> students = new List<Student> {
                new Student(30), new Student(90), new Student(35), new Student(10), new Student(80),
                new Student(92), new Student(70), new Student(82),new Student(79),new Student(89)};
            students.Sort();
            foreach (Student student in students) Console.WriteLine(student.Mark);
        }

        static void Question4()
        {
            List<Worker> workers = new List<Worker>
            {
                new Worker(10000m,40), new Worker(3000m,40), new Worker(15000m,40), new Worker(9000m,40), new Worker(13000m,40),
                new Worker(900m,40), new Worker(2000m,40), new Worker(3000m,40), new Worker(1222m,40), new Worker(9999m, 40)
            };

            workers.Sort();
            workers.Reverse();
            foreach (Worker worker in workers) Console.WriteLine(worker.CalculateHourlyWage());
        }
    }
}
