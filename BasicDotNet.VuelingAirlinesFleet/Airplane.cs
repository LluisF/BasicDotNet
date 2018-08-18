using System;

namespace BasicDotNet.VuelingAirlinesFleet
{
    public class Airplane: IFlyingStatus, ITanker
    {
        public string Maker {get; private set;}
        public string Model {get; private set;}
        public string Patent {get; private set;}
        public FlightPlan FlightPlan {get; private set;}
        public int Capacity { get; private set; }
        public int MaxCapacity { get; private set; }
        public double Consume {get; private set; }

        public Airplane (string maker, string model, string patent, List<FlightPlan>())
        {
            Maker = maker;
            Model = model;
            Patent = patent;
        }
    }
}
