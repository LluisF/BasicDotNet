using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BasicDotNet.AdvProgConcepts.Generics
{
    public class MagicBag<TArtifact> : IEnumerable<TArtifact>
    {
        private readonly List<TArtifact> internalBag = new List<TArtifact>();
        private readonly Random randomizer = new Random();

        public IEnumerator<TArtifact> GetEnumerator() => internalBag.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        protected int GetRandomIndex() => randomizer.Next(0, internalBag.Count() - 1);
        public void Put(TArtifact artifact) => internalBag.Add(artifact);        
        public TArtifact Peek() => internalBag.ElementAt(GetRandomIndex());
    }
}
