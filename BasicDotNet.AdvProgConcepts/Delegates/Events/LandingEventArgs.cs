using System;

namespace BasicDotNet.AdvProgConcepts.Delegates.Events
{
    public class LandingEventArgs : EventArgs
    {
        public string Patent {get; private set;}

        public LandingEventArgs(string patent)
        {
            Patent = patent;
        }
    }
}