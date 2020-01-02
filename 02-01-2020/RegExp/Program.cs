using System;
using System.Text.RegularExpressions;

namespace RegExp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            if(isValidEmail(email))
                Console.WriteLine($"\"{email}\" is Valid");
            else
                Console.WriteLine($"\"{email}\" is Invalid");
        }

        static bool isValidEmail(string email)
        {
            Regex emailPatt = new Regex("^[\\w\\._]+@[\\w\\.]+\\.[A-Za-z]{2,4}$");
            return emailPatt.IsMatch(email);
        }
    }
}
