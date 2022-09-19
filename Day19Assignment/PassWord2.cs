using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19Assignment
{
    internal class PassWord2
    {
        public static void ValidatePassWord2()
        {
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();

            string pattern = "^[A-Z a-z]{8,}$";

            if (Regex.IsMatch(password, pattern))
            {
                Console.WriteLine("password  is a valid");
            }
            else
            {
                Console.WriteLine("password is not valid ");
            }

        }
    }
}
