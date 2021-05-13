
namespace WizardClass
{
    public class Wizard
    {

        private Spellbook spellbook = new Spellbook();
        private Cloak cloak = new Cloak();
        public Wizard(string name, int life, int baseDamage, int baseDefense)
        {
            this.Spellbook = spellbook;
            this.Cloak = cloak;
            this.Name = name;
            this.Life = life;
            this.BaseDamage = baseDamage;
            this.BaseDefense = baseDefense;

        }

        public Spellbook Spellbook { get; set; }
        public Cloak Cloak { get; set; }
        public int Life { get; set; }
        public string Name { get; set; }
        public int BaseDamage { get; set; }
        public int BaseDefense { get; set; }
        public int Damage
        {
            get
            {
                return BaseDamage + spellbook.DamageValue + Cloak.Damage;
            }
        }
        public int Defense
        {
            get
            {
                return BaseDefense + spellbook.DefenseValue + Cloak.Defense;
            }
        }
    }
}