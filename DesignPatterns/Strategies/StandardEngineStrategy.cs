using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.Strategies
{
    public class StandardEngineStrategy : IEngineStrategy
    {
        private bool _isEngineOn = false;

        public void Start()
        {
            if (_isEngineOn)
            {
                throw new Exception("Engine is already on");
            }
            _isEngineOn = true;
            Console.WriteLine("Engine started.");
        }

        public void Stop()
        {
            if (!_isEngineOn)
            {
                throw new Exception("Engine already stopped");
            }
            _isEngineOn = false;
            Console.WriteLine("Engine stopped.");
        }

        public bool IsEngineOn() => _isEngineOn;
    }
}