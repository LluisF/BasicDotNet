namespace BasicDotNet.VuelingAirlinesFleet
{
    public interface IThrottable
    {
        void IncreaseImpulsion();
        void DecreaseImpulsion();
        double FuelConsumption { get; }
        double AirspeedIncrement { get; }
    }
}
