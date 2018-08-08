using System;

namespace BasicDotNet.CSharpProgramming.Structure
{
    public class PaxPromo
    {
        protected int YoungPromoThreshold { get; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public PaxPromo(int threshold)
        {
            YoungPromoThreshold = threshold;
        }

        public bool IsYoungPromoCandidate()
        {
            var now = DateTime.Now;
            return now.Subtract(BirthDate).TotalDays / 365 < YoungPromoThreshold;
        }
    }
}
