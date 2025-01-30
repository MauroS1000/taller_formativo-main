using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.Strategies
{
    public class StandardFuelStrategy : IFuelStrategy
    {
        private double _gas;
        private readonly double _fuelLimit;

        public StandardFuelStrategy(double fuelLimit)
        {
            _fuelLimit = fuelLimit;
        }

        public void AddFuel()
        {
            if (_gas >= _fuelLimit)
            {
                throw new Exception("Gas Full");
            }
            _gas += 0.1;
            Console.WriteLine("Gas added.");
        }
    }
}