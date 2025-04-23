using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.CharackterLogic
{
    interface IDamageable
    {
        int Health { get; }
        void TakeDamage(int damage);
    }
}
