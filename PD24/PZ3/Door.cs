using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ3
{
    class Door : ISwitcheable
    {
        public void Activate()
        {
            Console.WriteLine("Door Activate");
        }


        public void Deactivate()
        {
            Console.WriteLine("Door Deactivate");
        }
    }
}
