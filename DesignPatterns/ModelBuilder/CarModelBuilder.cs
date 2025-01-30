using DesignPatterns.Models;
using DesignPatterns.Vehicles;
using DesignPatterns.Strategies; // Importar estrategias
using System;
using DesignPatterns.Interfaces;

namespace DesignPatterns.ModelBuilder
{
    public class CarModelBuilder
    {
        private string color = "red";
        private string brand = "Ford";
        private string model = "Mustang"; // Asegurar que esta variable existe
        private int year = DateTime.Now.Year;
        private IEngineStrategy engineStrategy = new StandardEngineStrategy();
        private IFuelStrategy fuelStrategy = new StandardFuelStrategy(10);

        public CarModelBuilder setColor(string color)
        {
            this.color = color;
            return this;
        }
        public CarModelBuilder setBrand(string brand)
        {
            this.brand = brand;
            return this;
        }

        public CarModelBuilder setModel(string model)
        {
            this.model = model;
            return this;
        }

        public CarModelBuilder setYear(int year)
        {
            this.year = year;
            return this;
        }

        public CarModelBuilder setEngineStrategy(IEngineStrategy strategy)
        {
            this.engineStrategy = strategy;
            return this;
        }

        public CarModelBuilder setFuelStrategy(IFuelStrategy strategy)
        {
            this.fuelStrategy = strategy;
            return this;
        }

        public Vehicle Build()
        {
            // Ahora pasamos correctamente el parámetro 'model'
            return new Car(engineStrategy, fuelStrategy, color, brand, model);
        }
    }
}
