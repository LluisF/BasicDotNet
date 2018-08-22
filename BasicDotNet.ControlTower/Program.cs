using BasicDotNet.VuelingAirlinesFleet;
using FizzWare.NBuilder;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicDotNet.ControlTower
{

    class Program
    {
        static Random Randomizer = new Random();

        static IEnumerable<Airplane> AirSpace;

        static void BuildAirSpace()
        {
            AirSpace  = Builder<Airplane>
                .CreateListOfSize(15)
                    .TheFirst(2)
                        .WithFactory(() => new Airplane ("Boeing", "737", $"EC-{Randomizer.Next(1,999):D3}", 4, "Rolls-Royce", "JetStream-6000", EngineType.Jet, 10000))
                            .And(p => p.AssignFlightPlan(Builder<FlightPlan>
                                .CreateNew()
                                    .WithFactory(() => new FlightPlan("BCN", "SCL", 13000.0, DateTime.UtcNow, DateTime.UtcNow.AddDays(1)))
                                .Build()))
                    .TheNext(6)
                        .WithFactory(() => new Airplane ("Airbus", "A320", $"EC-{Randomizer.Next(1,999):D3}", 2, "McDonell-Douglas", "TurboJet-2000", EngineType.Jet, 5000))
                            .And(p => p.AssignFlightPlan(Builder<FlightPlan>
                                .CreateNew()
                                    .WithFactory(() => new FlightPlan("BCN", "MAD", 600.0, DateTime.UtcNow, DateTime.UtcNow.AddDays(1)))
                                .Build()))
                    .TheNext(5)
                        .WithFactory(() => new Airplane ("Aeroflot", "200", $"EC-{Randomizer.Next(1,999):D3}", 2, "Aeroflot", "Rania-200", EngineType.Jet, 7000))
                            .And(p => p.AssignFlightPlan(Builder<FlightPlan>
                                .CreateNew()
                                    .WithFactory(() => new FlightPlan("BCN", "MCO", 500.0, DateTime.UtcNow, DateTime.UtcNow.AddDays(1)))
                                .Build()))
                    .TheLast(2)
                        .WithFactory(() => new Airplane ("Boeing", "TurboFan", $"EC-{Randomizer.Next(1,999):D3}", 2, "Rolls-Royce", "TurboFan-1000", EngineType.TurboFan, 1500))
                            .And(p => p.AssignFlightPlan(Builder<FlightPlan>
                                .CreateNew()
                                    .WithFactory(() => new FlightPlan("BCN", "FCO", 1300.0, DateTime.UtcNow, DateTime.UtcNow.AddDays(1)))
                                .Build()))
                .Build();
        }

        static void ShowPlaneData(Airplane plane)
        {
            Console.WriteLine($"Patent:{plane.Patent}");
            Console.WriteLine($"Manufacturer:{plane.Maker}");
            Console.WriteLine($"Model:{plane.Model}");
            Console.WriteLine($"# engines:{plane.Engines.Count}");
            Console.WriteLine($"Engine types:{plane.Engines[0].Type.ToString()}");
            Console.WriteLine("=====================================");
        }

        static IEnumerable<Airplane> GetPlanesOnAir(IEnumerable<Airplane> airspace)
        {
            return airspace.Where(plane => plane.InFlight());
        }

        static IEnumerable<Airplane> GetPlanesWithProblems(IEnumerable<Airplane> airspace)
        {
            return airspace.Where(plane => plane.GotProblems());
        }

        static IEnumerable<Airplane> GetPlanesLanded(IEnumerable<Airplane> airspace)
        {
            return airspace.Where(plane => !plane.InFlight());
        }

        static void ShowFlightPlan(FlightPlan plan)
        {
            Console.WriteLine($"Flight:{plan.Origin} => {plan.Destination}");
            Console.WriteLine($"Departure time:{plan.DepartureTime}");
            Console.WriteLine($"Arrival time:{plan.ArrivalTime}");            
            Console.WriteLine($"Estimated flight duration:{plan.ArrivalTime.Subtract(plan.DepartureTime)}");            
            Console.WriteLine($"Distance:{plan.Distance}");
            Console.WriteLine("=====================================");
        }

        static void Main(string[] args)
        {
            BuildAirSpace();
            Console.WriteLine("AirSpace ready...");
            foreach(var plane in AirSpace)
                ShowPlaneData(plane);
            Console.ReadLine();
            Console.WriteLine($"Total of {GetPlanesOnAir(AirSpace).Count()} planes in flight");
            Console.WriteLine($"Total of {GetPlanesWithProblems(AirSpace).Count()} planes with problems");
            Console.ReadLine();
            foreach(var plane in AirSpace)
                ShowFlightPlan(plane.FlightPlan);
            Console.ReadLine();
        }
    }
}
