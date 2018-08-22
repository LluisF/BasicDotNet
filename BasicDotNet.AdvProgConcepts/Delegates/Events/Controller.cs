using System;

namespace BasicDotNet.AdvProgConcepts.Delegates.Events
{
    public class Controller
    {
        protected Airport Airport {get; private set;}

        public Controller (Airport a)
        { 
           Airport.AirplaneLandedEvent += HandlePlaneLanded; 
        }
        
        void HandlePlaneLanded(object sender, LandingEventArgs e) => Console.WriteLine("Uf!");
    }
}
