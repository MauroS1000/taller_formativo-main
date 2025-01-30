using DesignPatterns.Interfaces;
using DesignPatterns.Models;

namespace DesignPatterns.Vehicles
{
    public class Car : Vehicle
    {
        public Car(IEngineStrategy engineStrategy, IFuelStrategy fuelStrategy, string color, string brand, string model)
            : base(engineStrategy, fuelStrategy, color, brand, model) { }
    }
}
