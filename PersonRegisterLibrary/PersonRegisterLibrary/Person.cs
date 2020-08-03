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
        List<Person> personList;

        int numberOfPersons = 0;

        public Person(string name, string lastName, int age, string city, Job job)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.city = city;
            this.job = job;
            numberOfPersons++;
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
