using DesignPatterns.Models;
using System;

namespace DesignPatterns.Decorators
{
    public class TurboDecorator : VehicleDecorator
    {
        public TurboDecorator(Vehicle vehicle)
            : base(vehicle)
        {
        }

        public void ActivateTurbo()
        {
            Console.WriteLine("Turbo activated!");
        }
    }
}