using System;
using System.Collections.Generic;
using System.Text;

namespace BasicDotNet.VuelingAirlinesFleet
{
    public interface IAirplane
    {
        string Maker { get;}
        string Model { get; }
        string Patent { get; }
        FlightPlan FlightPlan { get;}
    }
}
