using BasicDotNet.VuelingAirlinesFleet;
using FizzWare.NBuilder;
using System;
using System.Collections.Generic;

namespace BasicDotNet.ControlTower
{

    class Program
    {
        static IEnumerable<Airplane> AirSpace;
        static void Main(string[] args)
        {
            AirSpace = Builder<Airplane>
                .CreateListOfSize(15)
                    .TheFirst(2)
                    .Random(6)
                        .With(a => a.Maker = "Boeing")
                .Build();
            Console.WriteLine("AirSpace ready...");
        }
    }
}
