using System;
using System.Collections.Generic;
using System.Text;

namespace BasicDotNet.VuelingAirlinesFleet
{
    public class Motor : IMotor,IThrottable,IControllable
    {
        public string Maker {get; private set;}
        public string Model {get; private set;}
        public double FuelConsumption {get; private set;}
        public MotorType Type {get; set;}
        public MotorState State {get; set;}
        public Motor(string maker, string model,double fuelCon, MotorType type)
        {
            Maker = maker;
            Model = model;
            FuelConsumption = fuelCon;
            Type = type;
            State = MotorState.Off;
        }

        public void Start()
        {
            if (MotorState.On == State)
                throw new ArgumentOutOfRangeException("It is already on.");
            else if (FuelConsumption == 0)
                throw new ArgumentOutOfRangeException("There is not fuel to start the engine.");
            else if (MotorState.Blown == State)
                throw new ArgumentOutOfRangeException("The engine it is broken");
            else if (MotorState.Off == State)
                State = MotorState.Off;
        }
        public void Stop() {
            if (MotorState.Off == State)
                throw new ArgumentOutOfRangeException("It is already Off.");
            else if (MotorState.On == State)
                State = MotorState.Off;
        }
        public void IncreaseImpulsion()
        {
            if (MotorState.Off == State)
                throw new ArgumentOutOfRangeException("The engine it is off");
            else if (MotorState.Blown == State)
                throw new ArgumentOutOfRangeException("The engine it is broken");
            else if (MotorState.On == State)
                FuelConsumption += 10;
        }

        public void DecreaseImpulsion()
        {
            if (MotorState.Off == State)
                throw new ArgumentOutOfRangeException("The engine it is off");
            else if (MotorState.Blown == State)
                throw new ArgumentOutOfRangeException("The engine it is broken");
            else if (MotorState.On == State)
            {
                if (FuelConsumption - 10 > 0)
                    FuelConsumption -= 10;
                else
                    State = MotorState.Off; 
            }
        }
    }
}
