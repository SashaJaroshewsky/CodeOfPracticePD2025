using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    class Bullet : Projectile
    {
        public Bullet(int damage) : base(damage)
        { }
        public override void HitTarget(IDamageable target)
        {
            target.TakeDamage(GetDamage);
        }
    }
}
