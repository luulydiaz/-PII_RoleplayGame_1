using NUnit.Framework;
using FairyClass;

namespace Test.Library
{


    public class FairyTest
    {
        private Fairy Fairy;
        
        [SetUp]
        public void Setup()
        {
            this.Fairy = new Fairy("Antonia");
            
        }


        [Test]
        public void lifeDoesntGoBelowCero() //Prueba que la vida no baja de 0
        {
            Fairy.Life = -20;

            Assert.GreaterOrEqual(0, Fairy.Life);
        }

        [Test]
        public void attackDoesntHeal() //Prueba que el ataque no sea negativo por lo cual no cura
        {
            int inicialLife = Fairy.Life;
            Fairy.ReceiveAttack(1);

            Assert.GreaterOrEqual(inicialLife,Fairy.Life);
        }

        [Test]
        public void doesntRevive() //Prueba que el personaje al llegar a 0 de vida no puede curarse
        {
            Fairy.ReceiveAttack(150);
            Fairy.Cure();

            Assert.AreEqual(0, Fairy.Life);
        }

        [Test]
        public void attackDoesDamage() //Prueba que el ataque aplica el daño
        {
            int inicialLife = Fairy.Life;
            Fairy.ReceiveAttack(20);

            Assert.AreNotEqual(inicialLife,Fairy.Life);
        }



    }


}