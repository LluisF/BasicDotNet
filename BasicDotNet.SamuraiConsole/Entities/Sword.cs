namespace SamuraiConsole.Entities
{
    public class Sword : IWeapon
    {
        public int Damage { get; private set; }

        public Sword()
        {
            Damage = 5;
        }

        public void Hit(IWarrior target)
        {
            target.Defend(Damage);
        }
    }
}