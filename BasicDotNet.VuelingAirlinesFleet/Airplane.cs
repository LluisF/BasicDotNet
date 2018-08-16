using System;

namespace BasicDotNet.VuelingAirlinesFleet
{
    public class Airplane
    {
        public string Maker {get; private set;}
        public string Model {get; private set;}
        public string Patent {get; private set;}
        public FlightPlan FlightPlan {get; private set;}
    }
}
