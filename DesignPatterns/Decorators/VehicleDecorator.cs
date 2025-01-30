using DesignPatterns.Models;

namespace DesignPatterns.Decorators
{
    public abstract class VehicleDecorator : Vehicle
    {
        protected Vehicle _vehicle;

        public VehicleDecorator(Vehicle vehicle)
            : base(vehicle.EngineStrategy, vehicle.FuelStrategy, vehicle.Color, vehicle.Brand, vehicle.Model, vehicle.FuelLimit)
        {
            _vehicle = vehicle;
        }
    }
}
