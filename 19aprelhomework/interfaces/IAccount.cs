using System;
using System.Collections.Generic;
using System.Text;

namespace _19aprelhomework.interfaces
{
    interface IAccount
    {
        public void PasswordChecker(string Password);
        public string ShowInfo(string Fullname, string Email);
    }
}
