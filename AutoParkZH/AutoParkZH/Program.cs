using System;
using System.Collections.Generic;

namespace AutoParkZH
{
    public class Car
    {
        protected string label;
        protected int power;
        protected int yearOfPublish;

        public Car(string label, int power, int yearOfPublish)
        {
            this.label = label;
            this.power = power;
            this.yearOfPublish = yearOfPublish;
        }
    }
    public class PassengerCar : Car
    {
        private int numberOfPassengers;
        private Dictionary<string, int> repairBook; // запчасти - год замены
        public PassengerCar(string label, int power, int yearOfPublish, int numberOfPassengers) : base(label, power, yearOfPublish)
        {
            this.numberOfPassengers = numberOfPassengers;
            repairBook = new Dictionary<string, int>();
            
        }
        public void addToBook(string repairedPart, int yearOfTuning)
        {
            repairBook.Add(repairedPart, yearOfTuning);
        }
        public int findTuningYear(string name)
        {
            if (repairBook.ContainsKey(name)) return repairBook[name];
            return 0;
        }
        public void printBook()
        {
            foreach (string key in repairBook.Keys)
            {
                Console.Write(key + " - ");
                Console.WriteLine(repairBook[key]);
            }
            Console.WriteLine();
        }
        public override string ToString()
        {
            return $"Марка: {label}\nМощность:{power}\nГод производства: {yearOfPublish}\nКоличество пассажиров: {numberOfPassengers}\n\n";
        }
    }
    public class Truck : Car
    {
        private int maxWeight;
        private string nameSurname;
        Dictionary<string, int> cargo; // груз - масса

        public Truck(string label, int power, int yearOfPublish, int maxWeight, string nameSurname) : base(label, power, yearOfPublish)
        {
            this.maxWeight = maxWeight;
            this.nameSurname = nameSurname;
            cargo = new Dictionary<string, int>();
        }
        public void changeDriver(string nameSurname)
        {
            this.nameSurname = nameSurname;
        }
        public void addCargo(string name, int weight)
        {
            cargo.Add(name, weight);
        }
        public void removeCargo(string name)
        {
            if (!cargo.Remove(name)) Console.WriteLine("Нет такого груза!");
        }
        public void printCargo()
        {
            foreach (string key in cargo.Keys)
            {
                Console.Write(key + " - ");
                Console.WriteLine(cargo[key]);
            }
            Console.WriteLine();
        }
        public override string ToString()
        {
            return $"Марка: {label}\nМощность:{power}\nГод производства: {yearOfPublish}\nМаксимальная грузоподъёмность: {maxWeight}\nФИ водителя: {nameSurname}\n\n";
        }
    }
    public class AutoPark
    {
        private string parkName;
        public List<PassengerCar> passengerCars;
        public List<Truck> trucks;

        public AutoPark()
        {

        }
        public override string ToString()
        {
            string park = "";
            park += "ЛЕГКОВЫЕ МАШИНЫ\n";
            foreach (PassengerCar i in passengerCars)
            {
                park += i.ToString();
            }
            Console.WriteLine();
            foreach(Truck i in trucks)
            {
                park += i.ToString();
            }
            return park;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
