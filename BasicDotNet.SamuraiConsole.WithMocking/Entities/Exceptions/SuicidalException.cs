namespace BasicDotNet.SamuraiConsole.WithMocking.Entities.Exceptions
{
    using System;

    public class SuicidalException : ApplicationException, ISuicidalException
    {
        public override string Message
        {
            get
            {
                return "Zen does not approve suicide.";
            }
        }

        public void HaraKiri(IWarrior samurai)
        {
            Console.WriteLine("Banzaaaai!");
        }
    }
}