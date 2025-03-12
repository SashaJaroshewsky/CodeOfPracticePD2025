using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2
{
    internal class Dog: Animal
    {
        public Dog(int yaer):base(yaer) {
            Console.WriteLine("Дочірній конструктор");
        }



        public void Voice()
        {
            Console.WriteLine("Собака гавкає");
        }
    }
}
