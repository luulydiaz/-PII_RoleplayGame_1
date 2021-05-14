using NUnit.Framework;
using ElfClass;

namespace Test.Library
{
    public class ExampleTest
    {
        private Elf elf;
        
        [SetUp]
        public void SetUp()
        {
            Elf elf = new Elf("Facu");
        }

        [Test]
        public void lifeDoesntGoBelowCero() //Prueba que la vida no baja de 0
        {
            elf.Life = -20;

            Assert.GreaterOrEqual(0, elf.Life);
        }

        [Test]
        public void attackDoesntHeal() //Prueba que el ataque no sea negativo por lo cual no cura
        {
            int inicialLife = elf.Life;
            elf.ReceiveAttack(1);

            Assert.GreaterOrEqual(inicialLife,elf.Life);
        }

        [Test]
        public void doesntRevive() //Prueba que el personaje al llegar a 0 de vida no puede curarse
        {
            elf.ReceiveAttack(150);
            elf.Cure();

            Assert.AreEqual(0, elf.Life);
        }

        [Test]
        public void attackDoesDamage() //Prueba que el ataque aplica el daño
        {
            int inicialLife = elf.Life;
            elf.ReceiveAttack(20);

            Assert.AreNotEqual(inicialLife,elf.Life);
        }

    }


}