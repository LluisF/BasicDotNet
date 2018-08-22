namespace BasicDotNet.AdvProgConcepts.Delegates
{
    public class Calculator
    {
        public delegate int DoCalculation(int x, int y);

        protected DoCalculation Operation { get; private set; }

        public Calculator(DoCalculation operation)
        {
            Operation = operation;
        }

        public int Calculate(int x, int y)
        {
            return Operation(x, y);
        }
    }
}
