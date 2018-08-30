using BasicDotNet.SamuraiConsole.WithMocking.Entities;
using BasicDotNet.SamuraiConsole.WithMocking.Entities.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BasicDotNet.SamuraiConsole.WithMocking.Test
{
    [TestClass]
    public class SamuraiTest
    {
        [TestMethod]
        // Prueba del ataque con mocking
        public void AttackTest()
        {
            // Moqueo las dependencias del samurai...
            var mockSword = new Mock<IWeapon>();
            var mockFoeSword = new Mock<IWeapon>();

            // Preparo a los samurais...
            var samuraiUnderTest = new Samurai(mockSword.Object, 100);
            var foeSamurai = new Samurai(mockFoeSword.Object, 75);

            // Grabo las expectativas sobre los mocks...
            mockSword.Setup(sword => sword.Hit(It.IsAny<IWarrior>()));

            // Lanzo la unidad de código a probar..
            samuraiUnderTest.Attack(foeSamurai);

            // Verifico que se ha cumplido el comportamiento esperado...
            mockSword.VerifyAll();
        }

        [TestMethod]
        // Prueba de ataque suicida
        public void SuicidalAttackTest()
        {
            // Moqueo las dependencias del samurai...
            var mockSword = new Mock<IWeapon>();

            // Preparo al samurai...
            var samuraiUnderTest = new Samurai(mockSword.Object, 100);

            // Grabo las expectativas sobre los mocks...
            mockSword.Setup(sword => sword.Hit(It.IsAny<IWarrior>())).Throws(It.IsAny<SuicidalException>());

            // Lanzo la unidad de código a probar..
            samuraiUnderTest.Attack(samuraiUnderTest);

            // Verifico que se ha cumplido el comportamiento esperado...
            mockSword.VerifyAll();            
        }

        private Mock<IWeapon> _looseMock;
        private Mock<IWeapon> _anotherLooseMock;
        private Mock<IWeapon> _yetAnotherLooseMock;
        private Mock<IWeapon> _strictMock;

        [TestInitialize]
        public void BeforeEachTest()
        {
            _looseMock = new Mock<IWeapon>(MockBehavior.Loose);
            _anotherLooseMock = new Mock<IWeapon>();
            _yetAnotherLooseMock = new Mock<IWeapon>(MockBehavior.Default);
            _strictMock = new Mock<IWeapon>(MockBehavior.Strict);
        }

        [TestMethod]
        public void Test()
        {
            _looseMock.SetupGet(weapon => weapon.Damage).Returns(It.IsAny<int>());
            _looseMock.Setup(weapon => weapon.Hit(It.IsAny<IWarrior>()));
            _looseMock.Setup(weapon => weapon.Hit(It.IsAny<IWarrior>())).AtMost(5);
            _looseMock.Setup(weapon => weapon.Hit(It.IsAny<IWarrior>())).Throws(It.IsAny<SuicidalException>());            
        }
    }
}
