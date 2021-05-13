using System;
using WizardClass;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Wizard wizard = new Wizard("Felipe", 100, 5, 0);
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
        }
    }
}
