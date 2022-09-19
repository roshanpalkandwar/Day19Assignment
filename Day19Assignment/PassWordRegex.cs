using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19Assignment
{
    internal class PassWordRegex
    {
        public static void ValidatePassWord()
        {
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();

            string pattern= "^[A-Z a-z]{8,}$";

            if (Regex.IsMatch(password, pattern))
            {
                Console.WriteLine("password is valid");
            }
            else
            {
                Console.WriteLine("password is not valid ");
            }
        }
    }
}
