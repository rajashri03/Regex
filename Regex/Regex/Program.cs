// See https://aka.ms/new-console-template for more information
using UserReg;
using System.Text.RegularExpressions;
UserRegistration User=new UserRegistration();
bool flag = true;
while(flag)
{
    Console.WriteLine("Select:\n1)Enter Valid First Name\n2)Enter Valid Last Name\n3)Enter Valid Email");
    int op = Convert.ToInt16(Console.ReadLine());
    switch(op)
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
    }
}