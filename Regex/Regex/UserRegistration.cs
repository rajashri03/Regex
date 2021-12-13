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
        /// <summary>
        /// Enter Valid First Name--First letter must be Capital and legth should be 3 Characters
        /// </summary>
        /// <returns></returns>
        public string FirstName()
        {
            Console.WriteLine("Enter First Name");
            string Firstname = Console.ReadLine();
            string Fname = @"[A-Z]{1}[a-z]{2}$";
            Regex rg = new Regex(Fname);
            if (rg.IsMatch(Firstname))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("First Name is Valid");
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
        public string LastName()
        {
            Console.WriteLine("Enter Last Name");
            string Lastname = Console.ReadLine();
            string Lname = @"[A-Z]{1}[a-z]{2}$";
            Regex rg = new Regex(Lname);
            if (rg.IsMatch(Lastname))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Last Name is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Last Name is not valid.(Please Enter First Letter Capital and Length of the LastName Should be 3 only)");
                Console.ResetColor();
            }

            Console.WriteLine();
            return default;
        }
    }
}
