using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz2PD21
{
    internal class Cat : Animal
    {
        public Cat(int year) : base(year)
        {
        }

        public sealed override void Voice()
        {
            Console.WriteLine("Кіт м'явкає");
        }

        public void Hiss()
        {
            Console.WriteLine("Тік шипить");
        }
    }
}
