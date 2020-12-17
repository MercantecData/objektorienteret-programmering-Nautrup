using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassesAndInterfaces
{
    class Opgave1
    {
        public void RunOpgave1()
        {
            Car suv = new Suv("Ford", "Kuga");
            suv.Drive();
            suv.Brake();

            Car sportscar = new Sportscar("Toyota", "Supra");
            sportscar.Drive();
            sportscar.Brake();

            Car budgetCar = new BudgetCar("Citroen", "C1");
            budgetCar.Drive();
            budgetCar.Brake();
        }
    }

    public abstract class Car
    {
        public string manufacturer;
        public string model;

        protected Car(string manufacturer, string model)
        {
            this.manufacturer = manufacturer;
            this.model = model;
        }

        public abstract void Drive();

        public string Brake()
        {
            return $"{manufacturer} {model} is braking.";
        }
    }

    public class Suv : Car
    {
        public Suv(string manufacturer, string model) : base(manufacturer, model)
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"{manufacturer} {model} er en stor bil.");
        }
    }

    public class Sportscar : Car
    {
        public Sportscar(string manufacturer, string model) : base(manufacturer, model)
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"{manufacturer} {model} siger vrooooom, pew pew.");
        }
    }

    public class BudgetCar: Car
    {
        public BudgetCar(string manufacturer, string model) : base(manufacturer, model)
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"{manufacturer} {model} er en bil til fornuftige penge");
        }
    }
}
