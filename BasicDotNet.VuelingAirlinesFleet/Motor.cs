using System;
using System.Collections.Generic;
using System.Text;

namespace BasicDotNet.VuelingAirlinesFleet
{
    public class Motor:IThrottable, IControllable
    {
        public string Maker { get; private set; }
        public string Model { get; private set; }
        public double FuelConsumption { get; private set; }
        public MotorType Type { get; set; }
        public MotorState State { get; set; }
        public void Start() { }
        public void Stop() { }
        public void IncreaseImpulsion() { }
        public void DecreaseImpulsion() { }
    }
}
