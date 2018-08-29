namespace SamuraiConsole.Entities
{
    public interface IWeapon
    {
        int Damage { get; }

        void Hit(IWarrior target);
    }
}