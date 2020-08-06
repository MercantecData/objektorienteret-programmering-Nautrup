using System;
using System.Collections.Generic;
using System.Text;

namespace HjemmearbejdsOpgave
{
    public class Employee
    {
        public string name;
        string lastName;
        decimal salary;
        bool payed;
        string emailAddress;
        List<Course> courses = new List<Course>();
        Address address;
        int numberOfEmployees;

        public Employee(string name, string lastName, decimal salary, string emailAddress, Address address, Course course)
        {
            this.name = name;
            this.lastName = lastName;
            this.salary = salary;
            this.emailAddress = emailAddress;
            this.address = address;
            this.courses.Add(course);

            numberOfEmployees++;
        }

        public bool IsItPayday() // Checks if an employees payments day is now
        {
            DateTime createDate = new DateTime(2020, 8, DateTime.DaysInMonth(2020, 8));
            if (DateTime.Now < createDate) // Not payed
            {
                payed = false;
                return payed;
            }
            else // Payed
            {
                payed = true;
                return payed;
            }
        }
        
        public List<Course> ReturnCoursesHeTeaches() // Gets all the courses a employee has
        {
            List<Course> coursesList = new List<Course>();
            for (int i = 0; i < courses.Count; i++)
            {
                coursesList.Add(courses[i]);
            }

            //foreach (var course in courses)
            //{
            //    coursesList.Add(course);
            //}
            return coursesList;
        }

        public string ReturnFullName() // returns an employees full name
        {
            return $"{name} {lastName}";
        }

        public string ReturnEmployeeInformation() // returns all information about an employee
        {
            return $"{ReturnFullName()}\nTimeløn: {salary}\nEmail: {emailAddress}";
        }
    }
}
