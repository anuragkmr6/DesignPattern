using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Creational
{
    /// <summary>
    /// Separate the construction of a complex object from its representation so that the same construction process can create different representations.
    /// </summary>
    public class Builder
    {
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.CreateEngine();
            vehicleBuilder.CreateWheel();
        }
    }
    
    public abstract class VehicleBuilder
    {
        public Vehicle vehicle;
        public abstract void CreateEngine();
        public abstract void CreateWheel();
    }

    public class MotorcycleBuilder : VehicleBuilder
    {
        public MotorcycleBuilder()
        {
            vehicle = new Vehicle("Motorcycle");
        }
        public override void CreateEngine()
        {
            vehicle.parts.Add("Engine", "250cc");
        }

        public override void CreateWheel()
        {
            vehicle.parts.Add("Wheel", "2");
        }
    }

    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            vehicle = new Vehicle("Car");
        }
        public override void CreateEngine()
        {
            vehicle.parts.Add("Engine", "500cc");
        }

        public override void CreateWheel()
        {
            vehicle.parts.Add("Wheel", "4");
        }
    }

    public class Vehicle
    {
        private string type;
        internal Dictionary<string, string> parts = new Dictionary<string, string>();

        public Vehicle(string vehicleType)
        {
            type = vehicleType;
        }
        //Indexer

        //public string this[string key]
        //{
        //    get { return parts[key]; }
        //    set { parts[key] = value; }
        //}

        public void Show()
        {
            WriteLine($"Vehicle type : {type}");
            foreach (var part in parts)
            {
                WriteLine($"{part.Key} : {part.Value}");
            }
            WriteLine("----------------------------------------");

        }
    }
}
