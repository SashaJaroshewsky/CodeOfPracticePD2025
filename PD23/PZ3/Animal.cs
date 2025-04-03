using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PZ3
{
    class Animal
    {
        private string Name { get; set; }
        protected int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Відпрацював конструктор тварини");
        }
        public void MakeSound()
        {
            Console.WriteLine("Звук тварини");
        }

    }
}
