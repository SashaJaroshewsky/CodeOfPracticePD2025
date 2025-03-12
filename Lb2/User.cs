using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2
{
    internal class User
    {
        public string UserName { get; private set; }
        public string Email { get; private set; }
        private string _password { get; set; }

        protected bool _isLocked { get; set; }

        public User(string userName, string email, string password) {
            UserName = userName;
            Email = email;
            _password = password;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"UserName: {UserName}");
            Console.WriteLine($"Email: {Email}");
        }


        public void SetPassword(string email, string oldPassword ,string newPassword)
        {
            if (!Authenticate(email, oldPassword))
            {
                Console.WriteLine("Не вдалось змінити пароль");
                return; 
            }
            _password = newPassword;
            Console.WriteLine("Пароль змінено");

        }

        public bool Authenticate(string email ,string inputPassword)
        {
            return email == Email && _password == inputPassword;
        }

        protected void TryBlock(Admin admin)
        {
            if(admin == this)
                return;
            _isLocked = true;
            Console.WriteLine($"Admin: {admin.UserName} blocked user: {UserName}");
        }

    }
}
