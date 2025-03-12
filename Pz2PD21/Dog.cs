using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz2PD21
{
    internal class Dog : Animal
    {


        public Dog(int year): base(year)
        {
            Console.WriteLine("Викликався дочірній конструктор");
        }

        public void Voice()
        {
            Console.WriteLine("Собака гавкає");
        }

        public void GiveHand()
        {
            Console.WriteLine("Собака дав лапу");
        }
    }
}
