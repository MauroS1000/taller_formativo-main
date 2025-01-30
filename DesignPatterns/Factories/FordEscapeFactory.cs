using DesignPatterns.ModelBuilder;
using DesignPatterns.Models;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Factories
{
    public class FordEscapeFactory : ICarFactory
    {
        public Vehicle Create()
        {
            return new CarModelBuilder()
                .setModel("Escape")
                .setColor("Blue")
                .Build();
        }
    }
}
