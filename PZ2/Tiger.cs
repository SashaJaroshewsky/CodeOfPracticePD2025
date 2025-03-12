using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2
{
    internal class Tiger : Cat
    {
        public Tiger(int yaer) : base(yaer)
        {
        }

        public override void Voice()
        {
            Console.WriteLine("Кіт м'явкає");
        }
    }
}
