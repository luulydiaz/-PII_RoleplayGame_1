namespace Library
{
    public class Dwarf
    {
        public string Name {get;private set;}
        public int Health {get;private set;}
        public int Attack {get;private set;}
        public int Defense {get;private set;}
        public Glove Glove {get;}
        public RedGem RedGem1 {get;}

        public Dwarf(string name)
        {
            this.Name=name;
            this.Glove= new Glove("Glove");
            this.RedGem1= new RedGem("RedGem1");
            this.Health=100 + RedGem1.Health;
            this.Attack=50 + Guante1.Attack;
            this.Defense=30;
            
        }

        public string ReceiveAttack(Dwarf Enemigo)
        {
            if (Enemigo.Attack<=this.Defense)
            {
                this.Defense-=Enemigo.Attack;
            }
            if (Enemigo.Attack>this.Defense)
            {
                this.Defense=0;
                this.Health-=(Enemigo.Attack-this.Defense);
            }
            if (this.Health<0)
            {
                this.Health=0;
                return $"{this.Name} is dead";
            }
            else 
            {
                return $"{this.Name}'s Health is: {this.Health}";
            }
        }

        public void Curar()
        {
            if (this.Health<100)
            {
                this.Health=100;
            }
        }

        
    }
}