using System;
using System.Collections.Generic;
using System.Text;

namespace BasicDotNet.VuelingAirlinesFleet
{
    interface ITanker
    {
        double FuelConsumption { get; }
        double MaxCapacity { get; }
        double Capacity { get; }
    }
}
