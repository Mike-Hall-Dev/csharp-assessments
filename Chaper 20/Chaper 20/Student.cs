using System;
using System.Collections.Generic;
using System.Text;

namespace Chaper_20
{
    class Student : Human, IComparable<Student>
    {
        public int Mark { get; set; }

        public Student(int mark)
        {
            Mark = mark;
        }

        public int CompareTo(Student other)
        {
            return Mark.CompareTo(other.Mark);
        }
    }
}
