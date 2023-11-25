using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces
{
    public interface IBaseRepositroy<T> where T : BaseEntity
    {
        void Create(T entity);
        void Delete(T entity);
        void Edit(T entity);
        T GetById(int id);
        List<T> GetAll();
    }
}
