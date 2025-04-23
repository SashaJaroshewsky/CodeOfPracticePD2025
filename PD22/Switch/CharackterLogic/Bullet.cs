using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.CharackterLogic
{
    class Bullet
    {
        private int _damage;

        public Bullet(int damage)
        {
            _damage = damage;
        }

        public void Hit(IDamageable target)
        {
            target.TakeDamage(_damage);
        }
    }
}
