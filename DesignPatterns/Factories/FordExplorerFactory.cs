using DesignPatterns.ModelBuilder;
using DesignPatterns.Models;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Factories
{
    public class FordExplorerFactory : ICarFactory
    {
        public Vehicle Create()
        {
            return new CarModelBuilder()
                .setModel("Explorer")
                .setColor("Black")
                .Build();
        }
    }
}
