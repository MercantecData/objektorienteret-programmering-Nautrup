using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassesAndInterfaces
{
    class Opgave3
    {
        public void RunOpgave3()
        {
            Console.WriteLine("Opgave 3\n\n");

            List<Person> personList = new List<Person>();
            personList.Add(new Person("John John", 22, Gender.Male));
            personList.Add(new Person("Tornado Torben", 55, Gender.Male));
            personList.Add(new Person("Kirsten Grydeske", 38, Gender.Female));
            personList.Add(new Person("Træsko Trine", 12, Gender.Female));
            personList.Add(new Person("Jyde Jonna", 92, Gender.Female));
            personList.Add(new Person("Enhjørningen Bent", 20, Gender.Other));
            personList.Add(new Person("Kartoffel Karsten", 72, Gender.Male));
            personList.Add(new Person("Jonas", 22, Gender.Other));
            personList.Add(new Person("Jonas", 22, Gender.Female));
            personList.Add(new Person("Jonas", 22, Gender.Male));

            personList.Sort();

            Console.WriteLine("Efter sortering:\n");
            foreach (var person in personList)
            {
               Console.WriteLine(person.ReturnPersonInformation());
            }
        }
    }

    public class Person : IComparable
    {
        string name;
        int age;
        Gender gender;

        public Person(string name, int age, Gender gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public int CompareTo(object obj)
        {
            Person person = (Person)obj;

            int result = age.CompareTo(person.age);     

            if (result == 0)
            {
                result = age - person.age;
            }

            if (result == 1)
            {
                result = gender.CompareTo(person.gender);
            }

            return result;
         }

        public string ReturnPersonInformation ()
        {
            return $"{name} {age} {gender}";
        }
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}
