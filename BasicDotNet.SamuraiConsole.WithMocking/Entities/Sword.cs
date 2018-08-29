namespace BasicDotNet.SamuraiConsole.WithMocking.Entities
{
    using Exceptions;

    public class Sword : IWeapon
    {
        public int Damage { get; private set; }

        public Sword()
        {
            Damage = 5;
        }

        public void Hit(IWarrior target)
        {
            if (target.Weapon == this)
                throw new SuicidalException();
            target.Defend(Damage);
        }
    }
}