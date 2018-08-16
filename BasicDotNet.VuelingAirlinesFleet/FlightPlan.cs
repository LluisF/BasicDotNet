using System;
using System.Collections.Generic;
using System.Text;

namespace BasicDotNet.VuelingAirlinesFleet
{
    public class FlightPlan
    {
        private List<IAirplane> Airplanes;
        public List<IAirplane> GetAirplanes()
        {
            return Airplanes;
        }
    }
}
