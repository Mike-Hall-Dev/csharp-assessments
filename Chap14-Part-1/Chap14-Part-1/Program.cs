using System;
using System.Collections.Generic;
using System.Text;

namespace Chap14_Part_1
{
    class Program
    {
        static void Main()
        {
            Student studentOne = new Student();
            Student studentTwo = new Student("Bob Ross");
            Student studentThree = new Student("Philip J Fry", "Fundamentals of Computer Programming");
            Student studentFour = new Student("Ric Flair", "Code 101", "Computer Science", "University of Missouri");
            StudentTest testing = new StudentTest(studentOne, studentTwo, studentThree, studentFour);
            testing.PrintStudents();
        }
    }
}
