using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lb2PD21
{
    internal class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        private string _password { get; set; }

        public User(string userName, string email, string password)
        {
            UserName = userName;
            Email = email;
            _password = password;
        }

        public void SetPassword(string email, string ondPassword, string newPassword)
        {
            if (!Authenticate(email, ondPassword))
                return;
            _password = newPassword;
        }

        public bool Authenticate(string email, string inputPassword)
        {
            return email == Email && _password == inputPassword;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"UserName: {UserName}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
