using System;
using System.Collections.Generic;
using System.Text;

namespace HjemmearbejdsOpgave
{
    public class Student
    {
        public string name;
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


        public void PrintcourseList()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < courseList.Count; i++)
            {
                list.Add(courseList[i].name);
                Console.WriteLine(name + " har: " +courseList[i].name);
            }
            //foreach (var item in courseList)
            //{
            //    list.Add(item.ReturnCourseList(item.name));
            //}
            
        }

        public int ReturnTotalAmountOfStudents() // Returns a number for how many studens there is
        {
            return numberOfStudents;
        }

        public string ReturnFullName() // returns student fullname
        {
            return $"{name} {lastName}";
        }

        public string ReturnStudentInformation( ) // returns all information about a student
        {
            return $"{ReturnFullName()}\nEmail: {emailAddress}\n{addresse.ReturnAddress()}";
        }
    }
}
