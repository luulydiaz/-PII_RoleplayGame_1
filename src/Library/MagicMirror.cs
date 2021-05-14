using System;

namespace FairyClass
{
    public class MagicMirror
    {
        
        public MagicMirror()
        {
            this.DamageValue = 0;
            this.DefenseValue = 5;
        }
         public int DamageValue {get; set; }
        public int DefenseValue {get; set; }
    }
}