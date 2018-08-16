using System;

namespace BasicDotNet.VuelingAirlinesFleet
{
    public class FlightPlan
    {
        public string Origin {get;}
        public string Destination {get;}
        public double Distance {get;}
        public DateTime DepartureTime {get;}
        public DateTime ArrivalTime {get;}

        public FlightPlan(string origin, string destination, double distance, DateTime departure, DateTime arrival)
        {
            Origin = origin;
            Destination = destination;
            Distance = distance;
            DepartureTime = departure;
            ArrivalTime = arrival;
        }

        public void DelayFlight(TimeSpan timeSpan)
        {
            DepartureTime.Add(timeSpan);
        }
    }
}
