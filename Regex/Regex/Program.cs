// See https://aka.ms/new-console-template for more information
using UserReg;
using System.Text.RegularExpressions;
UserRegistration User = new UserRegistration();
bool flag = true;
while (flag)
{
    Console.WriteLine("Select:\n" +
        "1)Enter Valid First Name\n" +
        "2)Enter Valid Last Name\n" +
        "3)Enter Valid Email\n" +
        "4)Enter Valid Mobile Number\n" +
        "5)Enter Password-Length shouble be 8\n" +
        "6)Enter Password-Should have atleast one Uppercase\n" +
        "7)Enter Password-Should have atleast One numeric number\n" +
        "8)Enter Password-Should have atleast Special character");
    int op = Convert.ToInt16(Console.ReadLine());
    switch (op)
    {
        case 1:
            User.FirstName();
            break;
        case 2:
            User.LastName();
            break;
        case 3:
            User.Email();
            break;
        case 4:
            User.Mobile();
            break;
        case 5:
            User.PasswordRule1();
            break;
        case 6:
            User.PasswordRule2();
            break;
        case 7:
            User.PasswordRule3();
            break;
        case 8:
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Password:" + User.Password4(password));
            break;
        default:
            flag = !flag;
            break;
    }
}