using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.CharackterLogic
{
    abstract class BaseCharacter : IDamageable
    {
        public string Name { get; }

        private int _health;

        int IDamageable.Health => _health;

        public BaseCharacter(string name, int health)
        {
            Name = name;
            _health = health;
        }

        public void TakeDamage(int damage)
        {
            _health -= damage;
            Console.WriteLine($"{Name} Отримав пошкодження в кількості {damage}");
        }
    }
}
