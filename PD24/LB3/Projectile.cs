using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    abstract class Projectile
    {
        private int _damage;

        public int GetDamage => _damage;

        public Projectile(int damage)
        {
            if (damage < 0)
                throw new ArgumentException("Damage cannot be negative");
            _damage = damage;
        }

        public abstract void HitTarget(IDamageable target);
       
    }
}
