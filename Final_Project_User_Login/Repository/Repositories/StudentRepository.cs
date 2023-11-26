using Domain.Models;
using Repository.Datas;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public void Edit(int id, Student student)
        {
            Student existstudent = DbContext<Student>.Datas.FirstOrDefault(m => m.Id == id);
            if(student.FullName != null)
            {
                existstudent.FullName = student.FullName;
            }
            if (student.Address != null)
            {
                existstudent.Address = student.Address;
            }
            if (student.Age != null)
            {
                existstudent.Age = student.Age;
            }
                                   
        }

        public Student Search(string fullName)
        {
            return DbContext<Student>.Datas.FirstOrDefault(m => m.FullName == fullName);
        }

        public List<Student> Sort()
        {
            return DbContext<Student>.Datas.OrderBy(m => m.Age).ToList();
        }
    }
}
