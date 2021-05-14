using System;
using DwarvesClass;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
using System;
using ElfClass;
using WizardClass;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Elf elf = new Elf("Facundo");
            Console.WriteLine("Name: " + elf.Name + "\nLife: " + elf.Life + "\nDamage: " + elf.Damage + "\nDefense: " + elf.Defense);
        }
    }
}
