using System;
using System.Collections.Generic;

namespace PersonRegisterLibrary
{
    public class Person
    {
        string name;
        string lastName;
        int age;
        string city;
        Job job;
        List<Person> personList = new List<Person>();
        int numberOfPersons = 0;

        public Person(string name, string lastName, int age, string city, Job job)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.city = city;
            this.job = job;
            personList.Add(this);
            numberOfPersons++;
        }
        
        public void AddPerson(Person person)
        {
            person = new Person(this.name, this.lastName, this.age, this.city, this.job);
        }

        public Person FindPerson(string nameToFind)
        {
            foreach (Person pers in personList)
            {
                if (nameToFind == pers.name)
                {
                    Console.WriteLine($"{nameToFind} blev fundet!\nHer er hans informationer:\n\n{pers.ReturnPersonInformation()}");
                    return pers;
                }
                else
                {
                    Console.WriteLine($"Ingen med navnet: \"{nameToFind}\" blev ikke fundet");
                }
            }
            return null;
        }

        public void EditPersonFromRegister(Person person)
        {
            // Find bruger
            // ændre værdi
            // Gem ny værdi
        }

        public string ReturnNuberOfPersonRegisteret()
        {
            return $"{numberOfPersons}";
        }

        public string ReturnPersonInformation ()
        {
            return $"Navn: {name} {lastName}\nAlder: {age}\nBy: {city}\nJob: {job.ReturnJobDescription()}";
        }
    }
}
