using System;
using System.Collections.Generic;
using HjemmearbejdsOpgave;

namespace ConsoleUserInterface
{
    class Program
    {
        static List<Student> allstudents = new List<Student>();
        static School jonasSkole = new School();

        static void Main(string[] args)
        {
            GenerateSchool();
            MenuForTesting();
        }

        static void MenuForTesting()
        {
            Console.WriteLine("1. Se alle elever på skolen\n2. Se alle ansatte på skolen\n3. Se medlemmer af kursus");
            int input = int.Parse(Console.ReadLine());
            
            switch (input)
            {
                case 1:
                    jonasSkole.ReturnAllStudents();
                    MenuForTesting();
                    break;
                case 2:
                    jonasSkole.ReturnAllEmployees();
                    MenuForTesting();
                    break;
                case 3:
                    
                default:
                    Console.WriteLine("Ikke en gyldig værdi");
                    break;
            }
        }

        static void GenerateSchool()
        {
            jonasSkole.AddStudent(new Student("Thomas", "Tændrør", "tt@email.dk", new Address("Frysevej 1", "Selde", "7870", "Danmark"), new Course("Svensk", new Classroom("Svensk Lokale"))));
            jonasSkole.AddStudent(new Student("Tornado", "Kent", "tk@email.dk", new Address("Lemvigvej 2", "Lemvig", "7620", "Danmark"), new Course("Svensk", new Classroom("Svensk Lokale"))));
            jonasSkole.AddEmployee(new Employee("Lars", "Larsen", 190, "ll@email.dk"));

            jonasSkole.ReturnAllStudents();
            jonasSkole.ReturnAllEmployees();
        }

        // old (beholdes indtil andet er lavet)
        static void CreateStudent()
        {
            Student student1 = new Student("Thomas", "Tændrør", "tt@email.dk", new Address("Frysevej 1", "Selde", "7870", "Danmark"), new Course("Svensk", new Classroom("Svensk Lokale")));
            allstudents.Add(student1);
            Student student2 = new Student("Tornado", "Kent", "tk@email.dk", new Address("Lemvigvej 2", "Lemvig", "7620", "Danmark"), new Course("Svensk", new Classroom("Svensk Lokale")));
            allstudents.Add(student2);

            foreach (var student in allstudents)
            {
                Console.WriteLine(student.ReturnStudentInformation());
                Console.WriteLine("--------------------------------------------");
            }
        }
    }
}
