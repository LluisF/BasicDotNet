namespace BasicDotNet.VuelingAirlinesFleet
{
    public interface ITanker
    {
        double RemainingFuel {get;}
        double MaxFuelCapacity {get;}
        void Refuel(double fuelQuantity);
    }
}