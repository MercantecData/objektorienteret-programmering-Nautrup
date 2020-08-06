using System;
using System.Collections.Generic;
using System.Text;

namespace HjemmearbejdsOpgave
{
    public class School
    {
        List<Student> studentList = new List<Student>();
        List<Employee> employeeList = new List<Employee>();
        List<Course> courseList = new List<Course>();

        public void IsEmployeePaied()
        {
            foreach (var item in employeeList)
            {
                Console.WriteLine($"{item.name} har fået løn: {item.IsEmployeePaied()}");
            }
        }

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

        /// <summary>
        /// Skriv kun fornavnet på den ansatte du vil fjerne
        /// </summary>
        public void RemoveEmployee(string employeeName)
        {
            for (int i = 0; i < employeeList.Count; i++)
            {
                if (employeeName == employeeList[i].name)
                {
                    employeeList.Remove(employeeList[i]);
                    Console.WriteLine($"{employeeName} er blevet fjernet");
                }
            }
            
        }

        /// <summary>
        /// Skriv kun fornavnet på den elev du vil fjerne.
        /// </summary>
        /// <param name="studentName">Navnet på eleven</param>
        public void RemoveStudent(string studentName)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentName == studentList[i].name)
                {
                    studentList.Remove(studentList[i]);
                    Console.WriteLine($"{studentName} er blevet fjernet");
                }
            }
        }


        public void ReturnStudentCourse()
        {
            foreach (var i in studentList)
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
            for (int i = 0; i < studentList.Count; i++)
            {
                Console.WriteLine(studentList[i].PrintcourseList());
            }
        }


        public void ReturnEmployeeCourses()
        {
            //List<Course> courses = new List<Course>();

            foreach (var item in employeeList)
            {
                Console.WriteLine($"{item.name} underviser i : {item.ReturnCoursesHeTeaches()}");
            }
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
