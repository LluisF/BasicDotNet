namespace BasicDotNet.CodenameGenerator
{
    class Program
    {
        protected static readonly string[] Adjectives = {"hungry", "sexy", "faulty", "excessive", "grumpy", "bold", "handsome"};
        protected static readonly string[] Nouns = {"developer", "architect", "craftman", "sysops", "sysadmin", "analyst", "designer", "coder"};

        static void Main(string[] args)
        { 
            int maxNom = 5;
            List<strin> CodeNames;


         protected static readonly string[] Adjectives = { "hungry", "sexy", "faulty", "excessive", "grumpy", "bold", "handsome" };
        protected static readonly string[] Nouns = { "developer", "architect", "craftman", "sysops", "sysadmin", "analyst", "designer", "coder" };

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = 5;
            int i, x, y;
            List<string> CodeNames = new List<string>();


            for (i = 0; i < num; i++)
            {
                x = rnd.Next(0, 6);
                y = rnd.Next(0, 7);
                var Adj = Adjectives[x];
                var Nom = Nouns[y];
                var Code = Adj + " " + Nom;

                if (!CodeNames.Contains(Code))
                {
                    CodeNames.Add(Code);
                    Console.WriteLine(Code);
                }
                else
                    i--;


            }
            Console.ReadLine();
        }
    }
}
