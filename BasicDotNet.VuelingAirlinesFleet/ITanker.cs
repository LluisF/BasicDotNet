using System;
using System.Collections.Generic;
using System.Text;

namespace BasicDotNet.VuelingAirlinesFleet
{
    public interface ITanker
    {
        double FuelConsumption { get; }
        double MaxCapacity { get; }
        double Capacity { get; }
    }
}
