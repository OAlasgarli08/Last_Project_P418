using Domain.Models;
using Repository.Datas;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public Student Search(string fullName)
        {
            return (Student)DbContext<Student>.Datas.Where(m => m.FullName == fullName);
        }

        public List<Student> Sort(int age)
        {
            return DbContext<Student>.Datas.OrderBy(m => m.Age).ToList();
        }
    }
}
