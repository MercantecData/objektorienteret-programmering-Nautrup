using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidDelegate();
            Floatdelegate();
            ParamDelegate();
        }

        public delegate void opgave1Delegate();
        public static void VoidDelegate()
        {
            opgave1Delegate opgave1 = () => Console.WriteLine("Opgave 1");
            opgave1();
        }

        public delegate float opgave2Delegate();
        public static void Floatdelegate()
        {
            opgave2Delegate opgave2 = () => 0.2f;
            
            Console.WriteLine($"Opgave 2 float værdi blev kaldt: {opgave2()}");
        }

        public delegate void opgave3Delgate(string firstName, string lastName, int age);
        public static void ParamDelegate()
        {
            opgave3Delgate opgave3 = (firstname, lastName, age) => Console.WriteLine($"Opgave 3 med parameter blev kaldt\nNavn: {firstname}\nEfternavn: {lastName}\nAlder: {age}");
            opgave3("Jonas", "Johansen", 22);
        }
    }
}
