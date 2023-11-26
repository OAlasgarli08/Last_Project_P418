using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Final_Project_User_Login.Controllers
{
    public class UserController
    {
        private readonly IUserService _userService;
        public UserController()
        {
            _userService = new UserService();
        }


        public void SignUp()
        {
            Console.WriteLine("Write your name");
            string name = Console.ReadLine();

            Console.WriteLine("Write your surname");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());

        Email: Console.WriteLine("Register your email");

            string email = Console.ReadLine();

            if (email == "")
            {
                Console.WriteLine("Cannot be left empty");
                goto Email;
            }

            if (!email.Contains("@"))
            {

                Console.WriteLine("Should contain @ logo");
                goto Email;
            }

            


            Console.WriteLine("Register a password");
            string password = Console.ReadLine();

            Console.WriteLine("Please confirm your password");
            string confirmPassword = Console.ReadLine();


            _userService.SignUp(name, surname, email, age, password, confirmPassword);
        }

        public void Login()
        {
            Console.WriteLine("Email:");
            string email = Console.ReadLine();

            Console.WriteLine("Password:");
            string password = Console.ReadLine();

            _userService.LoginIn(email, password);
        }
    }
}
