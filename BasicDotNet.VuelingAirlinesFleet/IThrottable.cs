using System;
using System.Collections.Generic;
using System.Text;

namespace BasicDotNet.VuelingAirlinesFleet
{
    interface IThrottable
    {
        void IncreaseImpulsion();
        void DecreaseImpulsion();
        double FuelConsumption { get; }
    }
}
