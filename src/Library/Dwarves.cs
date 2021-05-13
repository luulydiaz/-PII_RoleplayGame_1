namespace Library
{
    public class Dwarf
    {
        private Glove glove = new Glove();
        private RedGem glove = new RedGem();
        
        public Dwarf(string name, int life, int baseDamage, int baseDefense )
        {
            this.Name = name;
            this.Life = life;
            this.Glove= glove;
            this.RedGem= redGem;
            this.BaseDamage= baseDamage;
            this.BaseDefense= baseDefense;
            
        }
        
        public string Name {get; set;}
        public int Life {get; set;}
        public int BaseDamage {get; set;}
        public int BaseDefense {get; set;}
        public Glove Glove {get; set;}
        public RedGem RedGem {get; set;}

        public int Damage()
        {
            return this.BaseDamage + Glove.DamageValue;
        }

        public int Defense()
        {
            return this.BaseDefense + RedGem.DefenseValue;
        }
    }
}

        