using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ3
{
    class Dog: Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
            Console.WriteLine("Відпрацював конструктор собаки");
        }
        public void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
          
            
        }

        public void GivePaw()
        {
            Console.WriteLine("Собака дає лапу");
        }

    }
    
    
}
