using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz2PD21
{
    internal class Tiger : Cat
    {
        public Tiger(int year) : base(year)
        {
        }

        public  void Voice()
        {
            Console.WriteLine("Кіт м'явкає");
        }
    }
}
