using _19aprelhomework.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _19aprelhomework.Models
{
    class User : IAccount
    {
        public string Fullname;
        public string Email;
        private string _password;
        public void PasswordChecker(string Password)
        {
         
                bool check = true;

                while (check)
                {
                    bool checkLower = false;
                    bool checkUpper = false;
                    bool checkDigit = false;

                    if (Password.Length >= 8)
                    {
                        foreach (char item in Password)
                        {
                            if (char.IsUpper(item))
                            {
                                checkUpper = true;
                            }
                            else if (char.IsLower(item))
                            {
                                checkLower = true;
                            }
                            else if (char.IsDigit(item))
                            {
                                checkDigit = true;
                            }

                            if (checkLower == true && checkUpper && checkDigit)
                            {
                                _password = Password;
                                check = false;
                                break;
                            }
                        }

                        if (checkDigit == false || checkLower == false || checkUpper == false)
                        {
                            Console.WriteLine("Sifreni Duzgun Daxil Et:");
                            Password = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sifre Minimum 8 simvol Olmalidir");
                        Password = Console.ReadLine();
                    }
                }
           }
      
        public string ShowInfo(string Fullname, string Email)
        {
            return ($"Fullname:{Fullname}Email: { Email}");
        }

        public User(string fullName, string email, string password)
        {
            Fullname = fullName;
            Email = email;
            _password = password;
        }
    }
}
