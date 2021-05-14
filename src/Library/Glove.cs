using System;

namespace DwarvesClass
{
    public class Glove
    {
        public Glove()
        {
            this.DamageValue = 5;
            this.DefenseValue = 0;
        }

        public int DamageValue { get; set; }
        
        public int DefenseValue { get; set; }
    }
}