﻿using System;

namespace CarManufacturer
{
    public class Car
    {
        private string make;

        private string model;

        private int year;

        private double fuelQuantity;

        private double fuelConsumption;

        private Engine engine;

        private Tire[] tires;

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        public string Make { get => this.make; set => this.make = value; }

        public string Model { get => this.model; set => this.model = value; }

        public int Year { get => this.year; set => this.year = value; }
        
        public double FuelQuantity { get => this.fuelQuantity; set => this.fuelQuantity = value; }
        
        public double FuelConsumption { get => this.fuelConsumption; set => this.fuelConsumption = value; }

        public Engine Engine { get => this.engine; set => this.engine = value; }
        
        public Tire[] Tires { get => this.tires; set => this.tires = value; }

        public void Drive(double distance)
        {
            double totalFuelNeeded = distance * this.FuelConsumption / 100;
            if (this.FuelQuantity - totalFuelNeeded > 0)
            {
                this.FuelQuantity -= totalFuelNeeded;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L";
        }
    }
}
