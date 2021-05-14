using System;

namespace FairyClass
{
    public class Fairy
    {
        private int life;
        private MagicMirror magicMirror = new MagicMirror();
        private PixieBow pixieBow = new PixieBow();
        
        
        public Fairy(string name)
        {
            this.PixieBow = pixieBow;
            this.MagicMirror = magicMirror;
            this.Name = name;
            this.Life = 100;
            this.MaxLife = 100;
            this.BaseDamage = 3;
            this.BaseDefense = 1;
        }

        public PixieBow PixieBow {get; set; }
        public MagicMirror MagicMirror { get; set; }
        public int MaxLife { get; set; }
        private int Life 
        {
            get
            {
                return this.life;
            }
            set
            {
                if (value >= 0)
                {
                    this.life = value;
                }
                else if (value<0)
                {
                    this.life=0;
                }
                else
                {
                    this.life= 0;
                }
            }
        }
        public String Name { get; set; }
        public int BaseDamage {get; set;}
        public int BaseDefense { get; set; }


        public int Damage
        {
           get
           {
               return this.BaseDamage + PixieBow.DamageValue + MagicMirror.DamageValue;
           }

        }

        public int Defense
        {
            get
            {
                return this.BaseDefense + PixieBow.DefenseValue + MagicMirror.DefenseValue;
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
            if (this.life>0)
           {
               this.life = this.MaxLife;
           }
        }
    }
}
