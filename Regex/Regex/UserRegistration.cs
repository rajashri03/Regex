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
        /// Enter Valid First Name
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
        /// <summary>
        /// Enter Valid Last Name
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Enter Valid Email
        /// </summary>
        /// <returns></returns>
        public string Email()
        {
            Console.WriteLine("Enter Your Email");
            string Email = Console.ReadLine();
            string email = @"^[a-zA-Z0-9]+@[A-Za-z0-9]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
            Regex rg = new Regex(email);
            if (rg.IsMatch(Email))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Email is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Email is not valid");
                Console.ResetColor();
            }
            Console.WriteLine();
            return default;
        }
        /// <summary>
        /// Enter Valid Mobile Number
        /// </summary>
        /// <returns></returns>
        public void Mobile()
        {
            Console.WriteLine("Enter Your Mobile");
            string Mobile = Console.ReadLine();
            string Regexphone = @"^[0-9]{2,4}[ ]{1}[6-9]{1}[0-9]{9}$";
            Regex rg = new Regex(Regexphone);
            if (rg.IsMatch(Mobile))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Mobile Number is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Mobile Number is not valid");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Enter Valid Password-Must be atleast 8 characters
        /// </summary>
        /// <returns></returns>
        public void PasswordRule1()
        {
            Console.WriteLine("Enter Your Password");
            string Password1 = Console.ReadLine();
            string Regexpassword1 = @"^[0-9a-zA-z]{8}$";
            Regex rg = new Regex(Regexpassword1);
            if (rg.IsMatch(Password1))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Password is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Must be atleast 8 characters");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Enter Valid Password-Should have atleast one uppercase
        /// </summary>
        /// <returns></returns>
        public void PasswordRule2()
        {
            Console.WriteLine("Enter Your Password");
            string Password2 = Console.ReadLine();
            string Regexpassword2 = @"^(?=.*[A-Z])[0-9a-zA-z]{8}$";
            Regex rg = new Regex(Regexpassword2);
            if (rg.IsMatch(Password2))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Password is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Should Have atleast One Uppercase ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
