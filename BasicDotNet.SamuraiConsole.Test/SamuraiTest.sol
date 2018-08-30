using Microsoft.VisualStudio.TestTools.UnitTesting;
using SamuraiConsole.Entities;

namespace BasicDotNet.SamuraiConsole.Test
{
    [TestClass]
    public class SamuraiTest
    {
        [TestMethod]
        // Prueba del ataque
        public void AttackTest()
        {
            // Preparo el combate

            // Primero las armas...
            var swordUnderTest = new Sword();
            var foeSword = new Sword();
            var swordDamage = swordUnderTest.Damage;
            var foeDamage = foeSword.Damage;

            // ... luego, los contendientes, cada uno con su arma
            var samuraiUnderTest = new Samurai(swordUnderTest, 100);
            var foeSamurai = new Samurai(foeSword, 75);

            // Examino a los contendientes...
            var samuraiInitialHealth = samuraiUnderTest.Health;
            var foeInitialHealth = foeSamurai.Health;

            // ... y ¡lanzo el ataque!
            samuraiUnderTest.Attack(foeSamurai);

            // Compruebo que el enemigo se ha hecho pupita...
            Assert.IsTrue(foeSamurai.Health == foeInitialHealth - swordDamage);
            // ...que yo estoy sanito...
            Assert.IsTrue(samuraiInitialHealth == samuraiUnderTest.Health);
        }
    }
}
