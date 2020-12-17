using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassesAndInterfaces
{
    class Opgave2
    {
        public void RunOpgave2()
        {
            Console.WriteLine("Opgave 2\n\n");

            Animal newAnimal = new Animal();
            newAnimal.SetName("Peter Pedal");
            Console.WriteLine($"Navn på dyret er: {newAnimal.GetName()}");
            Console.WriteLine($"Dyrets gamle navn var: {newAnimal.Rename("Peter Plys")} og er nu {newAnimal.GetName()}");

            Humanoid person = new Humanoid();
            person.SetName("Torsten Træsko");
            Console.WriteLine($"Navn på dyret er: {person.GetName()}");
            Console.WriteLine($"Dyrets gamle navn var: {person.Rename("Karsten 510")} og er nu {person.GetName()}");

        }
    }

    public interface INameable
    {
        string GetName();
        void SetName(string name);
        string Rename(string newName);
    }

    public class Animal : INameable
    {
        string animalName;
        public Animal()
        {
            SetName("Lurendrejer");
        }

        public string GetName()
        {
            return animalName;
        }

        public string Rename(string newName)
        {
            string oldName = this.animalName;
            this.animalName = newName;
            return oldName;
        }

        public void SetName(string name)
        {
            this.animalName = name;
        }
    }

    public class Humanoid : INameable
    {
        string name;
        public Humanoid()
        {
            SetName("Søren Pind");
        }

        public string GetName()
        {
            return name;
        }

        public string Rename(string newName)
        {
            string oldName = this.name;
            this.name = newName;
            return oldName;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
