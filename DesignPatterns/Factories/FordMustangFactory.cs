using DesignPatterns.ModelBuilder;
using DesignPatterns.Models;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Factories
{
    public class FordMustangFactory : ICarFactory
    {
        public Vehicle Create()
        {
            return new CarModelBuilder()
                .setModel("Mustang")
                .setColor("Red")
                .Build();
        }
    }
}
