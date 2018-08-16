using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace BasicDotNet.VuelingAirlinesFleet
{
    public class Airplane : IFlightStatus, ITanker
    {
        public string Maker {get; private set;}
        public string Model {get; private set;}
        public string Patent {get; private set;}
        public double Airspeed { get; }
        public double Range 
        { 
            get 
            { 
                return RemainingFuel - MaxFuelCapacity * 0.5 / Engines.Sum(eng => eng.FuelConsumption);
            }
        }
        public double RemainingFuel { get; private set; }
        public double MaxFuelCapacity { get; }
        public FlightPlan FlightPlan {get; private set;}
        public IList<Engine> Engines {get; private set;}

        protected Timer Timer {get; private set;}
        
        public Airplane(string maker, string model, string patent, int numEngines, string engineMaker, string engineModel, EngineType engineType)
        {
            Maker = maker;
            Model = model;
            Patent = patent;
            CreateEngines(numEngines, engineMaker, engineModel, engineType);
            InitTimer();
        }

        private void Consume(double fuelQuantity)
        {
            if (fuelQuantity > RemainingFuel)
                RemainingFuel = 0;
            else
                RemainingFuel -= fuelQuantity;
        }

        public void Refuel(double fuelQuantity)
        {
            if (fuelQuantity + RemainingFuel < MaxFuelCapacity)
                RemainingFuel = MaxFuelCapacity;
            else
                RemainingFuel += fuelQuantity;
        }

        public bool InFlight()
        {
            var now = DateTime.UtcNow;
            return now > FlightPlan.DepartureTime && now < FlightPlan.ArrivalTime;
        }

        public bool GotProblems()
        {
            return true;
        }

        private void CreateEngines(int numEngines, string engineMaker, string engineModel, EngineType engineType)
        {
            Engines = new List<Engine>();
            for (var i = 0; i < numEngines; ++i)
                Engines.Add(new Engine(engineMaker, engineModel, engineType));
        }

        private void InitTimer()
        {
            Timer = new Timer(1000)
            {
                AutoReset = true,
                Enabled = true
            };
            Timer.Elapsed += ASecondPassed;
        }

        private void ASecondPassed(object sender, ElapsedEventArgs e)
        {        
            foreach(var engine in Engines)
            {
            }
        }

        public void AssignFlightPlan(FlightPlan plan)
        {
            //TODO : Validate plan (autonomy, etc.)
            FlightPlan = plan;
        }

        public bool IsIdle()
        {
            return FlightPlan is null;
        }

        public void TakeOff()
        {
            foreach(var engine in Engines)
                engine.Start();
            foreach(var engine in Engines)
                engine.IncreaseImpulsion();
        }

        public void Landing()
        {
            foreach(var engine in Engines)
                engine.Stop();
        }
    }
}
