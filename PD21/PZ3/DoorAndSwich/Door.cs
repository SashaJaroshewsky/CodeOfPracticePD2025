using System;
using System.Collections.Generic;

namespace PZ3.DoorAndSwich
{
    public class Door : ISwitchable
    {
        public void Off()
        {
            Console.WriteLine("Door open");
        }

        public void On()
        {
            Console.WriteLine("Door close");
        }
    }
}
