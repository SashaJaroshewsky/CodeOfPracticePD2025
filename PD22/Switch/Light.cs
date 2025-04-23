using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    public class Light: ISwitcheable
    {
        public void Activate()
        {
            Console.WriteLine("Лампочка увімкнулась");
        }
        public void Deactivate()
        {
            Console.WriteLine("Лампочка вимкнулась");
        }
    }

}
