using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    class Enemy : IDamageable
    {
        private int _health;

        public int GetHealth => _health;

        public Enemy(int health)
        {
            if (health < 0)
                throw new ArgumentException("Health cannot be negative");
            _health = health;
        }

        public bool IsAlive()
        {
            if (_health <= 0)
                return false;
            
            return true;
        }

        public void TakeDamage(int damage)
        {
            if (damage < 0)
                throw new ArgumentException("Damage cannot be negative");

            _health -= damage;
            if (_health < 0)
                _health = 0;
            Console.WriteLine(GetHealth);
            IsAlive();
        }
    }
}
