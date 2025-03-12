using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2
{
    internal class Moderator : User
    {
        public Moderator(string userName, string email, string password) : base(userName, email, password)
        {

        }

        public void ModerateContent()
        {
            Console.WriteLine("Контент модеровано.");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("===================");
            base.DisplayInfo();
            Console.WriteLine("Роль: Модератор");
            Console.WriteLine("===================");
        }
    }
}
