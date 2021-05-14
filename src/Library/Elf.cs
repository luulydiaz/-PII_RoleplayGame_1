namespace ElfClass
{
    public class Elf
    {
        private Dagger dagger = new Dagger();
        private Hood hood = new Hood();
        private int life;


        public string Name { get; set; }
        public int BaseDefense { get; set; }
        public int BaseDamage { get; set; }
        public int MaxLife { get; set; }

        public Elf(string name)
        {
            this.Name = name;
            this.Life = 100;
            this.MaxLife = 100;
            this.BaseDamage = 7;
            this.BaseDefense = 2;
        }
         public int Life
        {
            get
            {
                return this.life;
            }
            set
            {
                if (0 <= value)
                {
                    this.life = value;
                }
                else
                {
                    this.life = value;
                }
            }    
        }

        public int Damage
        {
            get
            {
                return BaseDamage + dagger.DamageValue + hood.DamageValue;
            }
        }
        public int Defense
        {
            get
            {
                return BaseDefense + dagger.DefenseValue + hood.DefenseValue;
            }
        }

        public void ReceiveAttack(int damage)
        {
            int damageDealt = damage - this.Defense;
            if (damageDealt > 0)
            {
                this.Life = this.Life - damageDealt;
            }
        }

        public void Cure()
        {
            this.Life = this.MaxLife;
        }
    }

}
