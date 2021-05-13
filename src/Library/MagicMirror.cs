using System;

namespace ROLEPLAY_GAME.Library
{
    public class MagicMirror
    {
        public int DamageValue {get; set; }
        public int DefenseValue {get; set; }
        
        public MagicMirror()
        {
            this.DamageValue = 0;
            this.DefenseValue = 5;
        }
    }
}