using System;
using System.Collections.Generic;
using System.Text;

namespace Chap14_Part_1
{
    class Student
    {
        private string fullName;
        private string course;
        private string subject;
        private string university;
        private string email;
        private string phone;

        public string FullName
        {
            get { return this.fullName; }
            set { this.fullName = value; }
        }

        public string Course
        {
            get { return this.course; }
            set { this.course = value; }
        }

        public string Subject
        {
            get { return this.subject; }
            set { this.subject = value; }
        }

        public string University
        {
            get { return this.university; }
            set { this.university = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string PhoneNumber
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public Student()
            : this(null)
        {
        }
        public Student(string name)
            : this(name, null)
        {
        }
        public Student(string name, string course)
            : this(name, course, null)
        {
        }
        public Student(string name, string course, string subject)
            : this(name, course, subject, null)
        {
        }
        public Student(string name, string course, string subject, string university)
            : this(name, course, subject, university, null)
        {
        }
        public Student(string name, string course, string subject, string university, string email)
            : this(name,course,subject,university,email, null)
        {
        }
        public Student(string name, string course, string subject, string university, string email, string phone )
        {
            this.fullName = name;
            this.course = course;
            this.subject = subject;
            this.university = university;
            this.email = email;
            this.phone = phone;
        }

        public void Display()
        {

            Console.WriteLine("Name: " + this.fullName);
            Console.WriteLine("Course: " + this.course);
            Console.WriteLine("Subject: " + this.subject);
            Console.WriteLine("University: " + this.university);
            Console.WriteLine("Email: " + this.email);
            Console.WriteLine("Phone number: " + this.phone);
            Console.WriteLine();
        }
    }

    class StudentTest
    {

        private Student studentOne;
        private Student studentTwo;
        private Student studentThree;
        private Student studentFour;

        private Student StudentOne { get => studentOne; set => studentOne = value; }
        private Student StudentTwo { get => studentTwo; set => studentTwo = value; }
        private Student StudentThree { get => studentThree; set => studentThree = value; }
        private Student StudentFour { get => studentFour; set => studentFour = value; }

        public StudentTest()
        {}

        public StudentTest(Student one, Student two, Student three, Student four)
        {
            StudentOne = one;
            StudentTwo = two;
            StudentThree = three;
            StudentFour = four;
        }

        public void PrintStudents()
        {
            studentOne.Display();
            studentTwo.Display();
            studentThree.Display();
            studentFour.Display();
        }
    }
}
