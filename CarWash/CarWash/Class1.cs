using System;
using System.Collections.Generic;

namespace CarWash
{
    public class Car
    {
        public string Name;
        public string Color;
        public bool Dirt;
        public Car(string name, string color, bool dirt)
        {
            Name = name;
            Color = color;
            Dirt = dirt;
        }
    }
    public class Garage
    {
        public List<Car> Box = new List<Car>();
        public void Add(Car item)
        {

            Box.Add(item);
        }
    }
    public class Washer
    {
        public static Garage CleanCar(Garage garage)
        {
            foreach (Car car in garage.Box)
            {
                if (car.Dirt == true)
                {
                    car.Dirt = false;
                    Console.WriteLine($"{car.Name} помыта");
                }
                else
                {
                    Console.WriteLine($"{car.Name} не грязная");
                }
            }
            return garage;
        }
    }
    class MainProgram
    {
        delegate Garage Cleaner(Garage garage);
        public static void Main()
        {
            Cleaner cleanGarage;
            cleanGarage = Washer.CleanCar;
            Garage garage = new Garage();
            Car toyota = new Car("Toyta","Red",true);
            Car lada = new Car("Granta", "White", false);
            garage.Add(toyota);
            garage.Add(lada);
            cleanGarage(garage);
            
        }
    }
}