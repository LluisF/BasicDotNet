using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicDotNet.CodenameGenerator
{
    class Program
    {
        protected static Random RandomSeed;
        protected static IList<string> GeneratedCodenames { get; }

        protected static readonly string[] Adjectives = {"hungry", "sexy", "faulty", "excessive", "grumpy", "bold", "handsome"};
        protected static readonly string[] Nouns = {"developer", "architect", "craftman", "sysops", "sysadmin", "analyst", "designer", "coder"};

        static Program()
        {
            RandomSeed = new Random();
            GeneratedCodenames = new List<string>();
        }
                
        static int ParseArgs(string[] args)
        {
            return args.Length == 1 ? Int32.Parse(args[0]) : 1;
        }

        static string GetRandomElement(string[] arr)
        {
            return arr[RandomSeed.Next(0, arr.Length)];
        }

        static string GenerateCodename()
        {
            var adjective = GetRandomElement(Adjectives);
            var noun = GetRandomElement(Nouns);
            return $"{adjective} {noun}";
        }

        static void AddWithoutDuplicates(string codename)
        {
            if (GeneratedCodenames.All(gc => gc != codename))
            {
                GeneratedCodenames.Add(codename);
                Console.WriteLine(codename);
            }
        }

        static void Main(string[] args)
        {
            var numCodenames = ParseArgs(args);
            if (numCodenames > Adjectives.Length * Nouns.Length)
                throw new ArgumentOutOfRangeException("Number of unique codenames cannot exceed of {maxCodenames}.");
            do
            {
                var codename = GenerateCodename();
                AddWithoutDuplicates(codename);
            }
            while (GeneratedCodenames.Count() < numCodenames);
            Console.WriteLine("Press <Enter> to exit.");
            Console.ReadLine();
        }
    }
}
