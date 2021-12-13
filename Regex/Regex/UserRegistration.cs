using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace UserReg
{
    public class UserRegistration
    {
        public string FirstName()
        {
            Console.WriteLine("Enter First Name");
            string Firstname = Console.ReadLine();
            string Fname = @"[A-Z]{1}[a-z]{2}$";
            Regex rg = new Regex(Fname);

            if (rg.IsMatch(Firstname))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Name is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Plase Enter First Letter Capital and Length of the name upto 3 only");
                Console.ResetColor();
            }

            Console.WriteLine();
            return default;
        }
    }
}
