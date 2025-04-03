using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    class Light:ISwitcheable
    {
       
        public void Activate()
        {
            Console.WriteLine("The light is on.");
        }

        public void Deactivate()
        {
            Console.WriteLine("The light is off.");
        }
    }
}
