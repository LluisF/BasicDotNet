using System;
using System.Collections.Generic;
using System.Text;

namespace BasicDotNet.VuelingAirlinesFleet
{
    interface IMotor
    {
        string Maker { get;}
        string Model { get;}
        MotorType Type { get; set; }
        MotorState State { get; set; }
    }
}
