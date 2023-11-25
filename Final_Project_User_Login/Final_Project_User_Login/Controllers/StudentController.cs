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

            _studentService.Create(new Domain.Models.Student { FullName = name, Age = age, Address = address, Phone = number});
        }
        public void Delete()
        {
            Console.WriteLine("Write the Id of the student you want to delete");
            int id = int.Parse(Console.ReadLine());

            _studentService.Delete(new Domain.Models.Student { Id = id });
        }

        public void GetAll()
        {
            var students = _studentService.GetAll(); 
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id} + {student.FullName} + {student.Age} + {student.Phone} + {student.Address}");
            }
        }
    }
}
