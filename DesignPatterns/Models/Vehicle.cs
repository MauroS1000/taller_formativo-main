using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.Models
{
    public abstract class Vehicle : IVehicle
    {
        #region Private properties
        private readonly IEngineStrategy _engineStrategy;
        private readonly IFuelStrategy _fuelStrategy;
        #endregion

        #region Properties
        public Guid ID { get; private set; }
        public virtual int Tires { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Gas { get; set; }
        public double FuelLimit { get; set; }
        public int Year { get; set; }

        // Agregar estas propiedades públicas:
        public IEngineStrategy EngineStrategy => _engineStrategy;
        public IFuelStrategy FuelStrategy => _fuelStrategy;
        #endregion

        #region Constructors

        public Vehicle(IEngineStrategy engineStrategy, IFuelStrategy fuelStrategy, string color, string brand, string model, double fuelLimit = 10)
        {
            ID = Guid.NewGuid();
            _engineStrategy = engineStrategy;
            _fuelStrategy = fuelStrategy;
            Color = color;
            Brand = brand;
            Model = model;
            FuelLimit = fuelLimit;
        }

        #endregion

        #region Methods
        public void AddGas()
        {
            _fuelStrategy.AddFuel();
        }

        public void StartEngine()
        {
            _engineStrategy.Start();
        }

        public void StopEngine()
        {
            _engineStrategy.Stop();
        }

        public bool NeedsGas()
        {
            return Gas <= 0;
        }

        public bool IsEngineOn()
        {
            return _engineStrategy.IsEngineOn();
        }
        #endregion
    }
}
