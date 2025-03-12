using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2
{
    internal class Animal
    {
        protected float Yaer;

        public Animal(int yaer)
        {
            Yaer = yaer;
            Console.WriteLine("Батьківський конструктор");
        }

        public virtual void Voice()
        {
            Console.WriteLine("Тварина шось каже");
        }

    }
}
