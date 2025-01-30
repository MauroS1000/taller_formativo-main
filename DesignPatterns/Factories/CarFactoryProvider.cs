using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Factories
{
    public class CarFactoryProvider
    {
        private readonly Dictionary<string, Func<ICarFactory>> _factories;

        public CarFactoryProvider()
        {
            _factories = new Dictionary<string, Func<ICarFactory>>
            {
                { "Mustang", () => new FordMustangFactory() },
                { "Explorer", () => new FordExplorerFactory() },
                { "Escape", () => new FordEscapeFactory() }
            };
        }

        public ICarFactory GetFactory(string vehicleType)
        {
            if (_factories.TryGetValue(vehicleType, out var factory))
            {
                return factory();
            }
            throw new NotImplementedException($"Factory for {vehicleType} not implemented");
        }
    }
}