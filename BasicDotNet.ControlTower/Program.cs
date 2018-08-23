using System;
using BasicDotNet.VuelingAirlinesFleet;
namespace BasicDotNet.ControlTower
{
    class Program
    {
        static void Main(string[] args)
        {
            FlightPlan flightPlan = new FlightPlan(new DateTime(2018, 08, 21, 09, 07, 00), new DateTime(2018, 08, 21, 10, 20, 00), "BCN", "MAD", 3000);
            Airplane airplane = new Airplane("Boeing", "737", "Jose", flightPlan);
            Console.WriteLine("Capacidad: " + airplane.Capacity);
            Console.WriteLine("Autonomia: " + airplane.Autonomy);
            Console.WriteLine("Consumo: " + airplane.FuelConsumption);
            Console.WriteLine("KM: " + flightPlan.GetKmDone());
            Console.ReadLine();
        }
    }
}
