using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz2PD21
{
    internal class Animal
    {
        public int Year;

        public Animal(int year)
        {
            Year = year;
            Console.WriteLine("Викликався батьківський конструктор");
        }

        public virtual void Voice()
        {
            Console.WriteLine("Тварина видає звуки");
        }

    }
}
