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
            jonasSkole.ReturnStudentCourse();
            MenuForTesting();
        }

        static void MenuForTesting()
        {
            Console.WriteLine("1. Se alle elever på skolen\n2. Se alle ansatte på skolen\n3. Se medlemmer af kursus\n4. Fjern Ansat\n5. Fjern Elev\n6. Ansatte fået løn");
            int input = int.Parse(Console.ReadLine());
            
            switch (input)
            {
                case 1:
                    Console.Clear();
                    jonasSkole.ReturnAllStudents();
                    Console.WriteLine("-------------------------------");
                    MenuForTesting();
                    break;
                case 2:
                    Console.Clear();
                    jonasSkole.ReturnAllEmployees();
                    Console.WriteLine("-------------------------------");
                    MenuForTesting();
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("Hvilket kursus vil du se?: ");
                    string courseInput = Console.ReadLine();
                    Console.WriteLine("-------------------------------");
                    MenuForTesting();
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("Fornavn på den ansatte du vil fjerne:");
                    string inputEmployeeName = Console.ReadLine();
                    jonasSkole.RemoveEmployee(inputEmployeeName);
                    Console.WriteLine("-------------------------------");
                    MenuForTesting();
                    break;
                case 5:
                    Console.Clear();
                    Console.Write("Fornavn på den elev du vil fjerne:");
                    string inputStudentName = Console.ReadLine();
                    jonasSkole.RemoveEmployee(inputStudentName);
                    Console.WriteLine("-------------------------------");
                    MenuForTesting();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Her kan du se om de ansatte er blevet betalt denne måned");
                    Console.WriteLine();
                    jonasSkole.IsEmployeePaied();
                    Console.WriteLine("-------------------------------");
                    MenuForTesting();
                    break;
                default:
                    Console.WriteLine("Ikke en gyldig værdi");
                    break;
            }
        }

        static void GenerateSchool()
        {
            jonasSkole.AddStudent(new Student("Thomas", "Tændrør", "tt@email.dk", new Address("Frysevej 1", "Selde", "7870", "Danmark"), new Course("Svensk", new Classroom("Svensk Lokale"))));
            jonasSkole.AddStudent(new Student("Tornado", "Kent", "tk@email.dk", new Address("Lemvigvej 2", "Lemvig", "7620", "Danmark"), new Course("Svensk", new Classroom("Svensk Lokale"))));
            jonasSkole.AddStudent(new Student("Benny", "Bumstærk", "bb@email.dk", new Address("Nautrup", "Nautrup", "7870", "Danmark"), new Course("Svensk", new Classroom("Svensk Lokale"))));
            
            jonasSkole.AddEmployee(new Employee("Lars", "Larsen", 190, "ll@email.dk", new Address("bumbum", "Bumber", "bum123", "Bummerland"), new Course("Svensk", new Classroom("Svensk Lokale"))));
            jonasSkole.AddEmployee(new Employee("Torsten", "Fetterøv", 182, "tf@email.dk", new Address("bla", "blah", "blahhh123", "Skodland"), new Course("IT", new Classroom("IT Lokale"))));
            //jonasSkole.ReturnAllStudents();
            //jonasSkole.ReturnAllEmployees();
        }
    }
}
