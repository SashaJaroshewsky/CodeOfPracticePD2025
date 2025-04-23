using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Door: ISwitcheable
    {

        public void Activate()
        {
            Console.WriteLine("Двері відкрились");
        }

        public void Deactivate()
        {
            Console.WriteLine("Двері закрились");
        }
    }
}
