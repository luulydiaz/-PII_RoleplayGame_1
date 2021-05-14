
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
            this.Life = 60;
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
                if (0 <= value )
                {
                    this.life = value;
                }
                else 
                {
                    this.life = 0;
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
                return BaseDamage + spellbook.DamageValue + Cloak.DamageValue;
            }
        }
        public int Defense
        {
            get
            {
                return BaseDefense + spellbook.DefenseValue + Cloak.DefenseValue;
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

        public void Cure()
        {
            if(this.Life > 0)
            {
                this.Life = this.MaxLife;
            }
            
        }
    }
}