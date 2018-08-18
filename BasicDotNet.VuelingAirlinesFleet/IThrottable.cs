using System;
using System.Collections.Generic;
using System.Text;

namespace BasicDotNet.VuelingAirlinesFleet
{
    interface IThrottable
    {
        public void IncreaseImpulsion();
        public void DecreaseImpulsion();
        public double FuelConsumption;
    }
}
