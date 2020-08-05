using System;
using System.Collections.Generic;
using System.Text;

namespace HjemmearbejdsOpgave
{
    public class Student
    {
        string name;
        string lastName;
        string emailAddress;
        Address addresse;
        List<Course> courseList = new List<Course>();
        int numberOfStudents = 0;

        public Student(string name, string lastName, string emailAddress, Address address, Course course)
        {
            this.name = name;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.addresse = address;
            courseList.Add(course);
            numberOfStudents++;
        }

        public List<Student> ReturnMembersOfCourse(Course course, Student student, string courseName)
        {
            List<Student> memberOf = new List<Student>();
            foreach (var studentMemberOf in course.WhoIsMemberOf(courseName: courseName, student))
            {
                memberOf.Add(studentMemberOf);
                //Console.WriteLine($"Medlem af {courseName}: {studentMemberOf.ReturnStudentInformation()}");
            }
            return memberOf;
        }

        public int ReturnTotalAmountOfStudents()
        {
            return numberOfStudents;
        }

        public string ReturnFullName()
        {
            return $"{name} {lastName}";
        }

        public string ReturnStudentInformation()
        {
            return $"{ReturnFullName()}\nEmail: {emailAddress}\n{addresse.ReturnAddress()}";
        }
    }
}
