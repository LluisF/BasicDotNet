using System;

namespace BasicDotNet.AdvProgConcepts.Delegates.Events
{
    public class Airport
    {
        public event EventHandler<LandingEventArgs> AirplaneLandedEvent;

        protected virtual void OnRaiseAirplaneLandedEvent(LandingEventArgs e)
        {
            AirplaneLandedEvent?.Invoke(this, e);
        }

        public void PerformLanding(string patent)
        {
            // TODO : Code implementing airplane landing.
            OnRaiseAirplaneLandedEvent(new LandingEventArgs(patent));
        }
    }
}
