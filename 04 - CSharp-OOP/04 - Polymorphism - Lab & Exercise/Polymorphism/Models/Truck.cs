﻿using System;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double AirConditionerModifier = 1.6;
        private const double RefuelSuccesfulCoefficient = 0.95;

        public Truck(double fuelQuantity, double litersPerKM)
            : base(fuelQuantity, litersPerKM)
        {
        }

        public override double FuelConsumption
            => base.FuelConsumption + AirConditionerModifier;

        public override void Refuel(double liters)
        {
            base.Refuel(liters * RefuelSuccesfulCoefficient);
        }
    }
}
