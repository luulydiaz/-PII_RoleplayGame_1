
namespace DwarvesClass
{
    public class Dwarves
    {
        private int life;
        private Glove glove = new Glove();
        private RedGem redgem = new RedGem();
        public Dwarves(string name)
        {
            this.Glove = glove;
            this.RedGem = redgem;
            this.Name = name;
            this.Life = 100;
            this.MaxLife = 100;
            this.BaseDamage = 5;
            this.BaseDefense = 0;

        }

        public Glove Glove { get; set; }
        public RedGem RedGem { get; set; }
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
                return BaseDamage + redgem.DamageValue + Glove.DamageValue;
            }
        }
        public int Defense
        {
            get
            {
                return BaseDefense + glove.DefenseValue + RedGem.DefenseValue;
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
            this.Life = this.MaxLife;
        }
    }
}
