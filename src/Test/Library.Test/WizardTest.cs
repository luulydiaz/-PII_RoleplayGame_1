using NUnit.Framework;
using WizardClass;

namespace Test.Library
{


    public class WizardTest
    {
        private Wizard wizard;
        /*
        Wizard wizard = new Wizard("Felipe");
            Console.WriteLine($"Name: {wizard.Name}, Life: {wizard.Life}, Base damage: {wizard.BaseDamage} Damage: {wizard.Damage}, Defense: {wizard.Defense}");
            Spell newSpell = new Spell("bola de fuego");
            wizard.Spellbook.AddSpell(newSpell);
            wizard.Spellbook.AddSpell(newSpell);
            wizard.Spellbook.AddSpell(newSpell);
            Console.WriteLine($"Spellbook damage: {wizard.Spellbook.DamageValue}");
            Console.WriteLine($"Name: {wizard.Name}, Life: {wizard.Life}, Base damage: {wizard.BaseDamage} Damage: {wizard.Damage}, Defense: {wizard.Defense}");
            wizard.Spellbook.RemoveSpell(newSpell);
            Console.WriteLine($"Spellbook Damage: {wizard.Spellbook.DamageValue}");
            Console.WriteLine($"Wizard damage: {wizard.Damage}");

            wizard.ReceiveAttack(wizard.Damage);
            Console.WriteLine($"{wizard.Life}");
            wizard.MeDaExactamenteLoMismo();
            Console.WriteLine($"{wizard.Life}");
        */
        [SetUp]
        public void Setup()
        {
            this.wizard = new Wizard("Felipe");
            
        }


        [Test]
        public void lifeDoesntGoBelowCero() //Prueba que la vida no baja de 0
        {
            wizard.Life = -20;

            Assert.GreaterOrEqual(0, wizard.Life);
        }

        [Test]
        public void attackDoesntHeal() //Prueba que el ataque no sea negativo por lo cual no cura
        {
            int inicialLife = wizard.Life;
            wizard.ReceiveAttack(1);

            Assert.GreaterOrEqual(inicialLife,wizard.Life);
        }

        [Test]
        public void doesntRevive() //Prueba que el personaje al llegar a 0 de vida no puede curarse
        {
            wizard.ReceiveAttack(150);
            wizard.Cure();

            Assert.AreEqual(0, wizard.Life);
        }

        [Test]
        public void attackDoesDamage() //Prueba que el ataque aplica el daño
        {
            int inicialLife = wizard.Life;
            wizard.ReceiveAttack(20);

            Assert.AreNotEqual(inicialLife,wizard.Life);
        }



    }


}