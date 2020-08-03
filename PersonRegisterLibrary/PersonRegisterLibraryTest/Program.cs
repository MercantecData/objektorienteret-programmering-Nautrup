using System;
using System.Collections.Generic;
using PersonRegisterLibrary;

namespace PersonRegisterLibraryTest
{
    class Program
    {
        static List<Person> personList = new List<Person>();
        static bool isRunning = true;

        static void Main(string[] args)
        {
            CreatePersonRegister();
            Dictionaries();
            TestMethod();
            //Menu();
            //PrintRegister();
            //Dictionaries();
         
            Console.ReadKey();
        }

        static void TestMethod()
        {
            Dictionary<int, string> personDic = new Dictionary<int, string>();
            PersonDictionary ps = new PersonDictionary(name: "Lars Landkort", 22);
            personDic.Add(ps.age, ps.name);

        }

        static void Menu()
        {
            Console.WriteLine("1. Se register\n2.Tilføj ny");
            int input = int.Parse(Console.ReadLine());
           
            switch (input)
            {
                case 1:
                    PrintRegister();
                    break;
                case 2:
                    AddPersonToRegister();
                    break;
                default:
                    Console.WriteLine("Ugyldig indtastning");
                    break;
            }

        }

        static void Dictionaries()
        {
            Dictionary<string, int> numberStringValue = new Dictionary<string, int>();
            numberStringValue.Add("Et", 1);
            numberStringValue.Add("To", 2);
            numberStringValue.Add("Tre", 3);
            numberStringValue.Add("Fire", 4);
            numberStringValue.Add("Fem", 5);
            numberStringValue.Add("Seks", 6);
            numberStringValue.Add("Syv", 7);
            numberStringValue.Add("Otte", 8);
            numberStringValue.Add("Ni", 9);
            numberStringValue.Add("Ti", 10);

            foreach (var item in numberStringValue)
            {
                if (item.Value > 5)
                {
                    Console.WriteLine($"{item.Value} større end 5");
                }
                else if (item.Value == 5)
                {
                    Console.WriteLine($"{item.Value} det samme som 5");
                }
                else
                {
                    Console.WriteLine($"{item.Value} mindre end 5");
                }
                
            }

            Dictionary<bool, float> boolFloatValue = new Dictionary<bool, float>();
            boolFloatValue.Add(true, 1.0f);
            boolFloatValue.Add(false, 1.1f);
            // hvordan skal man kunne lave 10, når man kun har 2 keys og bruge?

            foreach (var item in boolFloatValue)
            {
                if (item.Value > 1.5f)
                {
                    Console.WriteLine($"1 + 1 = 2  {item.Value}");
                }
                else
                {
                    Console.WriteLine("1 + 2 = 2, aarrrh kan det nu passe?");
                }
            }

        }

        static void AddPersonToRegister()
        {
            Console.Write("Indtast navn: ");
            string inputName = Console.ReadLine();
            Console.Write("Indtast efternavn: ");
            string inputLastName = Console.ReadLine();
            Console.Write("Indtast alder: ");
            int inputAge = int.Parse(Console.ReadLine());
            Console.Write("Indtast by: ");
            string inputCity = Console.ReadLine();
            Console.Write("Indtast job: ");
            string inputJobTitle = Console.ReadLine();
            Console.Write("Indtast timeløn: ");
            int inputSalary = int.Parse(Console.ReadLine());
            Console.Write("Indtast job beskrivelse: ");
            string inputDescription = Console.ReadLine();

            Person newPerson = new Person(name: inputName, lastName: inputLastName, age: inputAge, city: inputCity, new Job(title: inputJobTitle, salary: inputSalary, description: inputDescription));
            personList.Add(newPerson);
            
            PrintRegister();
            BackToMenu();
        }

        static void PrintRegister()
        {
            Console.Clear();
            Console.WriteLine($"Personer i register: {personList.Count}");
            Console.WriteLine();
            foreach (var person in personList)
            {
                Console.WriteLine(person.ReturnPersonInformation());
                Console.WriteLine("----------------------------------");
            }
            BackToMenu();
        }

        static void BackToMenu()
        {
            Console.Write("Tilbage til menu? (y/m)");
           
            while (isRunning)
            {
                string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "y":
                        Console.Clear();
                        isRunning = false;
                        Menu();
                        break;
                    case "n":
                        isRunning = false;
                        break;
                    default:
                        Console.Write("Ugyldig værdi prøv igen (y/n):  ");
                        break;
                }
            }
            
        }

        static void CreatePersonRegister()
        {
            Person thomas = new Person(name: "Thomas", lastName: "Tændrør", age: 21, city: "Roslev", job: new Job(title: "Piberenser", salary: 189, "Han kan også rense din pibe ;)"));
            personList.Add(thomas);
            Person karsten = new Person(name: "Karsten", lastName: "510", age: 53, city: "Fur", job: new Job(title: "Septiktank renser", salary: 210, description: "Det fandeme noget lort."));
            personList.Add(karsten);
            Person tue = new Person(name: "Tue", lastName: "Ingolf", age: 32, city: "Viborg", job: new Job(title: "Prof. Skøjtedanser", salary: 189, description: "Kan drikke 100 bajere om dagen, uden og blæse over 0.5"));
            personList.Add(tue);

            
        }

    }
}
