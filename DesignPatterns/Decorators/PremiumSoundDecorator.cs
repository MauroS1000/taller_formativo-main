using DesignPatterns.Models;
using System;

namespace DesignPatterns.Decorators
{
    public class PremiumSoundDecorator : VehicleDecorator
    {
        public PremiumSoundDecorator(Vehicle vehicle)
            : base(vehicle)
        {
        }

        public void PlayMusic()
        {
            Console.WriteLine("Playing premium sound!");
        }
    }
}