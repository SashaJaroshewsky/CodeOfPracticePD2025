using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2
{
    internal class RegularUser : User
    {
        public RegularUser(string userName, string email, string password) : base(userName, email, password)
        {
        }

        public void PostComment(string messeg)
        {   if(_isLocked)
                return;
            Console.WriteLine($"{UserName}: {messeg}");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("===================");
            base.DisplayInfo();
            Console.WriteLine("Роль: Користувач");
            Console.WriteLine("===================");

        }
    }
}
