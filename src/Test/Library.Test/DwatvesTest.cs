using NUnit.Framework;
using DwarvesClass;

namespace Test.Library
{


    public class DwarvesTest
    {
        private Dwarves dwarves;
        
        [SetUp]
        public void Setup()
        {
            this.dwarves = new Dwarves("Felipe");
            
        }


        [Test]
        public void lifeDoesntGoBelowCero() //Prueba que la vida no baja de 0
        {
            dwarves.Life = -20;

            Assert.GreaterOrEqual(0, dwarves.Life);
        }

        [Test]
        public void attackDoesntHeal() //Prueba que el ataque no sea negativo por lo cual no cura
        {
            int inicialLife = dwarves.Life;
            dwarves.ReceiveAttack(1);

            Assert.GreaterOrEqual(inicialLife,dwarves.Life);
        }

        [Test]
        public void doesntRevive() //Prueba que el personaje al llegar a 0 de vida no puede curarse
        {
            dwarves.ReceiveAttack(150);
            dwarves.Cure();

            Assert.AreEqual(0, dwarves.Life);
        }

        [Test]
        public void attackDoesDamage() //Prueba que el ataque aplica el daño
        {
            int inicialLife = dwarves.Life;
            dwarves.ReceiveAttack(20);

            Assert.AreNotEqual(inicialLife,dwarves.Life);
        }



    }


}