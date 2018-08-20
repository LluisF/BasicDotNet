using System;
using System.Collections.Generic;
using System.Text;

namespace BasicDotNet.VuelingAirlinesFleet
{
    public class FlightPlan
    {
        public DateTime DepartureDate { get; private set; }
        public DateTime ArrivalDate { get; private set; }
        public string Departure { get; private set; }
        public string Arrival { get; private set; }
        public double Distance { get; private set; }

        public FlightPlan(DateTime depTime,DateTime arriveTime,string dep, string arrival,double distance)
        {
            DepartureDate = depTime;
            ArrivalDate = arriveTime;
            Departure = dep;
            Arrival = arrival;
            Distance = distance;

        }

        public bool IsFliying()
        {

            DateTime current = DateTime.Now;

            if ((DepartureDate < current) && (ArrivalDate > current))
                return true;
            else
                return false;
        }
        public double GetKmDone()
        {
            double allTravel = (ArrivalDate - DepartureDate).TotalMilliseconds;
            double currentTravel;
            if (IsFliying())
                currentTravel = (DateTime.Now - DepartureDate).TotalMilliseconds;
            else
                currentTravel = allTravel;

            return currentTravel * Distance / allTravel;

        }
    }
}
