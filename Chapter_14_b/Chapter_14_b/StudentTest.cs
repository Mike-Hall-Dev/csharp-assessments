using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_14_b
{
    class StudentTest
    {

        public bool GivenStudentDetails_PrintString() 
        {
            Student testStudent = new Student("Mr Bob", "bob@bob.com", "555-5555","DS & Algos", "Computer Science", "Mizzou");

            string actualString = testStudent.ToString();

            Console.WriteLine("Given Student Info, String is printed.");
            return actualString == "Mr Bob, 555-5555, bob@bob.com, DS & Algos, Computer Science, Mizzou";
        }

        public bool OnStudentInstantiation_ClassCounterIncrements()
        {
            Student testStudent = new Student("Mr Bob", "bob@bob.com", "555-5555", "DS & Algos", "Computer Science", "Mizzou");
            Student testStudent2 = new Student("Mr John", "john@john.com", "555-5555", "DS & Algos", "Computer Science", "Mizzou");

            Console.WriteLine("After instantiating 2 additonal students, the counter equals 3.");
            return Student.studentCount == 3;
        }
 



    }
}
