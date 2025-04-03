using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    class Door:ISwitcheable
    {

        public void Open()
        {
            Console.WriteLine("The door is open.");
        }

        public void Close()
        {
            Console.WriteLine("The door is closed.");
        }

        public void Activate()
        {
            Open();
        }

        public void Deactivate()
        {
            Close();
        }
    }
}
