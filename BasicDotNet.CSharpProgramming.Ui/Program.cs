using BasicDotNet.CSharpProgramming.Structure;
using System;

namespace BasicDotNet.CSharpProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            var paxPromo = new PaxPromo(90)
            {
                Name = "Lluis",
                BirthDate = new DateTime(1945, 01, 05)
            };
            Console.WriteLine(paxPromo.IsYoungPromoCandidate());
        }
    }
}
