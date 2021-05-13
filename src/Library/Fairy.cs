using System;

namespace ROLEPLAY_GAME.Library
{
    public class Fairy
    {
        private MagicMirror magicMirror = new MagicMirror();
        private PixieBow pixieBox = new PixieBow();
        
        public Fairy(string name, int life, PixieBow pixieBow, MagicMirror magicMirror, int baseDamage, int baseDefense)
        {
            this.Name = name;
            this.Life = life;
            this.PixieBow = pixieBow;
            this.MagicMirror = magicMirror;
            this.BaseDamage = baseDamage;
            this.BaseDefense = baseDefense;
        }

        private String Name { get; set; }
        private int Life {get; set; }
        private int BaseDamage {get; set;}
        private int BaseDefense { get; set; }
        private PixieBow PixieBow {get; set; }
        private MagicMirror MagicMirror { get; set; }


        public int Damage()
        {
            return this.BaseDamage + PixieBow.DamageValue;
        }

        public int Defense()
        {
            return this.BaseDefense + MagicMirror.DefenseValue;
        }
    }
}
