
namespace WizardClass
{
    public class Wizard
    {
        private int life;
        private Spellbook spellbook = new Spellbook();
        private Cloak cloak = new Cloak();
        public Wizard(string name)
        {
            this.Spellbook = spellbook;
            this.Cloak = cloak;
            this.Name = name;
            this.Life = 100;
            this.MaxLife = 100;
            this.BaseDamage = 5;
            this.BaseDefense = 0;

        }

        public Spellbook Spellbook { get; set; }
        public Cloak Cloak { get; set; }
        public int MaxLife { get; set; }
        public int Life
        {
            get
            {
                return this.life;
            }
            set
            {
                if (value >= 0 && value <= MaxLife)
                {
                    this.life = value;
                }
                else if (value < 0)
                {
                    this.life = 0;
                }
                else
                {
                    this.life = MaxLife;
                }
            }
        }
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

        public void ReceiveAttack(int damage)
        {
            int damageDealt = damage - this.Defense;
            if (damageDealt > 0)
            {
                this.Life = this.Life - damageDealt ;
            }
        }

        public void MeDaExactamenteLoMismo()
        {
            this.Life = this.MaxLife;
        }
    }
}