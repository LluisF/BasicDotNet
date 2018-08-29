using System;

namespace BasicDotNet.SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Single Responsibility Principle
            Console.WriteLine("\n\nSingle Responsibility Principle Demo ");
            SingleResponsibilityPrinciple.SRPDemo();

            //2. Open Close Principle
            OpenClosePrincipleDemo.OSPDemo();

            //3. Liskov Substitution Principle            
            LiskovSubstitutionPrincipleDemo.LSPDemo();
            
            //4. Interface Segregation Principle
            InterfaceSegregationPrincipleDemo.ISPDemo();

            //5. Dependency Inversion Principle
            DependencyInversion.DIPDemo();
 
            Console.ReadLine();
        }
    }
}
