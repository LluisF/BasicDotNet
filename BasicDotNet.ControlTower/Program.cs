using System;
using BasicDotNet.VuelingAirlinesFleet;
namespace BasicDotNet.ControlTower
{
    class Program
    {
        static void Main(string[] args)
        {
            FlightPlan flightPlan = new FlightPlan(new DateTime(2018, 08, 20, 20, 07, 00), new DateTime(2018, 08, 20, 20, 53, 00), "BCN", "MAD", 900);
            Airplane airplane = new Airplane("Boeing", "737", "Jose", flightPlan);
            Console.WriteLine("Capacidad: " + airplane.Capacity);
            Console.WriteLine("Autonomia: " + airplane.Autonomy);
            Console.WriteLine("Consumo: " + airplane.FuelConsumption);
            Console.WriteLine("KM: " + flightPlan.GetKmDone());
            Console.ReadLine();
        }
    }
}
