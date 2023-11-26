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

        public void StudentCreate()
        {
            Console.WriteLine("Add your Full Name");
            string name = Console.ReadLine();

            Console.WriteLine("Add your Address");
            string address = Console.ReadLine();

            Console.WriteLine("Add your age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Add your phone number");
            string number = Console.ReadLine();

            _studentService.Create(new Domain.Models.Student { FullName = name, Age = age, Address = address, Phone = number });

            Console.WriteLine("Which group is he in?");
            string group = Console.ReadLine();
            Console.WriteLine($"{name} is in {group}");

        }
        public void StudentDelete()
        {
            Console.WriteLine("Write the id of the student you want to delete");
        Id: string idStr = Console.ReadLine();
            int id;
            bool isCorrectId = int.TryParse(idStr, out id);

            if (isCorrectId)
            {
                var student = _studentService.GetById(id);
                _studentService.Delete(student);
            }
            else
            {
                Console.WriteLine("That student doesn't exist!");
                goto Id;
            }
        }

        public void StudentGetAll()
        {
            var students = _studentService.GetAll();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id} + {student.FullName} + {student.Age} + {student.Phone} + {student.Address}");
            }
        }

        public void StudentGetById()
        {
            Console.WriteLine("Write the id of the person you want to find");
            int id = int.Parse(Console.ReadLine());

            var students = _studentService.GetById(id);

            Console.WriteLine($"{students.Id} + {students.FullName} + {students.Age} + {students.Address} + {students.Phone}");
        }

        public void StudentSearch()
        {
            Console.WriteLine("Write the person's name and surname you want to search");
        FullName: string fullName = Console.ReadLine();

            if (fullName == null)
            {
                Console.WriteLine("Don't leave this empty!");
                goto FullName;
            }

            var student = _studentService.Search(fullName);
            Console.WriteLine($"{student.Id} + {student.FullName} + {student.Age} + {student.Address} + {student.Phone}");
        }

        public void StudentSort()
        {
            var students = _studentService.Sort();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id} + {student.FullName} + {student.Age} + {student.Address} + {student.Phone}");
            }
        }

        public void StudentEdit()
        {
            Console.WriteLine("Write the id of the student you want to edit");
        Id: string idStr = Console.ReadLine();
            int id;
            bool isCorrectId = int.TryParse(idStr, out id);

            if (isCorrectId)
            {
                var student = _studentService.GetById(id);
            }
            else
            {
                Console.WriteLine("That student doesn't exist!");
                goto Id;
            }

            Console.WriteLine("Choose student name and surname:");
            string fullName = Console.ReadLine();

            Console.WriteLine("Choose student age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose student Address:");
            string address = Console.ReadLine();

            Console.WriteLine("Choose student phone number");
            string number = Console.ReadLine();

            _studentService.Edit(id, new Domain.Models.Student { FullName = fullName, Address = address, Age = age, Phone = number });

        }
    }
}
