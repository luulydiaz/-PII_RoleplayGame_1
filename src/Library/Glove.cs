using System;

namespace Library
{
    public class Glove
    {
        public string Name {get;private set;}
        public int Defense {get;set;}
        public int Attack {get;set;}
        public int Health {get;set;}


        public Glove(string name)
        {
            this.Name = name;
            this.Defense=0;
            this.Attack=40;
            this.Health=0;

        }
        
    }
}