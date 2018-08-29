namespace BasicDotNet.SamuraiConsole.WithMocking.Entities
{
    public interface IWarrior
    {
        int Health { get; }

        IWeapon Weapon { get; }

        void Defend(int damage);

        void Attack(IWarrior warrior);
    }
}