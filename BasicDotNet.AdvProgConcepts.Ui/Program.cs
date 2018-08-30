using BasicDotNet.AdvProgConcepts.Delegates;
using BasicDotNet.AdvProgConcepts.Delegates.Events;
using System;

namespace BasicDotNet.AdvProgConcepts.Ui
{
    class Program
    {
        public static int Sum(int x, int y) { return x + y; }
        public static int Subs(int x, int y) { return x - y; }

        static void Main(string[] args)
        {
            var adder = new Calculator(Sum);
            var substractor = new Calculator(Subs);
            Console.WriteLine("Operands : x = 2, y = 2");
            Console.WriteLine($"Adder result = {adder.Calculate(2, 2)}");
            Console.WriteLine($"Substractor result = {substractor.Calculate(2, 2)}");
            Console.ReadLine();

            var airport = new Airport();
            airport.AirplaneLandedEvent += Airport_AirplaneLandedEvent;
            Console.WriteLine("<Enter> to land airplane...");
            Console.ReadLine();
            airport.PerformLanding("EC-872");
            Console.ReadLine();
        }

        private static void Airport_AirplaneLandedEvent(object sender, LandingEventArgs e)
        {
            Console.WriteLine($"Plane {e.Patent} landed.");
        }
    }
}
