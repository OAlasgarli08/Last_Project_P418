using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IStudentService
    {
        void Create(Student student);
        void Delete(Student student);
        Student GetById(int id);
        List<Student> GetAll();
        Student Search(string fullName);
        List<Student> Sort();
        void Edit(int id, Student student);
    }
}
