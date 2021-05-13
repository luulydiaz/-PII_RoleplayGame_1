namespace clases
{
    public class Elf
    {
        private Dagger dagger = new Dagger();
        private Hood hood = new Hood();
        public string Name { get; set; }
        public int Life { get; set; }
        public int BaseDefense { get; set; }
        public int BaseDamage { get; set; }
        public int Damage { get; }
        public int Defense { get; }

        public Elf(string name, int life, int baseDefense, int baseDamage)
        {
            this.Name = name;
            this.Life = life;
            this.BaseDamage = baseDamage;
            this.BaseDefense = baseDefense;
            this.Damage = baseDamage + dagger.Damage;
            this.Defense = baseDefense + hood.Defense;
        }
        
    }

}
