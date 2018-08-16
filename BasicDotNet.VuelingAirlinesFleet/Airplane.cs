using System;

namespace BasicDotNet.VuelingAirlinesFleet
{
    public class Airplane:IFlyingStatus
    {
        public string Maker {get; private set;}
        public string Model {get; private set;}
        public string Patent {get; private set;}
        public AirplaneStatus Status { get; } 
        public FlightPlan FlightPlan {get; private set;}

        

        public Airplane(string maker, string model, string patent, FlightPlan plan)
        {
            Maker = maker;
            Model = model;
            Patent = patent;
            FlightPlan = plan;
        }
    }
}
