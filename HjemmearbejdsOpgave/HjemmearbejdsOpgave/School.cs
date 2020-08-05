using System;
using System.Collections.Generic;
using System.Text;

namespace HjemmearbejdsOpgave
{
    public class School
    {
        List<Student> studentList = new List<Student>();
        List<Employee> employeeList = new List<Employee>();

        public List<Student> AddStudent(Student person)
        {
            studentList.Add(person);
            return studentList;
        }

        public List<Employee> AddEmployee(Employee employee)
        {
            employeeList.Add(employee);
            return employeeList;
        }


        public List<Student> ReturnMembersOfCourse(string courseName)
        {
            List<Student> memberOf = new List<Student>();
            foreach (var studentMemberOf in studentList) 
            {
                memberOf.Add(studentMemberOf);
                //Console.WriteLine($"Medlem af {courseName}: {studentMemberOf.ReturnStudentInformation()}");
            }
            return memberOf;
        }

        public void ReturnAllStudents()
        {

            foreach (var student in studentList)
            {
                Console.WriteLine($"{student.ReturnStudentInformation()} (Elev)");
                Console.WriteLine("-------------------------------");
            }
        }

        public void ReturnAllEmployees()
        {
            foreach (var employee in employeeList)
            {
                Console.WriteLine($"{employee.ReturnEmployeeInformation()} (Ansat)");
                Console.WriteLine("-------------------------------");
            }
        }
    }
}
