using BasicDotNet.SamuraiConsole.WithMocking.Entities;

namespace BasicDotNet.SamuraiConsole.WithMocking.Entities.Exceptions
{
    public interface ISuicidalException
    {
        void HaraKiri(IWarrior samurai);
    }
}