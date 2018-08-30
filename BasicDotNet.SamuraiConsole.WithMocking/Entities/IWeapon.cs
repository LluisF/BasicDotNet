namespace BasicDotNet.SamuraiConsole.WithMocking.Entities
{
    public interface IWeapon
    {
        int Damage { get; }

        void Hit(IWarrior target);
    }
}