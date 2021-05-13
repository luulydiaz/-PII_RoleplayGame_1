using System;
using System.Collections.Generic;

namespace WizardClass
{
    public class Spellbook
    {
        private List<Spell> spells;

        public Spellbook()
        {
            this.spells = new List<Spell>();
            this.DamageValue = spells.Count;
            this.DefenseValue = 0;
        }

        public int DamageValue { get; set; }
        public int DefenseValue { get; set; }

        public void AddSpell(Spell spell)
        {
            this.spells.Add(spell);
            this.DamageValue = spells.Count;
        }

        public void RemoveSpell(Spell spell)
        {
            this.spells.Remove(spell);
            this.DamageValue = spells.Count;
        }
    }
}