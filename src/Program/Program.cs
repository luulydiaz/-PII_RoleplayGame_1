using System;
using clases;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Elf elf = new Elf("Facundo", 80, 2, 8);
            Console.WriteLine("Name: " + elf.Name + "\nLife: " + elf.Life + "\nDamage: " + elf.Damage + "\nDefense: " + elf.Defense);

        }
    }
}
