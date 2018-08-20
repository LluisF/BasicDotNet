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
        public AirplaneStatus Status { get; set; } 
        public FlightPlan FlightPlan {get; private set;}
        public double FuelConsumption { get; private set;}
        public double MaxCapacity { get; private set; }
        public double Capacity { get; private set; }
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
            Capacity = MaxCapacity;
            FuelConsumption = 0;

        }
        private double CalculateAutonomy()
        {
            return 1000; 
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
