using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_14_b
{
    public class Student
    {
        public string FullName { get; set; }
        public string Course { get; set; }
        public string Subject { get; set; }
        public string University { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public static int studentCount = 0;

        public Student(string name, string phone, string email, string course = null, string subject = null, string university = null)
        {
            this.FullName = name;
            this.Email = email;
            this.PhoneNumber = phone;
            this.Course = course;
            this.Subject = subject;
            this.University = university;

            studentCount += 1;
        }


        override public string ToString()
        {
            return $"{FullName}, {Email}, {PhoneNumber}, {Course}, {Subject}, {University}";
        }


    }
}
