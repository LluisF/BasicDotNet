using System;
using System.Collections.Generic;

namespace BasicDotNet.VuelingAirlinesFleet
{
    public class Airplane:IFlyingStatus,IThrottable,ITanker
    {
        public string Maker {get; private set;}
        public string Model {get; private set;}
        public string Patent {get; private set;}
        public AirplaneStatus Status { get; set; } 
        public FlightPlan FlightPlan {get; private set;}
        public double FuelConsumption { get; private set;}
        public double MaxCapacity { get; private set; }
        public double Capacity { get; private set; }
        public double Velocity { get; private set; }
        private List<Motor> Engines = new List<Motor>();

        public Airplane(string maker, string model, string patent, FlightPlan plan)
        {
            Maker = maker;
            Model = model;
            Patent = patent;
            FlightPlan = plan;
            checkAirplaneType();
            Capacity = MaxCapacity;
            FuelConsumption = 0;

        }

        private void checkAirplaneType()
        {
            if((Maker == "Airbus" && Model == "320") || (Maker == "Boeing" && Model == "737"))
            {
                MaxCapacity = 3000;
                Engines.Add(new Motor(Maker, Model, 15, MotorType.Jet));
                Engines.Add(new Motor(Maker, Model, 15, MotorType.Jet));
            }
            else if(Maker == "Boeing" && Model == "747")
            {
                MaxCapacity = 6000;
                Engines.Add(new Motor(Maker, Model, 15, MotorType.TurboProp));
                Engines.Add(new Motor(Maker, Model, 15, MotorType.TurboProp));
                Engines.Add(new Motor(Maker, Model, 15, MotorType.TurboProp));
                Engines.Add(new Motor(Maker, Model, 15, MotorType.TurboProp));
            }
            else
            {
                MaxCapacity = 2000;
                Engines.Add(new Motor(Maker, Model, 10, MotorType.Jet));
                Engines.Add(new Motor(Maker, Model, 10, MotorType.Jet));
            }
        }

        public void IncreaseImpulsion()
        {
            double consum = 0;
            foreach (var motor in Engines)
            {
                motor.IncreaseImpulsion();
                consum += motor.FuelConsumption;
            }
            FuelConsumption = consum;
        }

        public void DecreaseImpulsion()
        {
            double consum = 0;
            foreach (var motor in Engines)
            {
                motor.DecreaseImpulsion();
                consum += motor.FuelConsumption;
            }
            FuelConsumption = consum;
        }
    }
}
