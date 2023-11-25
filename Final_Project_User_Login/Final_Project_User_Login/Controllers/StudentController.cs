using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_User_Login.Controllers
{
    public class StudentController
    {
        private readonly IStudentService _studentService;
        public StudentController()
        {
            _studentService = new StudentService();
        }

        public void Create()
        {
            Console.WriteLine("Add your Full Name");
            string name = Console.ReadLine();

            Console.WriteLine("Add your Address");
            string address = Console.ReadLine();

            Console.WriteLine("Add your age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Add your phone number");
            string number = Console.ReadLine();
        }
        public void Delete()
        {
            Console.WriteLine();
        }
    }
}
