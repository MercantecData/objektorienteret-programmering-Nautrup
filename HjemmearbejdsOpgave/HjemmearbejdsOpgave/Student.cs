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


        public List<string> PrintcourseList()
        {
            foreach (var i in courseList)
            {
                switch (i)
                {
                    case IEnumerable<object> li:
                        Console.WriteLine($"List: {string.Join(", ", li)}");
                        break;
                    default:
                        Console.WriteLine(i);
                        break;
                }
            }
            List<string> list = new List<string>();
            for (int i = 0; i < courseList.Count; i++)
            {
                list.Add(courseList[i].name);
            }
            //foreach (var item in courseList)
            //{
            //    list.Add(item.ReturnCourseList(item.name));
            //}
            return list;
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
