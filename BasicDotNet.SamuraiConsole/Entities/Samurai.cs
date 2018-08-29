namespace SamuraiConsole.Entities
{
    public class Samurai : IWarrior
    {
        public IWeapon Weapon { get; private set; }
        public int Health { get; private set; }

        public Samurai(IWeapon weapon, int health = 5)
        {
            Weapon = weapon;
            Health = health;
        }
        
        public void Defend(int damage)
        {
            Health -= damage;
        }

        public void Attack(IWarrior warrior)
        {           
            Weapon.Hit(warrior);
        }
    }
}