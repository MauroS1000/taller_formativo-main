namespace DesignPatterns.Interfaces
{
    public interface IEngineStrategy
    {
        void Start();
        void Stop();
        bool IsEngineOn();
    }
}