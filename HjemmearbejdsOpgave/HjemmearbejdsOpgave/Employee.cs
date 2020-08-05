using System;
using System.Collections.Generic;
using System.Text;

namespace HjemmearbejdsOpgave
{
    public class Employee
    {
        string name;
        string lastName;
        decimal salary;
        string emailAddress;
        List<Course> courses;
        int numberOfEmployees;

        public Employee(string name, string lastName, decimal salary, string emailAddress)
        {
            this.name = name;
            this.lastName = lastName;
            this.salary = salary;
            this.emailAddress = emailAddress;
            courses = new List<Course>();
            numberOfEmployees++;
        }

        public int ReturnTotalAmountOfEmployees()
        {
            return numberOfEmployees;
        }

        public string ReturnFullName()
        {
            return $"{name} {lastName}";
        }

        public string ReturnEmployeeInformation()
        {
            return $"{ReturnFullName()}\nTimeløn: {salary}\nEmail: {emailAddress}";
        }
    }
}
