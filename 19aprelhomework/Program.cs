using _19aprelhomework.Models;
using System;

namespace _19aprelhomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password-u daxil edin");
         
            User user = new User("aaaa", "xxxxx", "oooo");
            user.Fullname = "Ziva";
            user.Email = "zivarab@code.edu.az";
            Console.WriteLine($"fullName:{user.Fullname} email{user.Email}\n");

            user.ShowInfo(user.Fullname, user.Email);
            user.ShowInfo(user.Fullname, user.Email);
            Console.WriteLine($"FullName: - {user.Fullname} Email: - {user.Email}");
        }
    }
}
