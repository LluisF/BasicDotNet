using System;
using System.Collections.Generic;

namespace BasicDotNet.VuelingAirlinesFleet
{
    public class Airplane:IFlyingStatus,IThrottable,ITanker
    {
        public string Maker {get; private set;}
        public string Model {get; private set;}
        public string Patent {get; private set;}
        public int nPax { get; private set; }
        public AirplaneStatus Status { get { return CalculateStatus(); } } 
        public FlightPlan FlightPlan {get; private set;}
        public double FuelConsumption { get { return CalculateFuelConsumption(); } }
        public double MaxCapacity { get; private set; }
        public double Capacity { get { return CalculateCapacity(); }}
        private double initCapacity;
        public double Velocity { get; private set; }
        public double Autonomy { get { return CalculateAutonomy(); } }
        private List<Motor> Engines = new List<Motor>();

        public Airplane(string maker, string model, string patent, FlightPlan plan)
        {
            Maker = maker;
            Model = model;
            Patent = patent;
            FlightPlan = plan;
            checkAirplaneType();
            initCapacity = MaxCapacity;

        }
        private double CalculateAutonomy()
        {
            return Capacity*100/FuelConsumption*0.95; 
        }
        private double CalculateCapacity()
        {
                double fuelSpent = FlightPlan.GetKmDone() * FuelConsumption / 100;
                //if(fuelSpent > pCapacity)
                //    throw new ArgumentOutOfRangeException("The Airplane doesn't have fuel");
                return initCapacity - fuelSpent;
 
        }

        private AirplaneStatus CalculateStatus()
        {
            if (FlightPlan.IsFliying())
                return AirplaneStatus.Flying;
            else
                return AirplaneStatus.OnLand;
        }


        private double CalculateFuelConsumption()
        {
            double consum = 0;
            foreach (var motor in Engines)
            {
                consum += motor.FuelConsumption;
            }
            return consum;
        }
        private void checkAirplaneType()
        {
            if((Maker == "Airbus" && Model == "320") || (Maker == "Boeing" && Model == "737"))
            {
                MaxCapacity = 18000;
                nPax = 180;
                Engines.Add(new Motor(Maker, Model, 300, MotorType.Jet));
                Engines.Add(new Motor(Maker, Model, 300, MotorType.Jet));
            }
            else if(Maker == "Boeing" && Model == "747")
            {
                MaxCapacity = 100000;
                nPax = 250;
                Engines.Add(new Motor(Maker, Model, 300, MotorType.Jet));
                Engines.Add(new Motor(Maker, Model, 300, MotorType.Jet));
                Engines.Add(new Motor(Maker, Model, 300, MotorType.Jet));
                Engines.Add(new Motor(Maker, Model, 300, MotorType.Jet));
            }
            else if (Maker == "Piper" && Model == "M600")
            {
                nPax = 50;
                MaxCapacity = 9000;
                Engines.Add(new Motor(Maker, Model, 200, MotorType.TurboProp));
            }
            else
            {
                nPax = 100;
                MaxCapacity = 10000;
                Engines.Add(new Motor(Maker, Model, 150, MotorType.TurboProp));
                Engines.Add(new Motor(Maker, Model, 150, MotorType.TurboProp));
            }
        }

        public void IncreaseImpulsion()
        {
            foreach (var motor in Engines)
                motor.IncreaseImpulsion();
        }

        public void DecreaseImpulsion()
        {
            foreach (var motor in Engines)
                motor.DecreaseImpulsion();
        }

        public void Start()
        {
            foreach (var motor in Engines)
                motor.Start();
        }
        public void Stop()
        {
            foreach (var motor in Engines)
                motor.Stop();
        }
    }
}
