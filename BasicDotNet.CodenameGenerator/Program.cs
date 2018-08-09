
using System;

namespace BasicDotNet.CodenameGenerator
{
    class Program
    {
        protected static readonly string[] Adjectives = {"hungry", "sexy", "faulty", "excessive", "grumpy", "bold", "handsome"};
        protected static readonly string[] Nouns = {"developer", "architect", "craftman", "sysops", "sysadmin", "analyst", "designer", "coder"};

        static void Main(string[] args)
        {
            string scodenameGen = Console.ReadLine();
            int codenameGen = Convert.ToInt32(scodenameGen);

            for (int i = 0; i < codenameGen; ++i )
            {
                Random rnd = new Random();
                int adjNum = rnd.Next(0, Adjectives.Length);
                int noumNum = rnd.Next(0, Nouns.Length);
                Console.WriteLine(Adjectives[adjNum] + " " + Nouns[noumNum]);
            }
            Console.ReadLine();
        }
    }
}
