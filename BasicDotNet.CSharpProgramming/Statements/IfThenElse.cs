using System;
using System.Collections.Generic;
using System.Text;

namespace BasicDotNet.CSharpProgramming.Statements
{
    public class IfThenElse
    {
        public void Try(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("The first argument value is: {args[0]}");
            }
            else
                Console.WriteLine("No arguments.");
        }
    }
}
